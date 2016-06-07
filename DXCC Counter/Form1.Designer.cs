namespace DXCC_Counter
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Btn_LoadAdif = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.L_dxcc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.L_zones = new System.Windows.Forms.Label();
            this.LST_DXCC = new System.Windows.Forms.ListBox();
            this.LST_Zones = new System.Windows.Forms.ListBox();
            this.LST_Cont = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.L_cont = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LST_Prefix = new System.Windows.Forms.ListBox();
            this.L_prefix = new System.Windows.Forms.Label();
            this.L_qso = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.L_filename = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.L_Bands = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LST_Bands = new System.Windows.Forms.ListBox();
            this.L_Mode = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LST_Mode = new System.Windows.Forms.ListBox();
            this.UploadBtn = new System.Windows.Forms.Button();
            this.TB_4XFFRef = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBX_WWFF = new System.Windows.Forms.CheckBox();
            this.CBX_4X4Trail = new System.Windows.Forms.CheckBox();
            this.TB_4X4TrailSection = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Btn_LoadAdif
            // 
            this.Btn_LoadAdif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Btn_LoadAdif.Location = new System.Drawing.Point(563, 598);
            this.Btn_LoadAdif.Name = "Btn_LoadAdif";
            this.Btn_LoadAdif.Size = new System.Drawing.Size(153, 33);
            this.Btn_LoadAdif.TabIndex = 0;
            this.Btn_LoadAdif.Text = "Load ADIF";
            this.Btn_LoadAdif.UseVisualStyleBackColor = true;
            this.Btn_LoadAdif.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DXCC:";
            // 
            // L_dxcc
            // 
            this.L_dxcc.AutoSize = true;
            this.L_dxcc.Location = new System.Drawing.Point(57, 25);
            this.L_dxcc.Name = "L_dxcc";
            this.L_dxcc.Size = new System.Drawing.Size(0, 13);
            this.L_dxcc.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ZONES:";
            // 
            // L_zones
            // 
            this.L_zones.AutoSize = true;
            this.L_zones.Location = new System.Drawing.Point(272, 25);
            this.L_zones.Name = "L_zones";
            this.L_zones.Size = new System.Drawing.Size(0, 13);
            this.L_zones.TabIndex = 4;
            // 
            // LST_DXCC
            // 
            this.LST_DXCC.ColumnWidth = 50;
            this.LST_DXCC.FormattingEnabled = true;
            this.LST_DXCC.Location = new System.Drawing.Point(15, 42);
            this.LST_DXCC.Name = "LST_DXCC";
            this.LST_DXCC.Size = new System.Drawing.Size(194, 589);
            this.LST_DXCC.TabIndex = 5;
            // 
            // LST_Zones
            // 
            this.LST_Zones.ColumnWidth = 60;
            this.LST_Zones.FormattingEnabled = true;
            this.LST_Zones.Location = new System.Drawing.Point(225, 42);
            this.LST_Zones.MultiColumn = true;
            this.LST_Zones.Name = "LST_Zones";
            this.LST_Zones.Size = new System.Drawing.Size(181, 160);
            this.LST_Zones.TabIndex = 6;
            // 
            // LST_Cont
            // 
            this.LST_Cont.FormattingEnabled = true;
            this.LST_Cont.Location = new System.Drawing.Point(563, 237);
            this.LST_Cont.Name = "LST_Cont";
            this.LST_Cont.Size = new System.Drawing.Size(153, 121);
            this.LST_Cont.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "CONTINENTS:";
            // 
            // L_cont
            // 
            this.L_cont.AutoSize = true;
            this.L_cont.Location = new System.Drawing.Point(642, 221);
            this.L_cont.Name = "L_cont";
            this.L_cont.Size = new System.Drawing.Size(0, 13);
            this.L_cont.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "PREFIX:";
            // 
            // LST_Prefix
            // 
            this.LST_Prefix.ColumnWidth = 40;
            this.LST_Prefix.FormattingEnabled = true;
            this.LST_Prefix.Location = new System.Drawing.Point(225, 237);
            this.LST_Prefix.MultiColumn = true;
            this.LST_Prefix.Name = "LST_Prefix";
            this.LST_Prefix.Size = new System.Drawing.Size(322, 394);
            this.LST_Prefix.TabIndex = 10;
            // 
            // L_prefix
            // 
            this.L_prefix.AutoSize = true;
            this.L_prefix.Location = new System.Drawing.Point(274, 221);
            this.L_prefix.Name = "L_prefix";
            this.L_prefix.Size = new System.Drawing.Size(0, 13);
            this.L_prefix.TabIndex = 12;
            // 
            // L_qso
            // 
            this.L_qso.AutoSize = true;
            this.L_qso.Location = new System.Drawing.Point(137, 9);
            this.L_qso.Name = "L_qso";
            this.L_qso.Size = new System.Drawing.Size(0, 13);
            this.L_qso.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total Number of QSO\'s:";
            // 
            // L_filename
            // 
            this.L_filename.AutoSize = true;
            this.L_filename.Location = new System.Drawing.Point(96, 642);
            this.L_filename.Name = "L_filename";
            this.L_filename.Size = new System.Drawing.Size(0, 13);
            this.L_filename.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 642);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Log File Name:";
            // 
            // L_Bands
            // 
            this.L_Bands.AutoSize = true;
            this.L_Bands.Location = new System.Drawing.Point(472, 25);
            this.L_Bands.Name = "L_Bands";
            this.L_Bands.Size = new System.Drawing.Size(0, 13);
            this.L_Bands.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(420, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "BANDS:";
            // 
            // LST_Bands
            // 
            this.LST_Bands.FormattingEnabled = true;
            this.LST_Bands.Location = new System.Drawing.Point(423, 42);
            this.LST_Bands.Name = "LST_Bands";
            this.LST_Bands.Size = new System.Drawing.Size(124, 160);
            this.LST_Bands.TabIndex = 17;
            // 
            // L_Mode
            // 
            this.L_Mode.AutoSize = true;
            this.L_Mode.Location = new System.Drawing.Point(612, 25);
            this.L_Mode.Name = "L_Mode";
            this.L_Mode.Size = new System.Drawing.Size(0, 13);
            this.L_Mode.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(560, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "MODE:";
            // 
            // LST_Mode
            // 
            this.LST_Mode.FormattingEnabled = true;
            this.LST_Mode.Location = new System.Drawing.Point(563, 42);
            this.LST_Mode.Name = "LST_Mode";
            this.LST_Mode.Size = new System.Drawing.Size(153, 160);
            this.LST_Mode.TabIndex = 20;
            // 
            // UploadBtn
            // 
            this.UploadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadBtn.Location = new System.Drawing.Point(7, 128);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(139, 33);
            this.UploadBtn.TabIndex = 24;
            this.UploadBtn.Text = "Upload Log";
            this.UploadBtn.UseVisualStyleBackColor = true;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // TB_4XFFRef
            // 
            this.TB_4XFFRef.Location = new System.Drawing.Point(6, 38);
            this.TB_4XFFRef.Name = "TB_4XFFRef";
            this.TB_4XFFRef.Size = new System.Drawing.Size(140, 20);
            this.TB_4XFFRef.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBX_4X4Trail);
            this.groupBox1.Controls.Add(this.UploadBtn);
            this.groupBox1.Controls.Add(this.TB_4X4TrailSection);
            this.groupBox1.Controls.Add(this.CBX_WWFF);
            this.groupBox1.Controls.Add(this.TB_4XFFRef);
            this.groupBox1.Location = new System.Drawing.Point(563, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 177);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // CBX_WWFF
            // 
            this.CBX_WWFF.AutoSize = true;
            this.CBX_WWFF.Location = new System.Drawing.Point(7, 15);
            this.CBX_WWFF.Name = "CBX_WWFF";
            this.CBX_WWFF.Size = new System.Drawing.Size(113, 17);
            this.CBX_WWFF.TabIndex = 0;
            this.CBX_WWFF.Text = "WWFF Reference";
            this.CBX_WWFF.UseVisualStyleBackColor = true;
            this.CBX_WWFF.CheckedChanged += new System.EventHandler(this.CBX_WWFF_CheckedChanged);
            // 
            // CBX_4X4Trail
            // 
            this.CBX_4X4Trail.AutoSize = true;
            this.CBX_4X4Trail.Location = new System.Drawing.Point(7, 70);
            this.CBX_4X4Trail.Name = "CBX_4X4Trail";
            this.CBX_4X4Trail.Size = new System.Drawing.Size(104, 17);
            this.CBX_4X4Trail.TabIndex = 27;
            this.CBX_4X4Trail.Text = "4X4Trail Section";
            this.CBX_4X4Trail.UseVisualStyleBackColor = true;
            this.CBX_4X4Trail.CheckedChanged += new System.EventHandler(this.CBX_4X4Trail_CheckedChanged);
            // 
            // TB_4X4TrailSection
            // 
            this.TB_4X4TrailSection.Location = new System.Drawing.Point(6, 93);
            this.TB_4X4TrailSection.Name = "TB_4X4TrailSection";
            this.TB_4X4TrailSection.Size = new System.Drawing.Size(140, 20);
            this.TB_4X4TrailSection.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 687);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.L_Mode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LST_Mode);
            this.Controls.Add(this.L_Bands);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LST_Bands);
            this.Controls.Add(this.L_filename);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.L_qso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.L_prefix);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LST_Prefix);
            this.Controls.Add(this.L_cont);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LST_Cont);
            this.Controls.Add(this.LST_Zones);
            this.Controls.Add(this.LST_DXCC);
            this.Controls.Add(this.L_zones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.L_dxcc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_LoadAdif);
            this.MaximumSize = new System.Drawing.Size(748, 725);
            this.MinimumSize = new System.Drawing.Size(748, 725);
            this.Name = "Form1";
            this.Text = "DXCC Counter (by 4Z1KD)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Btn_LoadAdif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L_dxcc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label L_zones;
        private System.Windows.Forms.ListBox LST_DXCC;
        private System.Windows.Forms.ListBox LST_Zones;
        private System.Windows.Forms.ListBox LST_Cont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label L_cont;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LST_Prefix;
        private System.Windows.Forms.Label L_prefix;
        private System.Windows.Forms.Label L_qso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label L_filename;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label L_Bands;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox LST_Bands;
        private System.Windows.Forms.Label L_Mode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox LST_Mode;
        private System.Windows.Forms.Button UploadBtn;
        private System.Windows.Forms.TextBox TB_4XFFRef;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CBX_4X4Trail;
        private System.Windows.Forms.TextBox TB_4X4TrailSection;
        private System.Windows.Forms.CheckBox CBX_WWFF;
    }
}

