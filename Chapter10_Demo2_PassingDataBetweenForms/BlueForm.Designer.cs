namespace Chapter10_Demo2_PassingDataBetweenForms
{
    partial class BlueForm
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
            this.btnShowYellowForm = new System.Windows.Forms.Button();
            this.txtBlueForm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnShowYellowForm
            // 
            this.btnShowYellowForm.Location = new System.Drawing.Point(70, 85);
            this.btnShowYellowForm.Name = "btnShowYellowForm";
            this.btnShowYellowForm.Size = new System.Drawing.Size(142, 23);
            this.btnShowYellowForm.TabIndex = 0;
            this.btnShowYellowForm.Text = "Show Yellow Form";
            this.btnShowYellowForm.UseVisualStyleBackColor = true;
            this.btnShowYellowForm.Click += new System.EventHandler(this.btnShowYellowForm_Click);
            // 
            // txtBlueForm
            // 
            this.txtBlueForm.Location = new System.Drawing.Point(70, 132);
            this.txtBlueForm.Name = "txtBlueForm";
            this.txtBlueForm.Size = new System.Drawing.Size(142, 20);
            this.txtBlueForm.TabIndex = 1;
            // 
            // BlueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(287, 232);
            this.Controls.Add(this.txtBlueForm);
            this.Controls.Add(this.btnShowYellowForm);
            this.Name = "BlueForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowYellowForm;
        private System.Windows.Forms.TextBox txtBlueForm;
    }
}

