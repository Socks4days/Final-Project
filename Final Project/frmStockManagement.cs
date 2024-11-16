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
            showStockSearch();
        }



        public static Stock lookupStock = new Stock();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string stockId = txtBoxEnterStockId.Text;
            List<Stock> allStock = StockDal.GetAllStock();
            foreach (Stock stock in allStock)
            {
                if (stock.stockId.ToString() == stockId)
                {
                    lookupStock = StockDal.GetStockByStockId(stockId);
                    lblStockLevelToEdit.Text = $"You are currently editing the stock levels for {stock.stockName}";                    
                    showEditStock();
                }
                else
                {
                    ShowErrorStockLookup("There is no stock with that stock ID, please try again.");
                }
            }

        }

        private void showStockSearch()
        {
            pnlAddOrDepleteFromStock.Visible = false;
            pnlLookupStock.Visible = true;            
        }

        private void showEditStock()
        {
            pnlLookupStock.Visible = false;
            pnlAddOrDepleteFromStock.Visible = true;
        }

        private void btnAddToStock_Click(object sender, EventArgs e)
        {
            int amountToAdd = 0;
            int originalStockLevel = lookupStock.stockLevel;
            try
            {
                amountToAdd = Convert.ToInt32(txtBoxAmountOfStockToChange.Text);
            }
            catch (Exception ex)
            {
                ShowMessageStockLevel("That is not a valid number");
            }

            if (lookupStock.stockLevel + amountToAdd <= lookupStock.maximumLevel)
            {
                lookupStock.stockLevel += amountToAdd;
                StockDal.UpdateStockByStockId(lookupStock);
                ShowMessageStockLevel($"Successfully added {amountToAdd} to stock level!");
            }
            else if (lookupStock.stockLevel == lookupStock.maximumLevel)
            {
                ShowMessageStockLevel("This item of stock's storage is full. 0 items added.");
            }
            else
            {
                lookupStock.stockLevel = lookupStock.maximumLevel;

                StockDal.UpdateStockByStockId(lookupStock);

                ShowMessageStockLevel($"The amount you are attempting to add exceeds the maximum capacity for this stock item. " +
                    $"{lookupStock.maximumLevel - originalStockLevel} items have been added to stock. This stock is now full.");
            }
        }

        private void btnRemoveFromStock_Click(object sender, EventArgs e)
        {
            int amountToRemove = 0;
            int originalStockLevel = lookupStock.stockLevel;

            try
            {
                amountToRemove = Convert.ToInt32(txtBoxAmountOfStockToChange.Text);
            }
            catch (Exception ex)
            {
                ShowMessageStockLevel("That is not a valid number.");
            }
            if(amountToRemove <= 0)
            {
                ShowMessageStockLevel("That is not a valid number.");
            }

            if (lookupStock.stockLevel - amountToRemove >= 0)
            {
                lookupStock.stockLevel -= amountToRemove;
                StockDal.UpdateStockByStockId(lookupStock);
                ShowMessageStockLevel($"Successfully removed {amountToRemove} to stock level!");
            }
            else if (lookupStock.stockLevel == 0)
            {
                ShowMessageStockLevel("This item of stock's storage is empty. 0 items removed.");
            }
            else
            {
                lookupStock.stockLevel = 0;

                StockDal.UpdateStockByStockId(lookupStock);

                ShowMessageStockLevel($"The amount you are attempting to remove leaves less than 0 remaining for this stock item. " +
                    $"{lookupStock.maximumLevel - originalStockLevel} items have been removed to stock. This stock is now empty.");
            }
        }

        private void ShowMessageStockLevel(string errorMessage)
        {
            // shows an error indicating which boxes need to be filled in to be valid
            lblErrorStockLevel.Text = errorMessage;
            lblErrorStockLevel.Visible = true;
        }
        private void ShowErrorStockLookup(string errorMessage)
        {
            // shows an error indicating which boxes need to be filled in to be valid
            lblErrorStockLookup.Text = errorMessage;
            lblErrorStockLookup.Visible = true;
        }

        private void ClearError()
        {
            // hide error message
            lblErrorStockLevel.Text = "";
            lblErrorStockLevel.Visible = false;
            lblErrorStockLookup.Text = "";
            lblErrorStockLookup.Visible = false;
            txtBoxAmountOfStockToChange.Text = "";
            txtBoxEnterStockId.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ClearError();
            showStockSearch();
        }
    }
}
