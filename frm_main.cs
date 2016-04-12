using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Text.RegularExpressions;
using Ionic.Zip;
using System.Xml;
using System.Xml.Linq;

namespace WindowsFormsApplication1
{
    public partial class frm_main : Form
    {
        Dictionary<String, int> mapBGTileWidth = new Dictionary<String, int>();
        Dictionary<String, int> mapBGTileHeight = new Dictionary<String, int>();
        Dictionary<String, int> mapBGImageWidth = new Dictionary<String, int>();
        Dictionary<String, int> mapBGImageHeight = new Dictionary<String, int>();

        delegate void SetTextCallback(string text);

        private List<BackgroundWorker> workerList = new List<BackgroundWorker>();

        private int room_min_width = 0, room_min_height = 0, room_shift_x = 0, room_shift_y = 0;
        private bool room_shift_always = true, room_shift_contents_x = false, room_shift_contents_y = false;

        private int bgCount, roomCount;
        private string saveAsFilename;

        private bool processBGs, processRooms;

        public frm_main()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (workerList != null && workerList.Count > 0)
            {
                foreach (BackgroundWorker worker in workerList)
                {
                    if (worker.IsBusy)
                    {
                        worker.CancelAsync();
                    }
                }
            }
        }

        private void SRC_BG_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                SRC_BG_TEXT.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void SRC_ROOM_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                SRC_ROOM_TEXT.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void DEST_BG_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                DEST_BG_TEXT.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void DEST_ROOM_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                DEST_ROOM_TEXT.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void toggleGUI(bool isOn)
        {
            SRC_BG.Enabled = isOn;
            SRC_BG_TEXT.Enabled = isOn;

            SRC_ROOM.Enabled = isOn;
            SRC_ROOM_TEXT.Enabled = isOn;

            DEST_BG.Enabled = isOn;
            DEST_BG_TEXT.Enabled = isOn;

            DEST_ROOM.Enabled = isOn;
            DEST_ROOM_TEXT.Enabled = isOn;

            SRC_HOFF_TEXT.Enabled = isOn;
            SRC_VOFF_TEXT.Enabled = isOn;
            SRC_HSEP_TEXT.Enabled = isOn;
            SRC_VSEP_TEXT.Enabled = isOn;

            DEST_HOFF_TEXT.Enabled = isOn;
            DEST_VOFF_TEXT.Enabled = isOn;
            DEST_HSEP_TEXT.Enabled = isOn;
            DEST_VSEP_TEXT.Enabled = isOn;

            BACKUP.Enabled = isOn;
            PROCESS.Enabled = isOn;

            lockMapsToolStripMenuItem.Enabled = isOn;
        }

        private void PROCESS_Click(object sender, EventArgs e)
        {
            int check = checkInput();

            string caption, message;

            if(check != 1)
            {
                caption = "Error";
                message = "[Unhandled exception]";

                if (check == -5 || check == -6)
                {
                    caption = "Warning";
                    message = "Files present in the destination directories will be overwritten. Continue?";

                    var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes) { check = 1; }
                }
                else
                {
                    if (check == -1) { message = "Invalid input for offsets!"; }
                    if (check == -2) { message = "BG paths invalid!"; }
                    if (check == -3) { message = "Room paths invalid!"; }
                    if (check == -4) { message = "No files to process!"; }

                    var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                }
            }
            
