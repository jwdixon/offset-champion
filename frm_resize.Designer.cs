namespace WindowsFormsApplication1
{
    partial class frm_resize
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SHIFT_Y = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SHIFT_X = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RESIZE_CANCEL = new System.Windows.Forms.Button();
            this.RESIZE_ACCEPT = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MIN_WIDTH = new System.Windows.Forms.TextBox();
            this.MIN_HEIGHT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CHECK_SHIFT = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CHECK_SHIFT);
            this.groupBox1.Controls.Add(this.SHIFT_Y);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SHIFT_X);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 74);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shift Room Contents";
            // 
            // SHIFT_Y
            // 
            this.SHIFT_Y.Location = new System.Drawing.Point(247, 23);
            this.SHIFT_Y.Name = "SHIFT_Y";
            this.SHIFT_Y.Size = new System.Drawing.Size(52, 20);
            this.SHIFT_Y.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vertical";
            // 
            // SHIFT_X
            // 
            this.SHIFT_X.Location = new System.Drawing.Point(101, 23);
            this.SHIFT_X.Name = "SHIFT_X";
            this.SHIFT_X.Size = new System.Drawing.Size(52, 20);
            this.SHIFT_X.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Horizontal";
            // 
            // RESIZE_CANCEL
            // 
            this.RESIZE_CANCEL.Location = new System.Drawing.Point(260, 154);
            this.RESIZE_CANCEL.Name = "RESIZE_CANCEL";
            this.RESIZE_CANCEL.Size = new System.Drawing.Size(75, 23);
            this.RESIZE_CANCEL.TabIndex = 6;
            this.RESIZE_CANCEL.Text = "Cancel";
            this.RESIZE_CANCEL.UseVisualStyleBackColor = true;
            this.RESIZE_CANCEL.Click += new System.EventHandler(this.RESIZE_CANCEL_Click);
            // 
            // RESIZE_ACCEPT
            // 
            this.RESIZE_ACCEPT.Location = new System.Drawing.Point(179, 154);
            this.RESIZE_ACCEPT.Name = "RESIZE_ACCEPT";
            this.RESIZE_ACCEPT.Size = new System.Drawing.Size(75, 23);
            this.RESIZE_ACCEPT.TabIndex = 5;
            this.RESIZE_ACCEPT.Text = "OK";
            this.RESIZE_ACCEPT.UseVisualStyleBackColor = true;
            this.RESIZE_ACCEPT.Click += new System.EventHandler(this.RESIZE_ACCEPT_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.MIN_HEIGHT);
            this.groupBox3.Controls.Add(this.MIN_WIDTH);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(13, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 55);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Room Dimensions";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Minimum Width";
            // 
            // MIN_WIDTH
            // 
            this.MIN_WIDTH.Location = new System.Drawing.Point(101, 22);
            this.MIN_WIDTH.Name = "MIN_WIDTH";
            this.MIN_WIDTH.Size = new System.Drawing.Size(52, 20);
            this.MIN_WIDTH.TabIndex = 1;
            this.MIN_WIDTH.TextChanged += new System.EventHandler(this.MIN_WIDTH_TextChanged);
            // 
            // MIN_HEIGHT
            // 
            this.MIN_HEIGHT.Location = new System.Drawing.Point(247, 22);
            this.MIN_HEIGHT.Name = "MIN_HEIGHT";
            this.MIN_HEIGHT.Size = new System.Drawing.Size(52, 20);
            this.MIN_HEIGHT.TabIndex = 2;
            this.MIN_HEIGHT.TextChanged += new System.EventHandler(this.MIN_HEIGHT_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Minimum Height";
            // 
            // CHECK_SHIFT
            // 
            this.CHECK_SHIFT.AutoSize = true;
            this.CHECK_SHIFT.Location = new System.Drawing.Point(19, 49);
            this.CHECK_SHIFT.Name = "CHECK_SHIFT";
            this.CHECK_SHIFT.Size = new System.Drawing.Size(263, 17);
            this.CHECK_SHIFT.TabIndex = 7;
            this.CHECK_SHIFT.Text = "Only shift instances and tiles if room needs resizing";
            this.CHECK_SHIFT.UseVisualStyleBackColor = true;
            // 
            // frm_resize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 189);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.RESIZE_ACCEPT);
            this.Controls.Add(this.RESIZE_CANCEL);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_resize";
            this.Text = "Resize Room Dimensions";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SHIFT_Y;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SHIFT_X;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RESIZE_CANCEL;
        private System.Windows.Forms.Button RESIZE_ACCEPT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MIN_HEIGHT;
        private System.Windows.Forms.TextBox MIN_WIDTH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CHECK_SHIFT;

    }
}