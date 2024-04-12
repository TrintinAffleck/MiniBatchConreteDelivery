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
			Console.WriteLine("Label 1 Clicked");
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

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			Console.WriteLine("Clicked DataGridview1");
		}

		private void TransactionSystemForm_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'miniBatchDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.miniBatchDataSet.Product);
            // TODO: This line of code loads data into the 'miniBatchDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.miniBatchDataSet.Customer);
            // TODO: This line of code loads data into the 'miniBatchDataSet.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.miniBatchDataSet.Invoice);


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

	}
}
