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
			this.customerTableAdapter1.Fill(this.miniBatchDataSetNew.Customer);
			this.productTableAdapter1.Fill(this.miniBatchDataSetNew.Product);
			this.invoiceTableAdapter1.Fill(this.miniBatchDataSetNew.Invoice);
		


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

		private void InvoiceHistoryEditBtn_Click(object sender, EventArgs e)
		{
			
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

		private void Creation_TimeLabel_Click(object sender, EventArgs e)
		{

		}

		private void Creation_DeliveryCostTextBox_TextChanged(object sender, EventArgs e)
		{
		
		}
	}
}
