namespace Lenz_disc_burn
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBurn = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.statusProgressBar = new System.Windows.Forms.ProgressBar();
            this.labelStatusText = new System.Windows.Forms.Label();
            this.buttonBurn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelMediaType = new System.Windows.Forms.Label();
            this.buttonDetectMedia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalSize = new System.Windows.Forms.Label();
            this.progressBarCapacity = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxVerification = new System.Windows.Forms.ComboBox();
            this.labelVerification = new System.Windows.Forms.Label();
            this.checkBoxEject = new System.Windows.Forms.CheckBox();
            this.checkBoxCloseMedia = new System.Windows.Forms.CheckBox();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRemoveFiles = new System.Windows.Forms.Button();
            this.buttonAddFolders = new System.Windows.Forms.Button();
            this.buttonAddFiles = new System.Windows.Forms.Button();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.tabPageFormat = new System.Windows.Forms.TabPage();
            this.checkBoxQuickFormat = new System.Windows.Forms.CheckBox();
            this.checkBoxEjectFormat = new System.Windows.Forms.CheckBox();
            this.formatProgressBar = new System.Windows.Forms.ProgressBar();
            this.labelFormatStatusText = new System.Windows.Forms.Label();
            this.buttonFormat = new System.Windows.Forms.Button();
            this.supportedMediaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.devicesComboBox = new System.Windows.Forms.ComboBox();
            this.backgroundBurnWorker = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.backgroundFormatWorker = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPageBurn.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBurn);
            this.tabControl1.Controls.Add(this.tabPageFormat);
            this.tabControl1.Location = new System.Drawing.Point(12, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(660, 412);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPageBurn
            // 
            this.tabPageBurn.Controls.Add(this.groupBox3);
            this.tabPageBurn.Controls.Add(this.groupBox2);
            this.tabPageBurn.Controls.Add(this.groupBox1);
            this.tabPageBurn.Location = new System.Drawing.Point(4, 22);
            this.tabPageBurn.Name = "tabPageBurn";
            this.tabPageBurn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBurn.Size = new System.Drawing.Size(652, 386);
            this.tabPageBurn.TabIndex = 0;
            this.tabPageBurn.Text = "Burn your files from PC";
            this.tabPageBurn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.statusProgressBar);
            this.groupBox3.Controls.Add(this.labelStatusText);
            this.groupBox3.Controls.Add(this.buttonBurn);
            this.groupBox3.Location = new System.Drawing.Point(373, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 155);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Progress";
            // 
            // statusProgressBar
            // 
            this.statusProgressBar.Location = new System.Drawing.Point(12, 70);
            this.statusProgressBar.Name = "statusProgressBar";
            this.statusProgressBar.Size = new System.Drawing.Size(224, 16);
            this.statusProgressBar.TabIndex = 8;
            // 
            // labelStatusText
            // 
            this.labelStatusText.Location = new System.Drawing.Point(9, 18);
            this.labelStatusText.Name = "labelStatusText";
            this.labelStatusText.Size = new System.Drawing.Size(227, 45);
            this.labelStatusText.TabIndex = 7;
            this.labelStatusText.Text = "status";
            this.labelStatusText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // buttonBurn
            // 
            this.buttonBurn.Location = new System.Drawing.Point(84, 92);
            this.buttonBurn.Name = "buttonBurn";
            this.buttonBurn.Size = new System.Drawing.Size(88, 30);
            this.buttonBurn.TabIndex = 6;
            this.buttonBurn.Text = "&Burn Disc";
            this.buttonBurn.UseVisualStyleBackColor = true;
            this.buttonBurn.Click += new System.EventHandler(this.buttonBurn_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelMediaType);
            this.groupBox2.Controls.Add(this.buttonDetectMedia);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.labelTotalSize);
            this.groupBox2.Controls.Add(this.progressBarCapacity);
            this.groupBox2.Location = new System.Drawing.Point(373, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 132);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected media type:";
            // 
            // labelMediaType
            // 
            this.labelMediaType.Location = new System.Drawing.Point(117, 20);
            this.labelMediaType.Name = "labelMediaType";
            this.labelMediaType.Size = new System.Drawing.Size(119, 40);
            this.labelMediaType.TabIndex = 10;
            this.labelMediaType.Text = "Press \'Detect Media\' Button";
            // 
            // buttonDetectMedia
            // 
            this.buttonDetectMedia.Location = new System.Drawing.Point(12, 20);
            this.buttonDetectMedia.Name = "buttonDetectMedia";
            this.buttonDetectMedia.Size = new System.Drawing.Size(98, 28);
            this.buttonDetectMedia.TabIndex = 9;
            this.buttonDetectMedia.Text = "Detect Media";
            this.buttonDetectMedia.UseVisualStyleBackColor = true;
            this.buttonDetectMedia.Click += new System.EventHandler(this.buttonDetectMedia_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "0";
            // 
            // labelTotalSize
            // 
            this.labelTotalSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalSize.AutoSize = true;
            this.labelTotalSize.Location = new System.Drawing.Point(193, 73);
            this.labelTotalSize.Name = "labelTotalSize";
            this.labelTotalSize.Size = new System.Drawing.Size(47, 13);
            this.labelTotalSize.TabIndex = 7;
            this.labelTotalSize.Text = "totalSize";
            // 
            // progressBarCapacity
            // 
            this.progressBarCapacity.Location = new System.Drawing.Point(6, 92);
            this.progressBarCapacity.Name = "progressBarCapacity";
            this.progressBarCapacity.Size = new System.Drawing.Size(230, 12);
            this.progressBarCapacity.Step = 1;
            this.progressBarCapacity.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarCapacity.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxVerification);
            this.groupBox1.Controls.Add(this.labelVerification);
            this.groupBox1.Controls.Add(this.checkBoxEject);
            this.groupBox1.Controls.Add(this.checkBoxCloseMedia);
            this.groupBox1.Controls.Add(this.textBoxLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonRemoveFiles);
            this.groupBox1.Controls.Add(this.buttonAddFolders);
            this.groupBox1.Controls.Add(this.buttonAddFiles);
            this.groupBox1.Controls.Add(this.listBoxFiles);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 293);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files to burn";
            // 
            // comboBoxVerification
            // 
            this.comboBoxVerification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVerification.FormattingEnabled = true;
            this.comboBoxVerification.Items.AddRange(new object[] {
            "None",
            "Quick",
            "Full"});
            this.comboBoxVerification.Location = new System.Drawing.Point(79, 257);
            this.comboBoxVerification.Name = "comboBoxVerification";
            this.comboBoxVerification.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVerification.TabIndex = 9;
            this.comboBoxVerification.SelectedIndexChanged += new System.EventHandler(this.comboBoxVerification_SelectedIndexChanged_1);
            // 
            // labelVerification
            // 
            this.labelVerification.AutoSize = true;
            this.labelVerification.Location = new System.Drawing.Point(10, 260);
            this.labelVerification.Name = "labelVerification";
            this.labelVerification.Size = new System.Drawing.Size(62, 13);
            this.labelVerification.TabIndex = 8;
            this.labelVerification.Text = "Verification:";
            // 
            // checkBoxEject
            // 
            this.checkBoxEject.AutoSize = true;
            this.checkBoxEject.Checked = true;
            this.checkBoxEject.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEject.Location = new System.Drawing.Point(163, 221);
            this.checkBoxEject.Name = "checkBoxEject";
            this.checkBoxEject.Size = new System.Drawing.Size(118, 17);
            this.checkBoxEject.TabIndex = 7;
            this.checkBoxEject.Text = "Eject when finished";
            this.checkBoxEject.UseVisualStyleBackColor = true;
            // 
            // checkBoxCloseMedia
            // 
            this.checkBoxCloseMedia.AutoSize = true;
            this.checkBoxCloseMedia.Checked = true;
            this.checkBoxCloseMedia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCloseMedia.Location = new System.Drawing.Point(10, 221);
            this.checkBoxCloseMedia.Name = "checkBoxCloseMedia";
            this.checkBoxCloseMedia.Size = new System.Drawing.Size(83, 17);
            this.checkBoxCloseMedia.TabIndex = 6;
            this.checkBoxCloseMedia.Text = "Close media";
            this.checkBoxCloseMedia.UseVisualStyleBackColor = true;
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Location = new System.Drawing.Point(123, 191);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(128, 20);
            this.textBoxLabel.TabIndex = 5;
            this.textBoxLabel.TextChanged += new System.EventHandler(this.textBoxLabel_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Disc Date:";
            // 
            // buttonRemoveFiles
            // 
            this.buttonRemoveFiles.Location = new System.Drawing.Point(218, 157);
            this.buttonRemoveFiles.Name = "buttonRemoveFiles";
            this.buttonRemoveFiles.Size = new System.Drawing.Size(106, 27);
            this.buttonRemoveFiles.TabIndex = 3;
            this.buttonRemoveFiles.Text = "Remove File(s)...";
            this.buttonRemoveFiles.UseVisualStyleBackColor = true;
            this.buttonRemoveFiles.Click += new System.EventHandler(this.buttonRemoveFiles_Click_1);
            // 
            // buttonAddFolders
            // 
            this.buttonAddFolders.Location = new System.Drawing.Point(107, 157);
            this.buttonAddFolders.Name = "buttonAddFolders";
            this.buttonAddFolders.Size = new System.Drawing.Size(98, 27);
            this.buttonAddFolders.TabIndex = 2;
            this.buttonAddFolders.Text = "Add Folders...";
            this.buttonAddFolders.UseVisualStyleBackColor = true;
            this.buttonAddFolders.Click += new System.EventHandler(this.buttonAddFolders_Click_1);
            // 
            // buttonAddFiles
            // 
            this.buttonAddFiles.Location = new System.Drawing.Point(10, 157);
            this.buttonAddFiles.Name = "buttonAddFiles";
            this.buttonAddFiles.Size = new System.Drawing.Size(84, 27);
            this.buttonAddFiles.TabIndex = 1;
            this.buttonAddFiles.Text = "Add Files...";
            this.buttonAddFiles.UseVisualStyleBackColor = true;
            this.buttonAddFiles.Click += new System.EventHandler(this.buttonAddFiles_Click_1);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 24;
            this.listBoxFiles.Location = new System.Drawing.Point(10, 19);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(315, 124);
            this.listBoxFiles.TabIndex = 0;
            this.listBoxFiles.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxFiles_DrawItem);
            this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxFiles_SelectedIndexChanged_1);
            // 
            // tabPageFormat
            // 
            this.tabPageFormat.Controls.Add(this.checkBoxQuickFormat);
            this.tabPageFormat.Controls.Add(this.checkBoxEjectFormat);
            this.tabPageFormat.Controls.Add(this.formatProgressBar);
            this.tabPageFormat.Controls.Add(this.labelFormatStatusText);
            this.tabPageFormat.Controls.Add(this.buttonFormat);
            this.tabPageFormat.Location = new System.Drawing.Point(4, 22);
            this.tabPageFormat.Name = "tabPageFormat";
            this.tabPageFormat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFormat.Size = new System.Drawing.Size(652, 386);
            this.tabPageFormat.TabIndex = 1;
            this.tabPageFormat.Text = "Format CD/DVD";
            this.tabPageFormat.UseVisualStyleBackColor = true;
            // 
            // checkBoxQuickFormat
            // 
            this.checkBoxQuickFormat.AutoSize = true;
            this.checkBoxQuickFormat.Checked = true;
            this.checkBoxQuickFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxQuickFormat.Location = new System.Drawing.Point(217, 67);
            this.checkBoxQuickFormat.Name = "checkBoxQuickFormat";
            this.checkBoxQuickFormat.Size = new System.Drawing.Size(89, 17);
            this.checkBoxQuickFormat.TabIndex = 19;
            this.checkBoxQuickFormat.Text = "Quick Format";
            this.checkBoxQuickFormat.UseVisualStyleBackColor = true;
            // 
            // checkBoxEjectFormat
            // 
            this.checkBoxEjectFormat.AutoSize = true;
            this.checkBoxEjectFormat.Checked = true;
            this.checkBoxEjectFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEjectFormat.Location = new System.Drawing.Point(217, 43);
            this.checkBoxEjectFormat.Name = "checkBoxEjectFormat";
            this.checkBoxEjectFormat.Size = new System.Drawing.Size(118, 17);
            this.checkBoxEjectFormat.TabIndex = 17;
            this.checkBoxEjectFormat.Text = "Eject when finished";
            this.checkBoxEjectFormat.UseVisualStyleBackColor = true;
            // 
            // formatProgressBar
            // 
            this.formatProgressBar.Location = new System.Drawing.Point(117, 237);
            this.formatProgressBar.Name = "formatProgressBar";
            this.formatProgressBar.Size = new System.Drawing.Size(318, 16);
            this.formatProgressBar.TabIndex = 18;
            // 
            // labelFormatStatusText
            // 
            this.labelFormatStatusText.Location = new System.Drawing.Point(116, 175);
            this.labelFormatStatusText.Name = "labelFormatStatusText";
            this.labelFormatStatusText.Size = new System.Drawing.Size(321, 55);
            this.labelFormatStatusText.TabIndex = 16;
            this.labelFormatStatusText.Text = " disc status";
            this.labelFormatStatusText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // buttonFormat
            // 
            this.buttonFormat.Location = new System.Drawing.Point(235, 116);
            this.buttonFormat.Name = "buttonFormat";
            this.buttonFormat.Size = new System.Drawing.Size(83, 29);
            this.buttonFormat.TabIndex = 15;
            this.buttonFormat.Text = "&Format Disc";
            this.buttonFormat.UseVisualStyleBackColor = true;
            this.buttonFormat.Click += new System.EventHandler(this.buttonFormat_Click_1);
            // 
            // supportedMediaLabel
            // 
            this.supportedMediaLabel.Location = new System.Drawing.Point(410, 19);
            this.supportedMediaLabel.Name = "supportedMediaLabel";
            this.supportedMediaLabel.Size = new System.Drawing.Size(262, 57);
            this.supportedMediaLabel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // devicesComboBox
            // 
            this.devicesComboBox.FormattingEnabled = true;
            this.devicesComboBox.Location = new System.Drawing.Point(58, 22);
            this.devicesComboBox.Name = "devicesComboBox";
            this.devicesComboBox.Size = new System.Drawing.Size(196, 21);
            this.devicesComboBox.TabIndex = 4;
            this.devicesComboBox.SelectedIndexChanged += new System.EventHandler(this.devicesComboBox_SelectedIndexChanged);
            this.devicesComboBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.devicesComboBox_Format);
            // 
            // backgroundBurnWorker
            // 
            this.backgroundBurnWorker.WorkerReportsProgress = true;
            this.backgroundBurnWorker.WorkerSupportsCancellation = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "All Files (*.*)|*.*";
            // 
            // backgroundFormatWorker
            // 
            this.backgroundFormatWorker.WorkerReportsProgress = true;
            this.backgroundFormatWorker.WorkerSupportsCancellation = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(681, 523);
            this.Controls.Add(this.supportedMediaLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.devicesComboBox);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Lenz Disc Burner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageBurn.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageFormat.ResumeLayout(false);
            this.tabPageFormat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBurn;
        private System.Windows.Forms.TabPage tabPageFormat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxVerification;
        private System.Windows.Forms.Label labelVerification;
        private System.Windows.Forms.CheckBox checkBoxEject;
        private System.Windows.Forms.CheckBox checkBoxCloseMedia;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRemoveFiles;
        private System.Windows.Forms.Button buttonAddFolders;
        private System.Windows.Forms.Button buttonAddFiles;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.CheckBox checkBoxQuickFormat;
        private System.Windows.Forms.CheckBox checkBoxEjectFormat;
        private System.Windows.Forms.ProgressBar formatProgressBar;
        private System.Windows.Forms.Label labelFormatStatusText;
        private System.Windows.Forms.Button buttonFormat;
        private System.Windows.Forms.Label supportedMediaLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox devicesComboBox;
        private System.ComponentModel.BackgroundWorker backgroundBurnWorker;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.ComponentModel.BackgroundWorker backgroundFormatWorker;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar statusProgressBar;
        private System.Windows.Forms.Label labelStatusText;
        private System.Windows.Forms.Button buttonBurn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelMediaType;
        private System.Windows.Forms.Button buttonDetectMedia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotalSize;
        private System.Windows.Forms.ProgressBar progressBarCapacity;
    }
}

