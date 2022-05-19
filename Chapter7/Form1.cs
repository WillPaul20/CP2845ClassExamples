using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDivideClick(object sender, EventArgs e)
        {
            try
            {
                Decimal a = Convert.ToDecimal(txtNum1.Text);
                Decimal b = Convert.ToDecimal(txtNum2.Text);

                txtDivisionOutput.Text = (a / b).ToString();                
            }
            catch (DivideByZeroException dbz)
            {
                MessageBox.Show(dbz.Message,"Zero Division Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message, fe.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
        }
    }
}
