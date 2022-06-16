namespace MySQL_Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvWorld = new System.Windows.Forms.DataGridView();
            this.dgvCities = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCities)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(737, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scaffold-DbContext \"server=localhost;uid=root;pwd=password;database=world\" Pomelo" +
    ".EntityFrameworkCore.MySql -OutputDir world -f";
            // 
            // dgvWorld
            // 
            this.dgvWorld.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorld.Location = new System.Drawing.Point(12, 27);
            this.dgvWorld.Name = "dgvWorld";
            this.dgvWorld.RowTemplate.Height = 25;
            this.dgvWorld.Size = new System.Drawing.Size(737, 326);
            this.dgvWorld.TabIndex = 1;
            this.dgvWorld.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorld_CellContentClick);
            // 
            // dgvCities
            // 
            this.dgvCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCities.Location = new System.Drawing.Point(12, 359);
            this.dgvCities.Name = "dgvCities";
            this.dgvCities.RowTemplate.Height = 25;
            this.dgvCities.Size = new System.Drawing.Size(737, 269);
            this.dgvCities.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 640);
            this.Controls.Add(this.dgvCities);
            this.Controls.Add(this.dgvWorld);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dgvWorld;
        private DataGridView dgvCities;
    }
}