using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniBatchConreteDelivery
{
	public partial class TransactionSystemForm : Form
	{
		public TransactionSystemForm()
		{
			InitializeComponent();
		}

		private void HeaderLabel_Click(object sender, EventArgs e)
		{
			
		}

		private void LookUpGroupBox_Enter(object sender, EventArgs e)
		{

		}

		private void LookupNameTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void LookupNameLabel_Click(object sender, EventArgs e)
		{

		}

		private void LookupPhoneNumberLabel_Click(object sender, EventArgs e)
		{
		}

		private void ProductNumberLabel_Click(object sender, EventArgs e)
		{

		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
		
		}

		private void ClearAllFieldsBtn1_Click(object sender, EventArgs e)
		{
			NameTextBox.Clear();
			PhoneNumberTextBox.Clear();
			ProductNumberComboBox.ResetText();
			InvoiceNumberComboBox.ResetText();
			OrderNumberComboBox.ResetText();
		}

		private void CustomerListTableLayoutPanelableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}



		private void TransactionSystemForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'miniBatchDataSet.Product' table. You can move, or remove it, as needed.
			productTableAdapter.Fill(miniBatchDataSet.Product);
			// TODO: This line of code loads data into the 'miniBatchDataSet.Invoice' table. You can move, or remove it, as needed.
			invoiceTableAdapter.Fill(miniBatchDataSet.Invoice);
			// TODO: This line of code loads data into the 'miniBatchDataSet.Customer' table. You can move, or remove it, as needed.
			customerTableAdapter.Fill(miniBatchDataSet.Customer);
			ProductsOnOrderDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;

		}

		private void CreationGroupBox_Enter(object sender, EventArgs e) 
		{
			
		}

		private void Creation_ProductNumberLabel_Click(object sender, EventArgs e)
		{

		}

		private void Creation_DueDateLabel_Click(object sender, EventArgs e)
		{

		}

		private void Creation_InvoiceNumberLabel_Click(object sender, EventArgs e)
		{

		}

		private void CreationProductNumberDropdown_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void CustomerListClearBtn_Click(object sender, EventArgs e)
		{

		}

		private void CustomerListEditBtn_Click(object sender, EventArgs e)
		{
			CustomerListDataGrid.BeginEdit(false);
		}

		private void InvoiceHistoryEditBtn_Click(object sender, EventArgs e)
		{
			InvoiceHistoryDataGrid.BeginEdit(false);
		}

		private void InvoiceHistoryClearBtn_Click(object sender, EventArgs e)
		{

		}

		private void InvoiceHistoryClearFieldsBtn_Click(object sender, EventArgs e)
		{

		}

		private void InvoiceHistorySaveBtn_Click(object sender, EventArgs e)
		{

		}

		private void InvoiceHistoryGroupBox_Enter(object sender, EventArgs e)
		{

		}

		private void ProductListEditBtn_Click(object sender, EventArgs e)
		{
			ProductsOnOrderDataGrid.BeginEdit(false);
		}

		private void Creation_TimeLabel_Click(object sender, EventArgs e)
		{

		}

		private void Creation_DeliveryCostTextBox_TextChanged(object sender, EventArgs e)
		{
		
		}
	}
}
