using Final_Project.Models;
using System.Numerics;
using System.Text;

namespace Final_Project
{
    public partial class frmStockManagement : Form
    {
        public frmStockManagement()
        {
            InitializeComponent();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int stockId = Convert.ToInt32(txtBoxEnterStockId.Text);

        }

        private void btnAddNewStock_Click(object sender, EventArgs e)
        {
            Stock newStock = new Stock();

            newStock.stockName = txtBoxNewStockName.Text;
            newStock.stockDescription = txtBoxNewStockDescription.Text;
            newStock.price = Convert.ToDecimal(txtBoxNewStockPrice.Text);
            newStock.maximumLevel = Convert.ToInt32(txtBoxNewMaximumLevel.Text);
            newStock.minimumLevel = Convert.ToInt32(txtBoxNewMinimumLevel.Text);

            int rowsAffected = StockDal.AddNewStock(newStock);

            if (rowsAffected > 0)
            {
                MessageBox.Show("New Stock Added Successfully!", "Successful");
            }
            else
            {
                MessageBox.Show("New Stock Not Added!", "Unsuccessful");
            }
        }
    }
    
}
