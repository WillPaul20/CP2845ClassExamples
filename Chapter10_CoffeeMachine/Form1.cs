using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter10_CoffeeMachine
{
    public partial class Form1 : Form
    {
        private string[] drinks = {"Espresso", "Latte", "Cappuccino"};
        private decimal amountAdded = 0.0m;
        private decimal billAmount = 0.0m;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string drink in drinks)
            {
                cmbDrink.Items.Add(drink);
            }
        }

        private void cmbDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbDrink.SelectedItem)
            {
                case "Espresso":
                {
                        txtBill.Text = "$1.50";
                        break;
                }
                case "Latte":
                    {
                        txtBill.Text = "$2.50";
                        break;
                    }
                case "Cappuccino":
                    {
                        txtBill.Text = "$4.00";
                        break;
                    }
                default:
                    {
                        txtBill.Text = "0.00";
                        break;
                    }
            }
        }

        private void btnAddCoin_Click(object sender, EventArgs e)
        {
            if (rdo200.Checked)
            {
                amountAdded += 200;
            }
            else if (rdo100.Checked)
            {
                amountAdded += 100;
            }
            else if (rdo25.Checked)
            {
                amountAdded += 25;
            }
            else
            {
                MessageBox.Show("Please select one of the radio buttons");
            }
            txtAmountAdded.Text = (amountAdded / 100).ToString("c");
        }

        private void btnMakeDrink_Click(object sender, EventArgs e)
        {
            Decimal.TryParse(txtBill.Text.Substring(1, 4), out billAmount);
            if (billAmount <= (amountAdded/100))
            {
                if (chbToGo.Checked)
                {
                    MessageBox.Show($"Enjoy your {cmbDrink.SelectedItem} in the car. Amount Added = ${amountAdded / 100}. Bill Amount {billAmount}");
                }
                else
                {
                    MessageBox.Show($"Enjoy your {cmbDrink.SelectedItem}. Amount Added = ${amountAdded / 100}. Bill Amount {billAmount}");
                }
                amountAdded -= (billAmount * 100);
                txtAmountAdded.Text = (amountAdded / 100).ToString("c");
            }
            else
            {
                MessageBox.Show("Insufficient Funds", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
