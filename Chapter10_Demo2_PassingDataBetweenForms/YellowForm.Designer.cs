namespace Chapter10_Demo2_PassingDataBetweenForms
{
    partial class YellowForm
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
            this.txtYellow = new System.Windows.Forms.TextBox();
            this.btnYellow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtYellow
            // 
            this.txtYellow.Location = new System.Drawing.Point(118, 81);
            this.txtYellow.Name = "txtYellow";
            this.txtYellow.Size = new System.Drawing.Size(138, 20);
            this.txtYellow.TabIndex = 0;
            // 
            // btnYellow
            // 
            this.btnYellow.Location = new System.Drawing.Point(118, 107);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(138, 23);
            this.btnYellow.TabIndex = 1;
            this.btnYellow.Text = "Pass to the blue form";
            this.btnYellow.UseVisualStyleBackColor = true;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // YellowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(374, 249);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.txtYellow);
            this.Name = "YellowForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYellow;
        private System.Windows.Forms.Button btnYellow;
    }
}