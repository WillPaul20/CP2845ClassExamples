using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chapter20_EF_demo.Models.DataLayer;

namespace Chapter20_EF_demo
{
    public partial class Joins : Form
    {
        public Joins()
        {
            InitializeComponent();
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            MMABooksContext context = new MMABooksContext();
            int invoiceId = Convert.ToInt32(txtUserInvoiceID.Text);

            var invoiceDetails = from invoice in context.Invoices
                                 join invoiceLineItem in context.InvoiceLineItems
                                 on invoice.InvoiceId equals invoiceLineItem.InvoiceId
                                 where invoice.InvoiceId == invoiceId
                                 select invoiceLineItem;

            foreach (var lineItem in invoiceDetails)
            {
                lstInvoiceDetails.Items.Add($"{lineItem.InvoiceId}  {lineItem.ProductCode}");
            }
        }
    }
}
