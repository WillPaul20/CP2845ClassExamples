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
    public partial class ProductsCRUD : Form
    {
        public ProductsCRUD()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            bool argumentsOK = true;
            decimal price = 0.0m;
            int quantity = 0;
            string productCode = txtProductCode.Text;
            string prodcutDesc = txtProductDesc.Text;
           
            if (productCode.Length > 10)
            {
                argumentsOK = false;
                MessageBox.Show("Product Code must be less than 10 chars");
            }
            if (prodcutDesc.Length > 50)
            {
                argumentsOK = false;
                MessageBox.Show("Product Description must be less than 50 chars");
            }
            try
            {
                price = Convert.ToDecimal(txtProductPrice.Text);
            }
            catch
            {
                argumentsOK = false;
                MessageBox.Show("Product Price must be numeric");
            }
            try
            {
                quantity = Convert.ToInt32(txtProductQuantity.Text);
            }
            catch
            {
                argumentsOK = false;
                MessageBox.Show("Product Quantity must be an int");
            }
            MMABooksContext context = new MMABooksContext();
            if (argumentsOK)
            {
                var newProduct = new Products { Description = prodcutDesc,
                                                ProductCode = productCode, 
                                                UnitPrice = price, 
                                                OnHandQuantity = quantity};

                context.Products.Add(newProduct);
                context.SaveChanges();
                MessageBox.Show($"Product {prodcutDesc} Created Successfully", "Add Product");
            }
            else
            {
                MessageBox.Show($"Product {prodcutDesc} Not Created", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
