namespace Chapter20_EF_demo
{
    partial class Joins
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
            this.txtUserInvoiceID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstInvoiceDetails = new System.Windows.Forms.ListView();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUserInvoiceID
            // 
            this.txtUserInvoiceID.Location = new System.Drawing.Point(105, 6);
            this.txtUserInvoiceID.Name = "txtUserInvoiceID";
            this.txtUserInvoiceID.Size = new System.Drawing.Size(100, 20);
            this.txtUserInvoiceID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Invoice ID:";
            // 
            // lstInvoiceDetails
            // 
            this.lstInvoiceDetails.HideSelection = false;
            this.lstInvoiceDetails.Location = new System.Drawing.Point(15, 33);
            this.lstInvoiceDetails.Name = "lstInvoiceDetails";
            this.lstInvoiceDetails.Size = new System.Drawing.Size(360, 231);
            this.lstInvoiceDetails.TabIndex = 2;
            this.lstInvoiceDetails.UseCompatibleStateImageBehavior = false;
            this.lstInvoiceDetails.View = System.Windows.Forms.View.List;
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Location = new System.Drawing.Point(224, 4);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(95, 23);
            this.btnShowInfo.TabIndex = 3;
            this.btnShowInfo.Text = "Show Info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // Joins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 276);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.lstInvoiceDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserInvoiceID);
            this.Name = "Joins";
            this.Text = "Joins";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserInvoiceID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstInvoiceDetails;
        private System.Windows.Forms.Button btnShowInfo;
    }
}