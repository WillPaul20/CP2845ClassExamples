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

            var products = context.Products.Where(p => p.UnitPrice > 57).OrderBy(p => p.UnitPrice);

            foreach (var product in products)
            {
                rtbOutput.Text += $"{product.Description} Price = {product.UnitPrice}" + Environment.NewLine;
            }

            var products2 = from product in context.Products
                            where product.UnitPrice > 57 && product.OnHandQuantity > 4000
                            orderby product.UnitPrice
                            select product;

            foreach (var product in products2)
            {
                rtbOutput2.Text += $"{product.Description} Price = {product.UnitPrice}" + Environment.NewLine;
            }

            var invoices = from invoice in context.Invoices
                           where invoice.InvoiceTotal > 250
                           select new {invoice.CustomerId, 
                           invoice.InvoiceDate, invoice.InvoiceTotal};

            foreach(var invoice in invoices)
            {
                rtbOutput2.Text += $"{invoice.InvoiceTotal}" + Environment.NewLine;
            }
        }
    }
}
