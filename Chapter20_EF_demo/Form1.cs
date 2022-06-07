using Chapter20_EF_demo.Models.DataLayer;
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

namespace Chapter20_EF_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MMABooksContext context = new MMABooksContext();
            var invoices = context.Invoices.ToList();
            // var selectedInvoice = context.Invoices.Where(i => i.InvoiceId == 33).FirstOrDefault();
            foreach (var invoice in invoices)
            {
                Debug.WriteLine(invoice);
            }


        }
    }
}
