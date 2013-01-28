namespace BatchBrake
{
    partial class SettingsForm
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
            this.applyBtn = new System.Windows.Forms.Button();
            this.vidFormatGrp = new System.Windows.Forms.GroupBox();
            this.divxChk = new System.Windows.Forms.CheckBox();
            this.mkvChk = new System.Windows.Forms.CheckBox();
            this.mpegChk = new System.Windows.Forms.CheckBox();
            this.mpgChk = new System.Windows.Forms.CheckBox();
            this.wmvChk = new System.Windows.Forms.CheckBox();
            this.m4vChk = new System.Windows.Forms.CheckBox();
            this.mp4Chk = new System.Windows.Forms.CheckBox();
            this.movChk = new System.Windows.Forms.CheckBox();
            this.aviChk = new System.Windows.Forms.CheckBox();
            this.flvChk = new System.Windows.Forms.CheckBox();
            this.convertToGrp = new System.Windows.Forms.GroupBox();
            this.convertMp4Radio = new System.Windows.Forms.RadioButton();
            this.convertMkvRadio = new System.Windows.Forms.RadioButton();
            this.cliExecBtn = new System.Windows.Forms.Button();
            this.cliExecTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.optionsGrp = new System.Windows.Forms.GroupBox();
            this.deleteChk = new System.Windows.Forms.CheckBox();
            this.verboseChk = new System.Windows.Forms.CheckBox();
            this.compareChk = new System.Windows.Forms.CheckBox();
            this.showChk = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.argumentsTxt = new System.Windows.Forms.Label();
            this.cliExecBrwsr = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.vidFormatGrp.SuspendLayout();
            this.convertToGrp.SuspendLayout();
            this.optionsGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(231, 260);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 0;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // vidFormatGrp
            // 
            this.vidFormatGrp.Controls.Add(this.divxChk);
            this.vidFormatGrp.Controls.Add(this.mkvChk);
            this.vidFormatGrp.Controls.Add(this.mpegChk);
            this.vidFormatGrp.Controls.Add(this.mpgChk);
            this.vidFormatGrp.Controls.Add(this.wmvChk);
            this.vidFormatGrp.Controls.Add(this.m4vChk);
            this.vidFormatGrp.Controls.Add(this.mp4Chk);
            this.vidFormatGrp.Controls.Add(this.movChk);
            this.vidFormatGrp.Controls.Add(this.aviChk);
            this.vidFormatGrp.Controls.Add(this.flvChk);
            this.vidFormatGrp.Location = new System.Drawing.Point(313, 12);
            this.vidFormatGrp.Name = "vidFormatGrp";
            this.vidFormatGrp.Size = new System.Drawing.Size(157, 152);
            this.vidFormatGrp.TabIndex = 6;
            this.vidFormatGrp.TabStop = false;
            this.vidFormatGrp.Text = "Select Formats To Convert";
            // 
            // divxChk
            // 
            this.divxChk.AutoSize = true;
            this.divxChk.Checked = true;
            this.divxChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.divxChk.Location = new System.Drawing.Point(73, 114);
            this.divxChk.Name = "divxChk";
            this.divxChk.Size = new System.Drawing.Size(45, 17);
            this.divxChk.TabIndex = 11;
            this.divxChk.Text = "divx";
            this.divxChk.UseVisualStyleBackColor = true;
            // 
            // mkvChk
            // 
            this.mkvChk.AutoSize = true;
            this.mkvChk.Enabled = false;
            this.mkvChk.Location = new System.Drawing.Point(17, 114);
            this.mkvChk.Name = "mkvChk";
            this.mkvChk.Size = new System.Drawing.Size(46, 17);
            this.mkvChk.TabIndex = 10;
            this.mkvChk.Text = "mkv";
            this.mkvChk.UseVisualStyleBackColor = true;
            // 
            // mpegChk
            // 
            this.mpegChk.AutoSize = true;
            this.mpegChk.Checked = true;
            this.mpegChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mpegChk.Location = new System.Drawing.Point(73, 91);
            this.mpegChk.Name = "mpegChk";
            this.mpegChk.Size = new System.Drawing.Size(54, 17);
            this.mpegChk.TabIndex = 9;
            this.mpegChk.Text = "webm";
            this.mpegChk.UseVisualStyleBackColor = true;
            // 
            // mpgChk
            // 
            this.mpgChk.AutoSize = true;
            this.mpgChk.Checked = true;
            this.mpgChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mpgChk.Location = new System.Drawing.Point(17, 91);
            this.mpgChk.Name = "mpgChk";
            this.mpgChk.Size = new System.Drawing.Size(46, 17);
            this.mpgChk.TabIndex = 8;
            this.mpgChk.Text = "mpg";
            this.mpgChk.UseVisualStyleBackColor = true;
            // 
            // wmvChk
            // 
            this.wmvChk.AutoSize = true;
            this.wmvChk.Checked = true;
            this.wmvChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wmvChk.Location = new System.Drawing.Point(73, 67);
            this.wmvChk.Name = "wmvChk";
            this.wmvChk.Size = new System.Drawing.Size(48, 17);
            this.wmvChk.TabIndex = 7;
            this.wmvChk.Text = "wmv";
            this.wmvChk.UseVisualStyleBackColor = true;
            // 
            // m4vChk
            // 
            this.m4vChk.AutoSize = true;
            this.m4vChk.Checked = true;
            this.m4vChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m4vChk.Location = new System.Drawing.Point(73, 43);
            this.m4vChk.Name = "m4vChk";
            this.m4vChk.Size = new System.Drawing.Size(46, 17);
            this.m4vChk.TabIndex = 6;
            this.m4vChk.Text = "m4v";
            this.m4vChk.UseVisualStyleBackColor = true;
            // 
            // mp4Chk
            // 
            this.mp4Chk.AutoSize = true;
            this.mp4Chk.Checked = true;
            this.mp4Chk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mp4Chk.Location = new System.Drawing.Point(73, 20);
            this.mp4Chk.Name = "mp4Chk";
            this.mp4Chk.Size = new System.Drawing.Size(46, 17);
            this.mp4Chk.TabIndex = 5;
            this.mp4Chk.Text = "mp4";
            this.mp4Chk.UseVisualStyleBackColor = true;
            // 
            // movChk
            // 
            this.movChk.AutoSize = true;
            this.movChk.Checked = true;
            this.movChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.movChk.Location = new System.Drawing.Point(17, 19);
            this.movChk.Name = "movChk";
            this.movChk.Size = new System.Drawing.Size(46, 17);
            this.movChk.TabIndex = 2;
            this.movChk.Text = "mov";
            this.movChk.UseVisualStyleBackColor = true;
            // 
            // aviChk
            // 
            this.aviChk.AutoSize = true;
            this.aviChk.Checked = true;
            this.aviChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aviChk.Location = new System.Drawing.Point(17, 67);
            this.aviChk.Name = "aviChk";
            this.aviChk.Size = new System.Drawing.Size(40, 17);
            this.aviChk.TabIndex = 4;
            this.aviChk.Text = "avi";
            this.aviChk.UseVisualStyleBackColor = true;
            // 
            // flvChk
            // 
            this.flvChk.AutoSize = true;
            this.flvChk.Checked = true;
            this.flvChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.flvChk.Location = new System.Drawing.Point(17, 43);
            this.flvChk.Name = "flvChk";
            this.flvChk.Size = new System.Drawing.Size(37, 17);
            this.flvChk.TabIndex = 3;
            this.flvChk.Text = "flv";
            this.flvChk.UseVisualStyleBackColor = true;
            // 
            // convertToGrp
            // 
            this.convertToGrp.Controls.Add(this.convertMp4Radio);
            this.convertToGrp.Controls.Add(this.convertMkvRadio);
            this.convertToGrp.Location = new System.Drawing.Point(218, 79);
            this.convertToGrp.Name = "convertToGrp";
            this.convertToGrp.Size = new System.Drawing.Size(88, 67);
            this.convertToGrp.TabIndex = 20;
            this.convertToGrp.TabStop = false;
            this.convertToGrp.Text = "Convert To";
            // 
            // convertMp4Radio
            // 
            this.convertMp4Radio.AutoSize = true;
            this.convertMp4Radio.Location = new System.Drawing.Point(7, 44);
            this.convertMp4Radio.Name = "convertMp4Radio";
            this.convertMp4Radio.Size = new System.Drawing.Size(45, 17);
            this.convertMp4Radio.TabIndex = 1;
            this.convertMp4Radio.Text = "mp4";
            this.convertMp4Radio.UseVisualStyleBackColor = true;
            this.convertMp4Radio.CheckedChanged += new System.EventHandler(this.convertMp4Radio_CheckedChanged);
            // 
            // convertMkvRadio
            // 
            this.convertMkvRadio.AutoSize = true;
            this.convertMkvRadio.Checked = true;
            this.convertMkvRadio.Location = new System.Drawing.Point(7, 20);
            this.convertMkvRadio.Name = "convertMkvRadio";
            this.convertMkvRadio.Size = new System.Drawing.Size(45, 17);
            this.convertMkvRadio.TabIndex = 0;
            this.convertMkvRadio.TabStop = true;
            this.convertMkvRadio.Text = "mkv";
            this.convertMkvRadio.UseVisualStyleBackColor = true;
            this.convertMkvRadio.CheckedChanged += new System.EventHandler(this.convertMkvRadio_CheckedChanged);
            // 
            // cliExecBtn
            // 
            this.cliExecBtn.Location = new System.Drawing.Point(195, 35);
            this.cliExecBtn.Name = "cliExecBtn";
            this.cliExecBtn.Size = new System.Drawing.Size(75, 23);
            this.cliExecBtn.TabIndex = 19;
            this.cliExecBtn.Text = "Browse";
            this.cliExecBtn.UseVisualStyleBackColor = true;
            this.cliExecBtn.Click += new System.EventHandler(this.cliExecBtn_Click);
            // 
            // cliExecTxt
            // 
            this.cliExecTxt.Location = new System.Drawing.Point(12, 37);
            this.cliExecTxt.Name = "cliExecTxt";
            this.cliExecTxt.Size = new System.Drawing.Size(177, 20);
            this.cliExecTxt.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select HandbrakeCLI.exe";
            // 
            // optionsGrp
            // 
            this.optionsGrp.Controls.Add(this.showChk);
            this.optionsGrp.Controls.Add(this.compareChk);
            this.optionsGrp.Controls.Add(this.verboseChk);
            this.optionsGrp.Controls.Add(this.deleteChk);
            this.optionsGrp.Location = new System.Drawing.Point(12, 79);
            this.optionsGrp.Name = "optionsGrp";
            this.optionsGrp.Size = new System.Drawing.Size(200, 120);
            this.optionsGrp.TabIndex = 21;
            this.optionsGrp.TabStop = false;
            this.optionsGrp.Text = "Options";
            // 
            // deleteChk
            // 
            this.deleteChk.AutoSize = true;
            this.deleteChk.Location = new System.Drawing.Point(7, 20);
            this.deleteChk.Name = "deleteChk";
            this.deleteChk.Size = new System.Drawing.Size(138, 17);
            this.deleteChk.TabIndex = 0;
            this.deleteChk.Text = "Delete After Conversion";
            this.deleteChk.UseVisualStyleBackColor = true;
            // 
            // verboseChk
            // 
            this.verboseChk.AutoSize = true;
            this.verboseChk.Location = new System.Drawing.Point(7, 44);
            this.verboseChk.Name = "verboseChk";
            this.verboseChk.Size = new System.Drawing.Size(95, 17);
            this.verboseChk.TabIndex = 1;
            this.verboseChk.Text = "Verbose Mode";
            this.verboseChk.UseVisualStyleBackColor = true;
            // 
            // compareChk
            // 
            this.compareChk.AutoSize = true;
            this.compareChk.Location = new System.Drawing.Point(7, 68);
            this.compareChk.Name = "compareChk";
            this.compareChk.Size = new System.Drawing.Size(139, 17);
            this.compareChk.TabIndex = 2;
            this.compareChk.Text = "Compare Video Lengths";
            this.compareChk.UseVisualStyleBackColor = true;
            // 
            // showChk
            // 
            this.showChk.AutoSize = true;
            this.showChk.Location = new System.Drawing.Point(7, 92);
            this.showChk.Name = "showChk";
            this.showChk.Size = new System.Drawing.Size(114, 17);
            this.showChk.TabIndex = 3;
            this.showChk.Text = "Show CLI Window";
            this.showChk.UseVisualStyleBackColor = true;
            this.showChk.CheckedChanged += new System.EventHandler(this.showChk_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 231);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 52);
            this.textBox1.TabIndex = 22;
            // 
            // argumentsTxt
            // 
            this.argumentsTxt.AutoSize = true;
            this.argumentsTxt.Location = new System.Drawing.Point(19, 212);
            this.argumentsTxt.Name = "argumentsTxt";
            this.argumentsTxt.Size = new System.Drawing.Size(106, 13);
            this.argumentsTxt.TabIndex = 23;
            this.argumentsTxt.Text = "Additional Arguments";
            // 
            // cliExecBrwsr
            // 
            this.cliExecBrwsr.FileName = "HandBrakeCLI.exe";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 308);
            this.Controls.Add(this.argumentsTxt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.optionsGrp);
            this.Controls.Add(this.convertToGrp);
            this.Controls.Add(this.cliExecBtn);
            this.Controls.Add(this.cliExecTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vidFormatGrp);
            this.Controls.Add(this.applyBtn);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.vidFormatGrp.ResumeLayout(false);
            this.vidFormatGrp.PerformLayout();
            this.convertToGrp.ResumeLayout(false);
            this.convertToGrp.PerformLayout();
            this.optionsGrp.ResumeLayout(false);
            this.optionsGrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.GroupBox vidFormatGrp;
        private System.Windows.Forms.CheckBox divxChk;
        private System.Windows.Forms.CheckBox mkvChk;
        private System.Windows.Forms.CheckBox mpegChk;
        private System.Windows.Forms.CheckBox mpgChk;
        private System.Windows.Forms.CheckBox wmvChk;
        private System.Windows.Forms.CheckBox m4vChk;
        private System.Windows.Forms.CheckBox mp4Chk;
        private System.Windows.Forms.CheckBox movChk;
        private System.Windows.Forms.CheckBox aviChk;
        private System.Windows.Forms.CheckBox flvChk;
        private System.Windows.Forms.GroupBox convertToGrp;
        private System.Windows.Forms.RadioButton convertMp4Radio;
        private System.Windows.Forms.RadioButton convertMkvRadio;
        private System.Windows.Forms.Button cliExecBtn;
        private System.Windows.Forms.TextBox cliExecTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox optionsGrp;
        private System.Windows.Forms.CheckBox verboseChk;
        private System.Windows.Forms.CheckBox deleteChk;
        private System.Windows.Forms.CheckBox compareChk;
        private System.Windows.Forms.CheckBox showChk;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label argumentsTxt;
        private System.Windows.Forms.OpenFileDialog cliExecBrwsr;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDlg;
    }
}