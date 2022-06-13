using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chapter22_DataGridView.Models.DataLayer;

namespace Chapter22_DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadProducts_Click(object sender, EventArgs e)
        {
            dataGridProducts.Columns.Clear();
            dataGridProducts.Rows.Clear();
            MMABooksContext context = new MMABooksContext();
            dataGridProducts.DataSource = context.Products.ToList();
        }

        private void btnProductsSortedByPrice_Click(object sender, EventArgs e)
        {
            dataGridProducts.Columns.Clear();
            dataGridProducts.Rows.Clear();
            MMABooksContext context = new MMABooksContext();

            var sortedProducts = from product in context.Products
                                 orderby product.UnitPrice
                                 select new
                                 {
                                     product.ProductCode,
                                     product.Description,
                                     product.UnitPrice,
                                     product.OnHandQuantity
                                 };

            dataGridProducts.DataSource = sortedProducts.ToList();

            DataGridViewButtonColumn modifyColumn = new DataGridViewButtonColumn();
            modifyColumn.HeaderText = "";
            modifyColumn.UseColumnTextForButtonValue = true;
            modifyColumn.Text = "Modify";
            dataGridProducts.Columns.Add(modifyColumn);

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "";
            deleteColumn.UseColumnTextForButtonValue = true;
            deleteColumn.Text = "Delete";
            dataGridProducts.Columns.Add(deleteColumn);




            dataGridProducts.Columns[0].HeaderText = "Product Code";
            dataGridProducts.Columns[2].HeaderText = "Price";
            dataGridProducts.Columns[3].HeaderText = "Quantity";

            dataGridProducts.Columns[2].DefaultCellStyle.Format = "c";
            
            dataGridProducts.Columns[1].Width = 220;

            dataGridProducts.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridProducts.EnableHeadersVisualStyles = false;
            dataGridProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            dataGridProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGoldenrod;
            dataGridProducts.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridProducts.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;


        }
        Products selectedProduct;
        private void dataGridProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // MessageBox.Show($"ROW={e.RowIndex} COL={e.ColumnIndex}","Cell Clicked");
            MMABooksContext context = new MMABooksContext();
            if (e.ColumnIndex == 4 || e.ColumnIndex == 5){
                string selectedProductCode = $"{dataGridProducts.Rows[e.RowIndex].Cells[0].Value.ToString().Trim()}";
                selectedProduct = context.Products.Find(selectedProductCode);
            }
            if (e.ColumnIndex == 4)
            {
                // Modify
                txtPDesc.Text = selectedProduct.Description;
                txtPPrice.Text = selectedProduct.UnitPrice.ToString();
                txtPQuantity.Text = selectedProduct.OnHandQuantity.ToString();
            }
            else if(e.ColumnIndex == 5)
            {
                // Delete
                context.Products.Remove(selectedProduct);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MMABooksContext context = new MMABooksContext();
            context.Products.Update(selectedProduct);
            context.SaveChanges();
        }

        private void txtPDesc_TextChanged(object sender, EventArgs e)
        {
            selectedProduct.Description = txtPDesc.Text;
        }

        private void txtPPrice_TextChanged(object sender, EventArgs e)
        {
            selectedProduct.UnitPrice = Convert.ToDecimal(txtPPrice.Text);
        }

        private void txtPQuantity_TextChanged(object sender, EventArgs e)
        {
            selectedProduct.OnHandQuantity = Convert.ToInt32(txtPQuantity.Text);
        }
    }
}
