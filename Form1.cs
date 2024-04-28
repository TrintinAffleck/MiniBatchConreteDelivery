﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace MiniBatchConreteDelivery
{
	public partial class TransactionSystemForm : Form
	{
		public TransactionSystemForm()
		{
			InitializeComponent();
			DisableMultiSelect();
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
			ProductsDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
			CustomerListDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
			InvoiceHistoryDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;

			// TODO: This line of code loads data into the 'miniBatchDataSet.Product' table. You can move, or remove it, as needed.
			productTableAdapter.Fill(miniBatchDataSet.Product);
			// TODO: This line of code loads data into the 'miniBatchDataSet.Invoice' table. You can move, or remove it, as needed.
			invoiceTableAdapter.Fill(miniBatchDataSet.Invoice);
			// TODO: This line of code loads data into the 'miniBatchDataSet.Customer' table. You can move, or remove it, as needed.
			customerTableAdapter.Fill(miniBatchDataSet.Customer);

			ProductsDataGrid.Columns[2].DefaultCellStyle.Format = "N2";
			ProductsDataGrid.Columns[6].DefaultCellStyle.Format = "N2";
			
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

		private void CustomerListCancelBtn_Click(object sender, EventArgs e)
		{
			CustomerListDataGrid.CancelEdit();
		}

		private void CustomerListEditBtn_Click(object sender, EventArgs e)
		{
			if (CustomerListDataGrid.SelectedCells.Count > 0)
			{
				CustomerListDataGrid.BeginEdit(false);
			}
		}

		private void InvoiceHistoryEditBtn_Click(object sender, EventArgs e)
		{
			if (InvoiceHistoryDataGrid.SelectedCells.Count > 0)
			{
				InvoiceHistoryDataGrid.BeginEdit(false);
			}
		}

		private void InvoiceHistoryCancelBtn_Click(object sender, EventArgs e)
		{
			InvoiceHistoryDataGrid.CancelEdit();
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
			//TODO Exception Handling
			ProductsDataGrid.BeginEdit(false);
		}
		List<DataGridViewCell> edittedCells = new List<DataGridViewCell>();
		private void ProductsListCell_Changed(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			int columnIndex = e.ColumnIndex;
			if (rowIndex >= 0)
			{
				foreach (DataGridViewRow row in ProductsDataGrid.Rows)
				{
					foreach(DataGridViewCell cell in row.Cells)
					{
						if (cell.ColumnIndex == columnIndex &&
							cell.RowIndex == rowIndex &&
							!edittedCells.Contains(cell))
						{
							edittedCells.Add(cell);
						}
					}
				}
			}
		}
		private void ProductListSaveBtn_Click(object sender, EventArgs e)
		{
			int productNumber = 0;
			string newValue = "";
			string columnName = "";
			bool success = false;
			foreach (DataGridViewCell cell in edittedCells)
			{
				
			}
			if (productNumber != 0 &&
				newValue != "" &&
				columnName != "")
			{
				if (success)
				{
					productTableAdapter.UpdateProductCell(miniBatchDataSet.Product, productNumber, columnName, newValue);
					productTableAdapter.Fill(miniBatchDataSet.Product);
				}
			}

			

		}

		private void ProductCancelBtn_Click(object sender, EventArgs e)
		{
			ProductsDataGrid.CancelEdit();
		}

		private void ProductNumberLabel_Click(object sender, EventArgs e)
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

