using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private decimal CalculateRadius(decimal radius)
        {
            return (decimal)Math.PI * radius * radius;
        }

        public decimal CalculateCircumference(decimal radius)
        {
            return (decimal)Math.PI * 2.0m * radius;
        }

        private void btnCalculateCircleAreaAndCircumference_Click(object sender, EventArgs e)
        {
            string user_radius = txtRadius.Text;

            if (Decimal.TryParse(user_radius, out decimal radius))
            {
                txtArea.Text = Decimal.Round(this.CalculateRadius(radius), 2).ToString();
                txtCircumference.Text = this.CalculateCircumference(radius).ToString("0.00");
            }
            else
            {
                // Invalid
                txtArea.Text = "Invalid Input";
                txtCircumference.Text = "Invalid Input";

            }
        }

        private void GetRectangleArea(in decimal length, in decimal width, out decimal area, ref string colour)
        {
            colour = "blue";
            area = length * width;
        }

        private void btnCalculateRect_Click(object sender, EventArgs e)
        {
            Decimal.TryParse(txtLength.Text, out decimal len); // creating len
            Decimal.TryParse(txtWidth.Text, out decimal wid);

            string clr = "red";

            this.GetRectangleArea(in len, in wid, out decimal rect_area, ref clr);

            rect_area = 0.0m;

            txtRectArea.Text = rect_area.ToString();
            txtRectPerimeter.Text = clr;

        }
    }
}
