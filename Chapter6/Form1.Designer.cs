namespace Chapter6
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtCircumference = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculateCircleAreaAndCircumference = new System.Windows.Forms.Button();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.btnCalculateRect = new System.Windows.Forms.Button();
            this.txtRectArea = new System.Windows.Forms.TextBox();
            this.txtRectPerimeter = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtCircumference);
            this.tabPage1.Controls.Add(this.txtArea);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnCalculateCircleAreaAndCircumference);
            this.tabPage1.Controls.Add(this.txtRadius);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Circle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtCircumference
            // 
            this.txtCircumference.Location = new System.Drawing.Point(88, 92);
            this.txtCircumference.Name = "txtCircumference";
            this.txtCircumference.Size = new System.Drawing.Size(68, 20);
            this.txtCircumference.TabIndex = 6;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(87, 66);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(69, 20);
            this.txtArea.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Circumference";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Area";
            // 
            // btnCalculateCircleAreaAndCircumference
            // 
            this.btnCalculateCircleAreaAndCircumference.Location = new System.Drawing.Point(10, 30);
            this.btnCalculateCircleAreaAndCircumference.Name = "btnCalculateCircleAreaAndCircumference";
            this.btnCalculateCircleAreaAndCircumference.Size = new System.Drawing.Size(146, 23);
            this.btnCalculateCircleAreaAndCircumference.TabIndex = 2;
            this.btnCalculateCircleAreaAndCircumference.Text = "Calculate";
            this.btnCalculateCircleAreaAndCircumference.UseVisualStyleBackColor = true;
            this.btnCalculateCircleAreaAndCircumference.Click += new System.EventHandler(this.btnCalculateCircleAreaAndCircumference_Click);
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(56, 4);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 20);
            this.txtRadius.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radius:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtRectPerimeter);
            this.tabPage2.Controls.Add(this.txtRectArea);
            this.tabPage2.Controls.Add(this.btnCalculateRect);
            this.tabPage2.Controls.Add(this.txtWidth);
            this.tabPage2.Controls.Add(this.txtLength);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rectangle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Width";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(78, 6);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 2;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(82, 41);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(96, 20);
            this.txtWidth.TabIndex = 3;
            // 
            // btnCalculateRect
            // 
            this.btnCalculateRect.Location = new System.Drawing.Point(59, 83);
            this.btnCalculateRect.Name = "btnCalculateRect";
            this.btnCalculateRect.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateRect.TabIndex = 4;
            this.btnCalculateRect.Text = "Calculate";
            this.btnCalculateRect.UseVisualStyleBackColor = true;
            this.btnCalculateRect.Click += new System.EventHandler(this.btnCalculateRect_Click);
            // 
            // txtRectArea
            // 
            this.txtRectArea.Location = new System.Drawing.Point(67, 126);
            this.txtRectArea.Name = "txtRectArea";
            this.txtRectArea.Size = new System.Drawing.Size(100, 20);
            this.txtRectArea.TabIndex = 5;
            // 
            // txtRectPerimeter
            // 
            this.txtRectPerimeter.Location = new System.Drawing.Point(67, 183);
            this.txtRectPerimeter.Name = "txtRectPerimeter";
            this.txtRectPerimeter.Size = new System.Drawing.Size(100, 20);
            this.txtRectPerimeter.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Methods and Event Handler";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtCircumference;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculateCircleAreaAndCircumference;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRectPerimeter;
        private System.Windows.Forms.TextBox txtRectArea;
        private System.Windows.Forms.Button btnCalculateRect;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

