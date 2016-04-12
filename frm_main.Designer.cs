namespace WindowsFormsApplication1
{
    partial class frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DEST_VSEP_TEXT = new System.Windows.Forms.TextBox();
            this.DEST_HSEP_TEXT = new System.Windows.Forms.TextBox();
            this.DEST_VOFF_TEXT = new System.Windows.Forms.TextBox();
            this.DEST_HOFF_TEXT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SRC_ROOM = new System.Windows.Forms.Button();
            this.SRC_BG = new System.Windows.Forms.Button();
            this.SRC_ROOM_TEXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SRC_BG_TEXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DEST_ROOM = new System.Windows.Forms.Button();
            this.DEST_ROOM_TEXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DEST_BG = new System.Windows.Forms.Button();
            this.DEST_BG_TEXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SRC_VSEP_TEXT = new System.Windows.Forms.TextBox();
            this.SRC_HSEP_TEXT = new System.Windows.Forms.TextBox();
            this.SRC_VOFF_TEXT = new System.Windows.Forms.TextBox();
            this.SRC_HOFF_TEXT = new System.Windows.Forms.TextBox();
            this.PROCESS = new System.Windows.Forms.Button();
            this.BACKUP = new System.Windows.Forms.Button();
            this.PROGRESS = new System.Windows.Forms.ProgressBar();
            this.LABEL_STATUS = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockMapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.resizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.zipWorker = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PROCESS, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.BACKUP, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.PROGRESS, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.LABEL_STATUS, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.37594F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.62406F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 364);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.DEST_VSEP_TEXT);
            this.groupBox4.Controls.Add(this.DEST_HSEP_TEXT);
            this.groupBox4.Controls.Add(this.DEST_VOFF_TEXT);
            this.groupBox4.Controls.Add(this.DEST_HOFF_TEXT);
            this.groupBox4.Location = new System.Drawing.Point(176, 172);
            this.groupBox4.Name = "groupBox4";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox4, 2);
            this.groupBox4.Size = new System.Drawing.Size(163, 127);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Destination Tile Options";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Vertical Separation";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Horizontal Separation";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Vertical Offset";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Horizontal Offset";
            // 
            // DEST_VSEP_TEXT
            // 
            this.DEST_VSEP_TEXT.Location = new System.Drawing.Point(134, 98);
            this.DEST_VSEP_TEXT.Name = "DEST_VSEP_TEXT";
            this.DEST_VSEP_TEXT.Size = new System.Drawing.Size(19, 20);
            this.DEST_VSEP_TEXT.TabIndex = 3;
            // 
            // DEST_HSEP_TEXT
            // 
            this.DEST_HSEP_TEXT.Location = new System.Drawing.Point(134, 72);
            this.DEST_HSEP_TEXT.Name = "DEST_HSEP_TEXT";
            this.DEST_HSEP_TEXT.Size = new System.Drawing.Size(19, 20);
            this.DEST_HSEP_TEXT.TabIndex = 2;
            // 
            // DEST_VOFF_TEXT
            // 
            this.DEST_VOFF_TEXT.Location = new System.Drawing.Point(134, 46);
            this.DEST_VOFF_TEXT.Name = "DEST_VOFF_TEXT";
            this.DEST_VOFF_TEXT.Size = new System.Drawing.Size(19, 20);
            this.DEST_VOFF_TEXT.TabIndex = 1;
            // 
            // DEST_HOFF_TEXT
            // 
            this.DEST_HOFF_TEXT.Location = new System.Drawing.Point(134, 20);
            this.DEST_HOFF_TEXT.Name = "DEST_HOFF_TEXT";
            this.DEST_HOFF_TEXT.Size = new System.Drawing.Size(19, 20);
            this.DEST_HOFF_TEXT.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 3);
            this.groupBox1.Controls.Add(this.SRC_ROOM);
            this.groupBox1.Controls.Add(this.SRC_BG);
            this.groupBox1.Controls.Add(this.SRC_ROOM_TEXT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SRC_BG_TEXT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source";
            // 
            // SRC_ROOM
            // 
            this.SRC_ROOM.Location = new System.Drawing.Point(406, 43);
            this.SRC_ROOM.Name = "SRC_ROOM";
            this.SRC_ROOM.Size = new System.Drawing.Size(33, 23);
            this.SRC_ROOM.TabIndex = 5;
            this.SRC_ROOM.Text = "...";
            this.SRC_ROOM.UseVisualStyleBackColor = true;
            this.SRC_ROOM.Click += new System.EventHandler(this.SRC_ROOM_Click);
            // 
            // SRC_BG
            // 
            this.SRC_BG.Location = new System.Drawing.Point(406, 17);
            this.SRC_BG.Name = "SRC_BG";
            this.SRC_BG.Size = new System.Drawing.Size(33, 23);
            this.SRC_BG.TabIndex = 4;
            this.SRC_BG.Text = "...";
            this.SRC_BG.UseVisualStyleBackColor = true;
            this.SRC_BG.Click += new System.EventHandler(this.SRC_BG_Click);
            // 
            // SRC_ROOM_TEXT
            // 
            this.SRC_ROOM_TEXT.Location = new System.Drawing.Point(143, 45);
            this.SRC_ROOM_TEXT.Name = "SRC_ROOM_TEXT";
            this.SRC_ROOM_TEXT.Size = new System.Drawing.Size(257, 20);
            this.SRC_ROOM_TEXT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Source Rooms";
            // 
            // SRC_BG_TEXT
            // 
            this.SRC_BG_TEXT.Location = new System.Drawing.Point(143, 19);
            this.SRC_BG_TEXT.Name = "SRC_BG_TEXT";
            this.SRC_BG_TEXT.Size = new System.Drawing.Size(257, 20);
            this.SRC_BG_TEXT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Backgrounds";
            // 
            // groupBox2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 3);
            this.groupBox2.Controls.Add(this.DEST_ROOM);
            this.groupBox2.Controls.Add(this.DEST_ROOM_TEXT);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.DEST_BG);
            this.groupBox2.Controls.Add(this.DEST_BG_TEXT);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(7, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 77);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination";
            // 
            // DEST_ROOM
            // 
            this.DEST_ROOM.Location = new System.Drawing.Point(406, 46);
            this.DEST_ROOM.Name = "DEST_ROOM";
            this.DEST_ROOM.Size = new System.Drawing.Size(33, 23);
            this.DEST_ROOM.TabIndex = 10;
            this.DEST_ROOM.Text = "...";
            this.DEST_ROOM.UseVisualStyleBackColor = true;
            this.DEST_ROOM.Click += new System.EventHandler(this.DEST_ROOM_Click);
            // 
            // DEST_ROOM_TEXT
            // 
            this.DEST_ROOM_TEXT.Location = new System.Drawing.Point(143, 48);
            this.DEST_ROOM_TEXT.Name = "DEST_ROOM_TEXT";
            this.DEST_ROOM_TEXT.Size = new System.Drawing.Size(257, 20);
            this.DEST_ROOM_TEXT.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Destination Rooms";
            // 
            // DEST_BG
            // 
            this.DEST_BG.Location = new System.Drawing.Point(406, 20);
            this.DEST_BG.Name = "DEST_BG";
            this.DEST_BG.Size = new System.Drawing.Size(33, 23);
            this.DEST_BG.TabIndex = 7;
            this.DEST_BG.Text = "...";
            this.DEST_BG.UseVisualStyleBackColor = true;
            this.DEST_BG.Click += new System.EventHandler(this.DEST_BG_Click);
            // 
            // DEST_BG_TEXT
            // 
            this.DEST_BG_TEXT.Location = new System.Drawing.Point(143, 22);
            this.DEST_BG_TEXT.Name = "DEST_BG_TEXT";
            this.DEST_BG_TEXT.Size = new System.Drawing.Size(257, 20);
            this.DEST_BG_TEXT.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Destination Backgrounds";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.SRC_VSEP_TEXT);
            this.groupBox3.Controls.Add(this.SRC_HSEP_TEXT);
            this.groupBox3.Controls.Add(this.SRC_VOFF_TEXT);
            this.groupBox3.Controls.Add(this.SRC_HOFF_TEXT);
            this.groupBox3.Location = new System.Drawing.Point(7, 172);
            this.groupBox3.Name = "groupBox3";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox3, 2);
            this.groupBox3.Size = new System.Drawing.Size(163, 127);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Source Tile Options";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Vertical Separation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Horizontal Separation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Vertical Offset";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Horizontal Offset";
            // 
            // SRC_VSEP_TEXT
            // 
            this.SRC_VSEP_TEXT.Location = new System.Drawing.Point(134, 98);
            this.SRC_VSEP_TEXT.Name = "SRC_VSEP_TEXT";
            this.SRC_VSEP_TEXT.Size = new System.Drawing.Size(19, 20);
            this.SRC_VSEP_TEXT.TabIndex = 3;
            // 
            // SRC_HSEP_TEXT
            // 
            this.SRC_HSEP_TEXT.Location = new System.Drawing.Point(134, 72);
            this.SRC_HSEP_TEXT.Name = "SRC_HSEP_TEXT";
            this.SRC_HSEP_TEXT.Size = new System.Drawing.Size(19, 20);
            this.SRC_HSEP_TEXT.TabIndex = 2;
            // 
            // SRC_VOFF_TEXT
            // 
            this.SRC_VOFF_TEXT.Location = new System.Drawing.Point(134, 46);
            this.SRC_VOFF_TEXT.Name = "SRC_VOFF_TEXT";
            this.SRC_VOFF_TEXT.Size = new System.Drawing.Size(19, 20);
            this.SRC_VOFF_TEXT.TabIndex = 1;
            // 
            // SRC_HOFF_TEXT
            // 
            this.SRC_HOFF_TEXT.Location = new System.Drawing.Point(134, 20);
            this.SRC_HOFF_TEXT.Name = "SRC_HOFF_TEXT";
            this.SRC_HOFF_TEXT.Size = new System.Drawing.Size(19, 20);
            this.SRC_HOFF_TEXT.TabIndex = 0;
            // 
            // PROCESS
            // 
            this.PROCESS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PROCESS.Location = new System.Drawing.Point(347, 244);
            this.PROCESS.Name = "PROCESS";
            this.PROCESS.Size = new System.Drawing.Size(107, 52);
            this.PROCESS.TabIndex = 17;
            this.PROCESS.Text = "Process";
            this.PROCESS.UseVisualStyleBackColor = true;
            this.PROCESS.Click += new System.EventHandler(this.PROCESS_Click);
            // 
            // BACKUP
            // 
            this.BACKUP.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BACKUP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BACKUP.Location = new System.Drawing.Point(347, 176);
            this.BACKUP.Name = "BACKUP";
            this.BACKUP.Size = new System.Drawing.Size(107, 53);
            this.BACKUP.TabIndex = 16;
            this.BACKUP.Text = "Back Up Files";
            this.BACKUP.UseVisualStyleBackColor = true;
            this.BACKUP.Click += new System.EventHandler(this.BACKUP_Click);
            // 
            // PROGRESS
            // 
            this.PROGRESS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.SetColumnSpan(this.PROGRESS, 3);
            this.PROGRESS.Location = new System.Drawing.Point(7, 334);
            this.PROGRESS.Name = "PROGRESS";
            this.PROGRESS.Size = new System.Drawing.Size(445, 23);
            this.PROGRESS.TabIndex = 18;
            // 
            // LABEL_STATUS
            // 
            this.LABEL_STATUS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LABEL_STATUS.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.LABEL_STATUS, 3);
            this.LABEL_STATUS.Location = new System.Drawing.Point(7, 310);
            this.LABEL_STATUS.Name = "LABEL_STATUS";
            this.LABEL_STATUS.Size = new System.Drawing.Size(0, 13);
            this.LABEL_STATUS.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(464, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lockMapsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.resizeToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // lockMapsToolStripMenuItem
            // 
            this.lockMapsToolStripMenuItem.CheckOnClick = true;
            this.lockMapsToolStripMenuItem.Name = "lockMapsToolStripMenuItem";
            this.lockMapsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.lockMapsToolStripMenuItem.Text = "&Lock Maps";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 6);
            // 
            // resizeToolStripMenuItem
            // 
            this.resizeToolStripMenuItem.Name = "resizeToolStripMenuItem";
            this.resizeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.resizeToolStripMenuItem.Text = "&Resize Rooms...";
            this.resizeToolStripMenuItem.Click += new System.EventHandler(this.resizeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.manualToolStripMenuItem.Text = "&Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // zipWorker
            // 
            this.zipWorker.WorkerReportsProgress = true;
            this.zipWorker.WorkerSupportsCancellation = true;
            this.zipWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.zipWorker_DoWork);
            this.zipWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.zipWorker_ProgressChanged);
            this.zipWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.zipWorker_RunWorkerCompleted);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 391);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_main";
            this.Text = "Offset Champion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lockMapsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SRC_ROOM;
        private System.Windows.Forms.Button SRC_BG;
        private System.Windows.Forms.TextBox SRC_ROOM_TEXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SRC_BG_TEXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DEST_ROOM;
        private System.Windows.Forms.TextBox DEST_ROOM_TEXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DEST_BG;
        private System.Windows.Forms.TextBox DEST_BG_TEXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox DEST_VSEP_TEXT;
        private System.Windows.Forms.TextBox DEST_HSEP_TEXT;
        private System.Windows.Forms.TextBox DEST_VOFF_TEXT;
        private System.Windows.Forms.TextBox DEST_HOFF_TEXT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SRC_VSEP_TEXT;
        private System.Windows.Forms.TextBox SRC_HSEP_TEXT;
        private System.Windows.Forms.TextBox SRC_VOFF_TEXT;
        private System.Windows.Forms.TextBox SRC_HOFF_TEXT;
        private System.Windows.Forms.Button BACKUP;
        private System.Windows.Forms.Button PROCESS;
        private System.Windows.Forms.ProgressBar PROGRESS;
        private System.Windows.Forms.Label LABEL_STATUS;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.ComponentModel.BackgroundWorker zipWorker;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem resizeToolStripMenuItem;
    }
}

