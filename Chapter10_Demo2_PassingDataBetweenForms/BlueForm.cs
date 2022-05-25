using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter10_Demo2_PassingDataBetweenForms
{
    public partial class BlueForm : Form
    {
        public BlueForm()
        {
            InitializeComponent();
        }

        private void btnShowYellowForm_Click(object sender, EventArgs e)
        {
            YellowForm yellowForm = new YellowForm();
            yellowForm.ShowDialog();
            txtBlueForm.Text = yellowForm.Tag.ToString();
        }
    }
}
