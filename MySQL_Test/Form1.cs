using MySQL_Test.world;

namespace MySQL_Test
{
    public partial class Form1 : Form
    {
        private string countryCode;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            worldContext context = new();
            dgvWorld.DataSource = context.Countries.ToList();
        }

        private void dgvWorld_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            worldContext context = new();
            countryCode = dgvWorld.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            MessageBox.Show($"Col = {e.ColumnIndex}; Row = {e.RowIndex}; {countryCode}");
            // selectedProduct = context.Products.Find(productCode);
            
            var citiesQuery = from City in context.Cities
                              where City.CountryCode == countryCode
                              select City;

            dgvCities.DataSource = citiesQuery.ToList();
        }
    }
}