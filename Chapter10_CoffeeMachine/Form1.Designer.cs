namespace Chapter10_CoffeeMachine
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
            this.cmbDrink = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo200 = new System.Windows.Forms.RadioButton();
            this.rdo100 = new System.Windows.Forms.RadioButton();
            this.rdo25 = new System.Windows.Forms.RadioButton();
            this.btnAddCoin = new System.Windows.Forms.Button();
            this.txtAmountAdded = new System.Windows.Forms.TextBox();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.chbToGo = new System.Windows.Forms.CheckBox();
            this.btnMakeDrink = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDrink
            // 
            this.cmbDrink.FormattingEnabled = true;
            this.cmbDrink.Location = new System.Drawing.Point(84, 10);
            this.cmbDrink.Name = "cmbDrink";
            this.cmbDrink.Size = new System.Drawing.Size(132, 21);
            this.cmbDrink.TabIndex = 0;
            this.cmbDrink.Text = "Select a drink";
            this.cmbDrink.SelectedIndexChanged += new System.EventHandler(this.cmbDrink_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Drink";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo25);
            this.groupBox1.Controls.Add(this.rdo100);
            this.groupBox1.Controls.Add(this.rdo200);
            this.groupBox1.Location = new System.Drawing.Point(16, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Money";
            // 
            // rdo200
            // 
            this.rdo200.AutoSize = true;
            this.rdo200.Location = new System.Drawing.Point(7, 20);
            this.rdo200.Name = "rdo200";
            this.rdo200.Size = new System.Drawing.Size(52, 17);
            this.rdo200.TabIndex = 0;
            this.rdo200.TabStop = true;
            this.rdo200.Text = "$2.00";
            this.rdo200.UseVisualStyleBackColor = true;
            // 
            // rdo100
            // 
            this.rdo100.AutoSize = true;
            this.rdo100.Location = new System.Drawing.Point(7, 44);
            this.rdo100.Name = "rdo100";
            this.rdo100.Size = new System.Drawing.Size(52, 17);
            this.rdo100.TabIndex = 1;
            this.rdo100.TabStop = true;
            this.rdo100.Text = "$1.00";
            this.rdo100.UseVisualStyleBackColor = true;
            // 
            // rdo25
            // 
            this.rdo25.AutoSize = true;
            this.rdo25.Location = new System.Drawing.Point(7, 68);
            this.rdo25.Name = "rdo25";
            this.rdo25.Size = new System.Drawing.Size(52, 17);
            this.rdo25.TabIndex = 2;
            this.rdo25.TabStop = true;
            this.rdo25.Text = "$0.25";
            this.rdo25.UseVisualStyleBackColor = true;
            // 
            // btnAddCoin
            // 
            this.btnAddCoin.Location = new System.Drawing.Point(16, 195);
            this.btnAddCoin.Name = "btnAddCoin";
            this.btnAddCoin.Size = new System.Drawing.Size(200, 23);
            this.btnAddCoin.TabIndex = 3;
            this.btnAddCoin.Text = "Add Coin";
            this.btnAddCoin.UseVisualStyleBackColor = true;
            this.btnAddCoin.Click += new System.EventHandler(this.btnAddCoin_Click);
            // 
            // txtAmountAdded
            // 
            this.txtAmountAdded.Location = new System.Drawing.Point(16, 169);
            this.txtAmountAdded.Name = "txtAmountAdded";
            this.txtAmountAdded.Size = new System.Drawing.Size(200, 20);
            this.txtAmountAdded.TabIndex = 4;
            // 
            // txtBill
            // 
            this.txtBill.Location = new System.Drawing.Point(16, 37);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(200, 20);
            this.txtBill.TabIndex = 5;
            // 
            // chbToGo
            // 
            this.chbToGo.AutoSize = true;
            this.chbToGo.Location = new System.Drawing.Point(16, 228);
            this.chbToGo.Name = "chbToGo";
            this.chbToGo.Size = new System.Drawing.Size(56, 17);
            this.chbToGo.TabIndex = 6;
            this.chbToGo.Text = "To Go";
            this.chbToGo.UseVisualStyleBackColor = true;
            // 
            // btnMakeDrink
            // 
            this.btnMakeDrink.Location = new System.Drawing.Point(84, 224);
            this.btnMakeDrink.Name = "btnMakeDrink";
            this.btnMakeDrink.Size = new System.Drawing.Size(132, 23);
            this.btnMakeDrink.TabIndex = 7;
            this.btnMakeDrink.Text = "Make Drink";
            this.btnMakeDrink.UseVisualStyleBackColor = true;
            this.btnMakeDrink.Click += new System.EventHandler(this.btnMakeDrink_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 304);
            this.Controls.Add(this.btnMakeDrink);
            this.Controls.Add(this.chbToGo);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.txtAmountAdded);
            this.Controls.Add(this.btnAddCoin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDrink);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDrink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo25;
        private System.Windows.Forms.RadioButton rdo100;
        private System.Windows.Forms.RadioButton rdo200;
        private System.Windows.Forms.Button btnAddCoin;
        private System.Windows.Forms.TextBox txtAmountAdded;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.CheckBox chbToGo;
        private System.Windows.Forms.Button btnMakeDrink;
    }
}

