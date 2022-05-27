using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_12_Shapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Hello everyone!");
            MyPoint p1 = new MyPoint(5, 7);
            Debug.WriteLine(p1.ToString());
            p1.X = 9;
            Debug.WriteLine(p1.ToString());
            p1.Y = 12;
            Debug.WriteLine(p1.ToString());

            MyPoint p2 = new MyPoint(10, 5);
            Debug.WriteLine(p2.ToString());

            Debug.WriteLine($"p1.distance(p2) = {p1.distance(p2)}");
            Debug.WriteLine($"Distance to origin {p2.ToString()} {p2.distance()}");
        }

        private void btnCreatePoint_Click(object sender, EventArgs e)
        {
            MyPoint newPoint = new MyPoint(Convert.ToInt32(txtX.Text), Convert.ToInt32(txtY.Text));
            lstPoints.Items.Add(newPoint.ToString());
        }
    }
}
