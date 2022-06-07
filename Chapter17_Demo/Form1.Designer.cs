namespace Chapter17_Demo
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
            this.btnShowCurrentDirectory = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.rtbFileContent = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBinFileName = new System.Windows.Forms.TextBox();
            this.btnBinFileOpen = new System.Windows.Forms.Button();
            this.txtBinFileSave = new System.Windows.Forms.Button();
            this.rtbBinFile = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowCurrentDirectory
            // 
            this.btnShowCurrentDirectory.Location = new System.Drawing.Point(6, 6);
            this.btnShowCurrentDirectory.Name = "btnShowCurrentDirectory";
            this.btnShowCurrentDirectory.Size = new System.Drawing.Size(141, 23);
            this.btnShowCurrentDirectory.TabIndex = 0;
            this.btnShowCurrentDirectory.Text = "Show Current Directory";
            this.btnShowCurrentDirectory.UseVisualStyleBackColor = true;
            this.btnShowCurrentDirectory.Click += new System.EventHandler(this.btnShowCurrentDirectory_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(92, 40);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(141, 20);
            this.txtFileName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Filename:";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(239, 38);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(107, 23);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // rtbFileContent
            // 
            this.rtbFileContent.Location = new System.Drawing.Point(9, 67);
            this.rtbFileContent.Name = "rtbFileContent";
            this.rtbFileContent.Size = new System.Drawing.Size(607, 447);
            this.rtbFileContent.TabIndex = 4;
            this.rtbFileContent.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(352, 38);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(630, 546);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtbBinFile);
            this.tabPage1.Controls.Add(this.txtBinFileSave);
            this.tabPage1.Controls.Add(this.btnBinFileOpen);
            this.tabPage1.Controls.Add(this.txtBinFileName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(622, 520);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Binary File I/O";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnShowCurrentDirectory);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.rtbFileContent);
            this.tabPage2.Controls.Add(this.txtFileName);
            this.tabPage2.Controls.Add(this.btnRead);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(622, 520);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Text File I/O";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "File Name:";
            // 
            // txtBinFileName
            // 
            this.txtBinFileName.Location = new System.Drawing.Point(69, 13);
            this.txtBinFileName.Name = "txtBinFileName";
            this.txtBinFileName.Size = new System.Drawing.Size(385, 20);
            this.txtBinFileName.TabIndex = 1;
            // 
            // btnBinFileOpen
            // 
            this.btnBinFileOpen.Location = new System.Drawing.Point(460, 10);
            this.btnBinFileOpen.Name = "btnBinFileOpen";
            this.btnBinFileOpen.Size = new System.Drawing.Size(75, 23);
            this.btnBinFileOpen.TabIndex = 2;
            this.btnBinFileOpen.Text = "Open";
            this.btnBinFileOpen.UseVisualStyleBackColor = true;
            this.btnBinFileOpen.Click += new System.EventHandler(this.btnBinFileOpen_Click);
            // 
            // txtBinFileSave
            // 
            this.txtBinFileSave.Location = new System.Drawing.Point(541, 10);
            this.txtBinFileSave.Name = "txtBinFileSave";
            this.txtBinFileSave.Size = new System.Drawing.Size(75, 23);
            this.txtBinFileSave.TabIndex = 3;
            this.txtBinFileSave.Text = "Save";
            this.txtBinFileSave.UseVisualStyleBackColor = true;
            this.txtBinFileSave.Click += new System.EventHandler(this.txtBinFileSave_Click);
            // 
            // rtbBinFile
            // 
            this.rtbBinFile.Location = new System.Drawing.Point(9, 48);
            this.rtbBinFile.Name = "rtbBinFile";
            this.rtbBinFile.Size = new System.Drawing.Size(377, 114);
            this.rtbBinFile.TabIndex = 4;
            this.rtbBinFile.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 570);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowCurrentDirectory;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.RichTextBox rtbFileContent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox rtbBinFile;
        private System.Windows.Forms.Button txtBinFileSave;
        private System.Windows.Forms.Button btnBinFileOpen;
        private System.Windows.Forms.TextBox txtBinFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