            if(check == 1)
            {
                toggleGUI(false);

                if (!bgWorker.IsBusy)
                {
                    workerList.Add(bgWorker);
                    bgWorker.WorkerReportsProgress = true;
                    bgWorker.WorkerSupportsCancellation = true;
                    bgWorker.RunWorkerAsync();
                }
            }
        }

        private void BACKUP_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(SRC_BG_TEXT.Text) && Directory.Exists(SRC_ROOM_TEXT.Text))
            {
                SaveFileDialog saveAs = new SaveFileDialog();

                saveAs.Filter = "Compressed Archive|*.zip";

                if (saveAs.ShowDialog() == DialogResult.OK)
                {
                    toggleGUI(false);

                    LABEL_STATUS.Text = "Compressing " + Path.GetFileName(saveAs.FileName) + "...";
                    saveAsFilename = saveAs.FileName;

                    if (!zipWorker.IsBusy)
                    {
                        workerList.Add(zipWorker);
                        zipWorker.WorkerReportsProgress = true;
                        zipWorker.WorkerSupportsCancellation = true;
                        zipWorker.RunWorkerAsync();
                    }
                }
            }
            else
            {
                var result = MessageBox.Show("Source paths invalid!", "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);

                toggleGUI(true);
            }
        }

        private void zipWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int numBGs = Directory.GetFiles(SRC_BG_TEXT.Text, "*.background.gmx").Length;
            int numRooms = Directory.GetFiles(SRC_ROOM_TEXT.Text, "*.room.gmx").Length;

            int bgCount = 0;
            int roomCount = 0;

            BackgroundWorker worker = sender as BackgroundWorker;

            using (ZipFile zip = new ZipFile())
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    int percentComplete = 0;
                    foreach (var file in Directory.EnumerateFiles(SRC_BG_TEXT.Text, "*.background.gmx"))
                    {
                        zip.AddFile(file, @"\background");
                        bgCount += 1;
                        percentComplete = (int)((float)(bgCount + roomCount) / (float)(numBGs + numRooms) * 80);
                        worker.ReportProgress(percentComplete);
                    }

                    foreach (var file in Directory.EnumerateFiles(SRC_ROOM_TEXT.Text, "*.room.gmx"))
                    {
                        zip.AddFile(file, @"\rooms");
                        roomCount += 1;
                        percentComplete = (int)((float)(bgCount + roomCount) / (float)(numBGs + numRooms) * 80);
                        worker.ReportProgress(percentComplete);
                    }

                    zip.Save(saveAsFilename);

                    worker.ReportProgress(100);
                }
            }
        }

        private void zipWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PROGRESS.Value = e.ProgressPercentage;
        }

        private void zipWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            if (worker != null && workerList.Contains(worker))
            {
                workerList.Remove(worker);
            }

            toggleGUI(true);
            PROGRESS.Value = 0;
            LABEL_STATUS.Text = "Compression of " + Path.GetFileName(saveAsFilename) + " completed.";
        }

        private int checkInput()
        {
            String sourceBG = SRC_BG_TEXT.Text;
            String sourceRoom = SRC_ROOM_TEXT.Text;
            String destBG = DEST_BG_TEXT.Text;
            String destRoom = DEST_ROOM_TEXT.Text;

            if (!Directory.Exists(sourceBG) && Directory.Exists(destBG)) { return -2; }
            if (!Directory.Exists(destBG) && Directory.Exists(sourceBG)) { return -2; }
            if (!Directory.Exists(sourceBG) && !Directory.Exists(destBG)) { return -2; }

            if (!Directory.Exists(sourceRoom) && Directory.Exists(destRoom)) { return -3; }
            if (!Directory.Exists(destRoom) && Directory.Exists(sourceRoom)) { return -3; }
            if (!Directory.Exists(destRoom) && !Directory.Exists(sourceRoom)) { return -3; }

            if (!Directory.Exists(sourceBG) && !Directory.Exists(sourceRoom) &&
                !Directory.Exists(destBG) && !Directory.Exists(destRoom)) { return -4; }

            if(Directory.Exists(sourceBG) && Directory.Exists(sourceRoom))
            {
                int numBGs = Directory.GetFiles(sourceBG, "*.background.gmx").Length;
                int numRooms = Directory.GetFiles(sourceRoom, "*.room.gmx").Length;

                if (numBGs == 0 && numRooms == 0) { return -4; }
            }

            int number;

            if (!int.TryParse(SRC_HOFF_TEXT.Text, out number)) { return -1; }
            if (!int.TryParse(SRC_VOFF_TEXT.Text, out number)) { return -1; }
            if (!int.TryParse(SRC_HSEP_TEXT.Text, out number)) { return -1; }
            if (!int.TryParse(SRC_VSEP_TEXT.Text, out number)) { return -1; }

            if (!int.TryParse(DEST_HOFF_TEXT.Text, out number)) { return -1; }
            if (!int.TryParse(DEST_VOFF_TEXT.Text, out number)) { return -1; }
            if (!int.TryParse(DEST_HSEP_TEXT.Text, out number)) { return -1; }
            if (!int.TryParse(DEST_VSEP_TEXT.Text, out number)) { return -1; }

            if (Directory.Exists(destBG))
            {
                if (String.Equals(sourceBG, destBG, StringComparison.OrdinalIgnoreCase) ||
                    Directory.GetFiles(destBG, "*.background.gmx").Length > 0)
                {
                    return -5;
                }
            }

            if (Directory.Exists(destRoom))
            {
                if (String.Equals(sourceRoom, destRoom, StringComparison.OrdinalIgnoreCase) ||
                    Directory.GetFiles(destRoom, "*.room.gmx").Length > 0)
                {
                    return -6;
                }
            }

            return 1;
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            if (worker != null && workerList.Contains(worker))
            {
                workerList.Remove(worker);
            }

            toggleGUI(true);

            mapBGTileWidth.Clear();
            mapBGTileHeight.Clear();

            if (processBGs && processRooms)
            {
                LABEL_STATUS.Text = "Processed " + bgCount.ToString() + " backgrounds and " + roomCount.ToString() + " rooms.";
            }
            else if (processRooms)
            {
                LABEL_STATUS.Text = "Processed " + roomCount.ToString() + " rooms.";
            }
            else
            {
                LABEL_STATUS.Text = "Processed " + bgCount.ToString() + " backgrounds.";
            }

            PROGRESS.Value = 0;
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PROGRESS.Value = e.ProgressPercentage;
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //translate input values

            int sourceHOff, sourceVOff, sourceHSep, sourceVSep,
                destHOff, destVOff, destHSep, destVSep;

            int.TryParse(SRC_HOFF_TEXT.Text, out sourceHOff);
            int.TryParse(SRC_VOFF_TEXT.Text, out sourceVOff);
            int.TryParse(SRC_HSEP_TEXT.Text, out sourceHSep);
            int.TryParse(SRC_VSEP_TEXT.Text, out sourceVSep);

            int.TryParse(DEST_HOFF_TEXT.Text, out destHOff);
            int.TryParse(DEST_VOFF_TEXT.Text, out destVOff);
            int.TryParse(DEST_HSEP_TEXT.Text, out destHSep);
            int.TryParse(DEST_VSEP_TEXT.Text, out destVSep);

            String sourceBG = SRC_BG_TEXT.Text;
            String sourceRoom = SRC_ROOM_TEXT.Text;
            String destBG = DEST_BG_TEXT.Text;
            String destRoom = DEST_ROOM_TEXT.Text;

            bool lockTiles = lockMapsToolStripMenuItem.Checked;

            processBGs = false;
            processRooms = false;

            int numBGs = 0;
            int numRooms = 0;

            if (Directory.Exists(sourceBG))
            {
                numBGs = Directory.GetFiles(sourceBG, "*.background.gmx").Length;
            }

            if (Directory.Exists(sourceRoom))
            {
                numRooms = Directory.GetFiles(sourceRoom, "*.room.gmx").Length;
            }

            bgCount = 0;
            roomCount = 0;

            BackgroundWorker worker = sender as BackgroundWorker;

            ///////////////////////TILESET PROCESSING///////////////////////

            if (Directory.Exists(sourceBG) && Directory.Exists(destBG) && numBGs > 0)
            {
                processBGs = true;

                foreach (var file in Directory.EnumerateFiles(sourceBG, "*.background.gmx"))
                {
                    if (worker.CancellationPending == true)
                    {
                        e.Cancel = true;
                        return;
                    }
                    else
                    {
                        SetText("Processing " + Path.GetFileName(file) + "...");

                        XDocument doc = XDocument.Load(file);

                        

                        foreach (XElement xe in doc.Descendants("background"))
                        {
                            if (worker.CancellationPending == true)
                            {
                                e.Cancel = true;
                                return;
                            }
                            else
                            {
                                if (xe.Element("istileset").Value == "-1")
                                {
                                    String imagePath = sourceBG + "\\" + xe.Element("data").Value;

                                    System.Drawing.Image img = System.Drawing.Image.FromFile(imagePath);

                                    mapBGImageWidth.Add(
                                        Path.GetFileNameWithoutExtension(Path.GetFileNameWithoutExtension(file)), img.Width);

                                    mapBGImageHeight.Add(
                                        Path.GetFileNameWithoutExtension(Path.GetFileNameWithoutExtension(file)), img.Height);

                                    img.Dispose();

                                    mapBGTileWidth.Add(
                                        Path.GetFileNameWithoutExtension(Path.GetFileNameWithoutExtension(file)),
                                        Int32.Parse(xe.Element("tilewidth").Value));

                                    mapBGTileHeight.Add(
                                        Path.GetFileNameWithoutExtension(Path.GetFileNameWithoutExtension(file)),
                                        Int32.Parse(xe.Element("tileheight").Value));

                                    xe.Element("tilexoff").Value = destHOff.ToString();
                                    xe.Element("tileyoff").Value = destVOff.ToString();
                                    xe.Element("tilehsep").Value = destHSep.ToString();
                                    xe.Element("tilevsep").Value = destVSep.ToString();

                                    doc.Save(destBG + "\\" + Path.GetFileName(file));

                                    bgCount += 1;
                                }
                                else
                                {
                                    numBGs -= 1;
                                    Debug.Print(numBGs.ToString());
                                }
                            }
                        }

                        int percentComplete = (int)((float)(bgCount + (roomCount * 2)) / (float)(numBGs + (numRooms * 2)) * 100);
                        worker.ReportProgress(percentComplete);
                    }
                }
            }

            ///////////////////////ROOM PROCESSING///////////////////////

            if (Directory.Exists(sourceRoom) && Directory.Exists(destRoom) && numRooms > 0)
            {
                processRooms = true;

                foreach (var file in Directory.EnumerateFiles(sourceRoom, "*.room.gmx"))
                {
                    if (worker.CancellationPending == true)
                    {
                        e.Cancel = true;
                        return;
                    }
                    else
                    {
                        SetText("Processing " + Path.GetFileName(file) + "...");

                        XDocument doc = XDocument.Load(file);

                        // modify room dimensions
                        foreach(XElement xe in doc.Descendants("width").ToList())
                        {
                            if (xe != null) 
                            {
                                int width = Int32.Parse(xe.Value);

                                if(room_min_width > 0 && width < room_min_width)
                                {
                                    xe.Value = room_min_width.ToString();
                                    room_shift_contents_x = true;
                                }
                            }
                        }

                        foreach (XElement xe in doc.Descendants("height").ToList())
                        {
                            if (xe != null)
                            {
                                int height = Int32.Parse(xe.Value);

                                if (room_min_height > 0 && height < room_min_height)
                                {
                                    xe.Value = room_min_height.ToString();
                                    room_shift_contents_y = true;
                                }
                            }
                        }

                        foreach (XElement xe in doc.Descendants("instance").ToList())
                        {
                            if (worker.CancellationPending == true)
                            {
                                e.Cancel = true;
                                return;
                            }
                            else
                            {
                                if (xe != null)
                                {
                                    // shift instance positions if needed
                                    if (room_shift_always || room_shift_contents_x)
                                    {
                                        int x = Int32.Parse(xe.Attribute("x").Value);
                                        x += room_shift_x;
                                        xe.Attribute("x").Value = x.ToString();
                                    }

                                    if (room_shift_always || room_shift_contents_y)
                                    {
                                        int y = Int32.Parse(xe.Attribute("y").Value);
                                        y += room_shift_y;
                                        xe.Attribute("y").Value = y.ToString();
                                    }
                                }
                            }
                        }

                        foreach (XElement xe in doc.Descendants("tile").ToList())
                        {
                            if (worker.CancellationPending == true)
                            {
                                e.Cancel = true;
                                return;
                            }
                            else
                            {
                                if (xe != null)
                                {
                                    // shift instance positions if needed
                                    if (room_shift_always || room_shift_contents_x)
                                    {
                                        int x = Int32.Parse(xe.Attribute("x").Value);
                                        x += room_shift_x;
                                        xe.Attribute("x").Value = x.ToString();
                                    }

                                    if (room_shift_always || room_shift_contents_y)
                                    {
                                        int y = Int32.Parse(xe.Attribute("y").Value);
                                        y += room_shift_y;
                                        xe.Attribute("y").Value = y.ToString();
                                    }

                                    // cut up tiles if they're irregular
                                    string bgName = xe.Attribute("bgName").Value;

                                    int tileW, tileH, imgW, imgH;

                                    mapBGTileWidth.TryGetValue(bgName, out tileW);
                                    mapBGTileHeight.TryGetValue(bgName, out tileH);
                                    mapBGImageWidth.TryGetValue(bgName, out imgW);
                                    mapBGImageHeight.TryGetValue(bgName, out imgH);

                                    if (tileW != 0 && tileH != 0)
                                    {
                                        int width, height;

                                        width = Int32.Parse(xe.Attribute("w").Value);
                                        height = Int32.Parse(xe.Attribute("h").Value);

                                        if (width != tileW || height != tileH)
                                        {
                                            if (width < tileW)
                                            {
                                                tileW = width;
                                            }

                                            if (height < tileH)
                                            {
                                                tileH = height;
                                            }

                                            xe.Attribute("w").Value = tileW.ToString();
                                            xe.Attribute("h").Value = tileH.ToString();

                                            int tileX, tileY, xo, yo;

                                            tileX = Int32.Parse(xe.Attribute("x").Value);
                                            tileY = Int32.Parse(xe.Attribute("y").Value);
                                            xo = Int32.Parse(xe.Attribute("xo").Value);
                                            yo = Int32.Parse(xe.Attribute("yo").Value);

                                            int nameCount = 0;

                                            int xPieces, yPieces;

                                            while (width % tileW != 0 || height % tileH != 0)
                                            {
                                                if (width % 2 != 0 || height % 2 != 0) { break; }  //irregular tile

                                                tileW /= 2;
                                                tileH /= 2;
                                            }

                                            int diffX = 0, diffY = 0;

                                            if (xo + width + tileW > imgW)
                                            {
                                                diffX = (xo + width + tileW) - imgW;
                                            }

                                            if (yo + height + tileH > imgH)
                                            {
                                                diffX = (yo + height + tileH) - imgH;
                                            }

                                            xPieces = (width - diffX) / tileW;
                                            yPieces = (height - diffY) / tileH;

                                            for (int j = 0; j < yPieces; j++)
                                            {
                                                for (int i = 0; i < xPieces; i++)
                                                {
                                                    nameCount++;

                                                    XElement newTile = new XElement("tile",
                                                        new XAttribute("bgName", xe.Attribute("bgName").Value),
                                                        new XAttribute("x", (tileX + room_shift_x + (i * tileW)).ToString()),
                                                        new XAttribute("y", (tileY + room_shift_y + (j * tileH)).ToString()),
                                                        new XAttribute("w", tileW.ToString()),
                                                        new XAttribute("h", tileH.ToString()),
                                                        new XAttribute("xo", (xo + (i * tileW)).ToString()),
                                                        new XAttribute("yo", (yo + (j * tileH)).ToString()),
                                                        new XAttribute("id", xe.Attribute("id").Value),
                                                        new XAttribute("name", xe.Attribute("name").Value
                                                            + "_" + ((xPieces * yPieces) - nameCount).ToString()),
                                                        new XAttribute("depth", xe.Attribute("depth").Value),
                                                        new XAttribute("locked", xe.Attribute("locked").Value),
                                                        new XAttribute("colour", xe.Attribute("colour").Value),
                                                        new XAttribute("scaleX", xe.Attribute("scaleX").Value),
                                                        new XAttribute("scaleY", xe.Attribute("scaleY").Value));

                                                    xe.AddAfterSelf(newTile);
                                                }
                                            }

                                            xe.Remove();
                                        }
                                    }
                                }
                            }
                        }

                        int count = 10000000;

                        foreach (XElement xe in doc.Descendants("tile").ToList())
                        {
                            if (worker.CancellationPending == true)
                            {
                                e.Cancel = true;
                                return;
                            }
                            else
                            {
                                if (xe != null)
                                {
                                    string bgName = xe.Attribute("bgName").Value;

                                    int tileW, tileH;

                                    mapBGTileWidth.TryGetValue(bgName, out tileW);
                                    mapBGTileHeight.TryGetValue(bgName, out tileH);

                                    if (lockTiles)
                                    {
                                        if (xe.Attribute("locked").Value == "0")
                                        {
                                            xe.Attribute("locked").Value = "1";
                                        }
                                    }
                                    else
                                    {
                                        if (xe.Attribute("locked").Value == "1")
                                        {
                                            xe.Attribute("locked").Value = "0";
                                        }
                                    }

                                    xe.Attribute("id").Value = count.ToString();
                                    count++;

                                    if (tileW != 0 && tileH != 0)
                                    {
                                        int tileCurrentXOrigin, tileCurrentYOrigin, tileNewXOrigin, tileNewYOrigin;

                                        tileCurrentXOrigin = Int32.Parse(xe.Attribute("xo").Value);
                                        tileCurrentYOrigin = Int32.Parse(xe.Attribute("yo").Value);

                                        tileNewXOrigin = tileCurrentXOrigin + (destHOff - sourceHOff) + ((destHSep - sourceHSep) * (tileCurrentXOrigin / tileW));
                                        tileNewYOrigin = tileCurrentYOrigin + (destVOff - sourceVOff) + ((destVSep - sourceVSep) * (tileCurrentYOrigin / tileH));

                                        xe.Attribute("xo").Value = tileNewXOrigin.ToString();
                                        xe.Attribute("yo").Value = tileNewYOrigin.ToString();
                                    }
                                }
                            }
                        }

                        // omit XML declaration (for GM)
                        var xml_settings = new XmlWriterSettings
                        {
                            OmitXmlDeclaration = true,
                            Indent = true
                        };

                        // save file
                        using(var stream = File.Create(destRoom + "\\" + Path.GetFileName(file)))
                        {
                            using(var writer = XmlWriter.Create(stream, xml_settings))
                            {
                                doc.Save(writer);
                            }
                        }
                        
                        roomCount += 1;

                        int percentComplete = (int)((float)(bgCount + (roomCount * 2)) / (float)(numBGs + (numRooms * 2)) * 100);
                        worker.ReportProgress(percentComplete);
                    }
                }
            }
        }

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.

            try
            {
                if (this.LABEL_STATUS.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(SetText);
                    this.Invoke(d, new object[] { text });
                }
                else
                {
                    this.LABEL_STATUS.Text = text;
                }
            }
            catch (Exception e)
            {
                //
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = "Content\\manual.pdf";

            if(File.Exists(path))
            {
                System.Diagnostics.Process.Start(path);
            }
            else
            {
                MessageBox.Show("File not found.", "File not found.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frm_resize resizeForm = new frm_resize(room_min_width, room_min_height, room_shift_x, room_shift_y, room_shift_always))
            {
                resizeForm.ShowDialog();

                room_min_width = resizeForm.MinimumWidth;
                room_min_height = resizeForm.MinimumHeight;
                room_shift_x = resizeForm.ShiftX;
                room_shift_y = resizeForm.ShiftY;
                room_shift_always = resizeForm.ShiftAlways;
            }
        }
    }
}
