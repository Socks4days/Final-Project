using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project.Models;

namespace Final_Project
{
	public partial class frmCreateAudit : Form
	{
		public frmCreateAudit()
		{
			InitializeComponent();

			PopulateComboBox();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			frmMainScreen.frmMain.CloseChildForm();
		}

		private void cBoxStock_SelectionChangeCommitted(object sender, EventArgs e)
		{
			lblNoExpectedInStock.Text = $"Number Expected In Stock: {StockDal.GetStockByStockName(cBoxStock.Text).stockLevel}";
		}

		
		private void PopulateComboBox()
		{
			List<Stock> sortedStockList = StockDal.GetAllStock();
			List<string> allStockNames = new List<string>();

			foreach(Stock stock in sortedStockList)
			{
				allStockNames.Add(stock.stockName);
			}

			cBoxStock.Items.Clear();
			cBoxStock.DataSource = allStockNames;
		}
	}
}
