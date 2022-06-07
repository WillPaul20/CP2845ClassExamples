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

namespace Chapter_18_HelloLINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Data Source
            int[] numbers = new int[10] {4,8,2,3,9,7,6,0,1,10};

            // Create the query
            var query = from num in numbers
                        where num > 0 && num < 10
                        orderby num descending
                        select num;

            // Execute the query
            foreach(int i in query)
            {
                rtbOutput.Text += i.ToString() + "\n";
            }

            List<Invoice> invoiceList = new List<Invoice>();

            Invoice inv1 = new Invoice() {InvoiceID=10, InvoiceTotal=100 };
            Invoice inv2 = new Invoice() { InvoiceID = 20, InvoiceTotal = 200 };

            invoiceList.Add(inv1);
            invoiceList.Add(inv2);

            var invoice_query = from invoice in invoiceList
                                select new { invoice.InvoiceID, invoice.InvoiceTotal };

            foreach(var inv in invoice_query)
            {
                Debug.WriteLine($"{inv.InvoiceID} -> {inv.InvoiceTotal}");
            }
        }
    }
}
