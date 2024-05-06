using System;
using System.Windows.Forms;
namespace MiniBatchConreteDelivery
{
	public partial class TransactionSystemForm : Form
	{ 
		public void DisableMultiSelect()
		{
			productsDataGrid.MultiSelect = false;
			InvoiceHistoryDataGrid.MultiSelect = false;
			CustomerListDataGrid.MultiSelect = false;
		}

		public bool IsNumeric(DataGridViewCell cell)
		{
			if (cell.Value == null) { return false; }
			return double.TryParse(cell.Value.ToString(), out _) ? true : false;
		}

	}
}
