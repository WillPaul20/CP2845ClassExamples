using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;

            int.TryParse(txtNumber1.Text, out n1);
            int.TryParse(txtNumber2.Text, out n2);

            if (n1 == 0 || n2 == 0)
            {
                txtOutput.Text = "Both inputs must be non-zero integers.";
            }

            else if (n1 == n2)
            {
                txtOutput.Text = "Both Numbers are Equal";
            }
            else if (n1 < n2)
            {
                txtOutput.Text = $"{n1} is less than {n2}";
            }
            else if (n1 > n2)
            {
                txtOutput.Text = $"{n1} is greater than {n2}";
            }
        }

        private void btnFindProvince_Click(object sender, EventArgs e)
        {
            string code = txtProvCode.Text;

            switch (code)
            {
                case "nl":
                case "NL":
                    txtProvinceName.Text = "Newfoundland and Labrador";
                    break;
                case "NS":
                    txtProvinceName.Text = "Nova Scotia";
                    break;
                default:
                    txtProvinceName.Text = "Invalid Province";
                    break;
            }

        }

        private void btnGenerateTable_Click(object sender, EventArgs e)
        {
            int n = 0;
            int.TryParse(txtNumber.Text, out n);
            if (n == 0)
                rtbMultiplicationTable.Text = "Invalid Number";
            else
            {
                rtbMultiplicationTable.Text = "";
                for (int i = 1; i <= 10; i++)
                {
                    rtbMultiplicationTable.Text += $"{n} X {i} = {n*i}{Environment.NewLine}";
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bse = 0;
            int.TryParse(txtBase.Text, out bse);

            int exp = 0;
            int.TryParse(txtExponent.Text, out exp);

            int counter = 0;
            ulong answer = 1;
            while (counter < exp)
            {
                answer *= (ulong)bse;
                counter++;
            }
            txtPowOutput.Text = answer.ToString();
        }
    }
}
