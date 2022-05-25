using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter11_Debugging
{
    public partial class Form1 : Form
    {
        double getCircleArea(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be greater than 0.");
            }
            else
            {
                return (radius * radius * Math.PI);
            }
            
        }

        double getCylinderVolume(double radius, double height)
        {
            if (height <= 0)
            {
                throw new ArgumentException("Height must be greater than 0.");
            }
            else
            {
                return height * getCircleArea(radius);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double hgt = Double.Parse(txtHeight.Text);
            double rad = Double.Parse(txtRadius.Text);

            txtResult.Text = getCylinderVolume(rad, hgt).ToString();
        }
    }
}
