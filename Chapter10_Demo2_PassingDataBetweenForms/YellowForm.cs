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
    public partial class YellowForm : Form
    {
        public YellowForm()
        {
            InitializeComponent();
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            this.Tag = txtYellow.Text;
            this.Close();
        }
    }
}
