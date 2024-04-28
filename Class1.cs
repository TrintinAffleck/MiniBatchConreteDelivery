using System;
using System.Windows.Forms;
namespace MiniBatchConreteDelivery
{
	public partial class TransactionSystemForm : Form
	{ 
		public void DisableMultiSelect()
		{
			ProductsDataGrid.MultiSelect = false;
			InvoiceHistoryDataGrid.MultiSelect = false;
			CustomerListDataGrid.MultiSelect = false;
		}
	}
}
