using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Remoting.Messaging;
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
			productsDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
			CustomerListDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
			InvoiceHistoryDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;

			// TODO: This line of code loads data into the 'miniBatchDataSet.Product' table. You can move, or remove it, as needed.
			productTableAdapter.Fill(miniBatchDataSet.Product);
			// TODO: This line of code loads data into the 'miniBatchDataSet.Invoice' table. You can move, or remove it, as needed.
			invoiceTableAdapter.Fill(miniBatchDataSet.Invoice);
			// TODO: This line of code loads data into the 'miniBatchDataSet.Customer' table. You can move, or remove it, as needed.
			customerTableAdapter.Fill(miniBatchDataSet.Customer);

			productsDataGrid.Columns[2].DefaultCellStyle.Format = "N2";
			productsDataGrid.Columns[6].DefaultCellStyle.Format = "N2";
			
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
			productsDataGrid.BeginEdit(false);
		}
		List<DataGridViewCell> edittedCells = new List<DataGridViewCell>();
		private void ProductsListCell_Changed(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			int columnIndex = e.ColumnIndex;
			if (rowIndex >= 0)
			{
				foreach (DataGridViewRow row in productsDataGrid.Rows)
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

		private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{

			MessageBox.Show("Error happened " + e.Context.ToString());


			if ((e.Exception) is ConstraintException)
			{
				DataGridView view = (DataGridView)sender;
				view.Rows[e.RowIndex].ErrorText = "an error";
				view.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "an error";

				e.ThrowException = false;
			}
		}

		private void CellEdit_DoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			productsDataGrid.BeginEdit(false);
			
		}
		private void ProductListSaveBtn_Click(object sender, EventArgs e)
		{
			if (productsDataGrid.BeginEdit(false))
			{
				productsDataGrid.EndEdit();
			}
			int prodNum = 0;
			string newValue = "";
			string columnName = "";
			bool success = false;
			bool displaySuccessMessage = false;
			foreach (DataGridViewCell cell in edittedCells)
			{
				if (prodNum == 0 &&
					newValue == "" &&
					columnName == "" &&
					cell.Value != null)
				{
					string currColName = cell.OwningColumn.HeaderText.ToLower();
					prodNum = (int)cell.OwningRow.Cells[3].Value;
					bool isValueNum = IsNumeric(cell);
					switch (currColName)
					{
						case "itemcode":
							{
								if (!isValueNum)
								{
									columnName = currColName;
									newValue = cell.Value.ToString();
									success = true;
								}
								break;
							}
						case "productdescription":
							{
								if (!isValueNum)
								{
									columnName = currColName;
									newValue = cell.Value.ToString();
									success = true;
								}
								break;
							}
						case "value":
							{
								if (isValueNum)
								{
									columnName = currColName;
									newValue = cell.Value.ToString();
									success = true;
								}
								break;
							}
						case "reorderquantity":
							{
								if (isValueNum)
								{
									columnName = currColName;
									newValue = cell.Value.ToString();
									prodNum = (int)cell.OwningRow.Cells[3].Value;
									success = true;
								}
								break;
							}
						case "unitofmeassure":
							{
								if (!isValueNum)
								{
									columnName = currColName;
									newValue = cell.Value.ToString();
									prodNum = (int)cell.OwningRow.Cells[3].Value;
									success = true;
								}
								break;
							}
						case "sellprice":
							{
								if (isValueNum)
								{
									columnName = currColName;
									newValue = cell.Value.ToString();
									prodNum = (int)cell.OwningRow.Cells[3].Value;
									success = true;
								}
								break;
							}
						case "qty":
							{
								if (isValueNum)
								{
									columnName = currColName;
									newValue = cell.Value.ToString();
									prodNum = (int)cell.OwningRow.Cells[3].Value;
									success = true;
								}
								break;
							}

					}
					if (success)
					{
						productTableAdapter.ClearBeforeFill = false;
						productTableAdapter.UpdateProductCell(miniBatchDataSet.Product, prodNum, columnName, newValue);
						success = false;
						prodNum = 0;
						newValue = "";
						columnName = "";
						displaySuccessMessage = true;
					}
					else
					{
						MessageBox.Show($"Could not parse {cell.EditedFormattedValue}");
					}
					
				}
				
			}
			if (displaySuccessMessage)
			{
				MessageBox.Show("Successfully saved.");
			}
			productTableAdapter.ClearBeforeFill = false;
			productTableAdapter.Fill(miniBatchDataSet.Product);
			edittedCells.Clear();
		}

		private void ProductCancelBtn_Click(object sender, EventArgs e)
		{
			productsDataGrid.CancelEdit();
		}

		private void ProductNumberLabel_Click(object sender, EventArgs e)
		{

		}

		private void ProductClearFieldsBtn_Click(object sender, EventArgs e)
		{
			if (productsDataGrid.SelectedRows.Count > 0)
			{
				productsDataGrid.BeginEdit(false);
				MiniBatchDataSet.ProductDataTable productDataset = miniBatchDataSet.Product;
				DataGridViewRow currentRow = productsDataGrid.SelectedRows[0];
				int productNumber = (int)currentRow.Cells[3].Value;
				for (int i = 0; i < currentRow.Cells.Count; i++)
				{
					DataGridViewCell cell = currentRow.Cells[i];
					string columnName = cell.OwningColumn.HeaderText.ToLower();
					
					if (!cell.ReadOnly &&
						cell.Value != null)
					{
						productTableAdapter.ClearBeforeFill = false;
						switch (cell.ValueType.Name.ToLower())
						{
							case "decimal":
							case "int32":
							case "double":
								cell.Value = 0;
								productTableAdapter.UpdateProductCell(productDataset, productNumber, columnName, "");
								break;
							case "string":
								cell.Value = "";
								productTableAdapter.UpdateProductCell(productDataset, productNumber, columnName, "");
								break;
							default:
								MessageBox.Show($"Could not clear values for {cell.OwningColumn.HeaderText} column type: {cell.ValueType.Name} | Did not update database", "ERROR!");
								break;
						}
						
					}
					else if (cell.ReadOnly)
					{
						i += 1;
						Console.WriteLine($"Skipped Cell {cell.OwningColumn.HeaderText}");
					}
				}
			}
			productTableAdapter.ClearBeforeFill = false;
			productTableAdapter.Fill(miniBatchDataSet.Product);
		}

		private void Creation_TimeLabel_Click(object sender, EventArgs e)
		{

		}

		private void Creation_DeliveryCostTextBox_TextChanged(object sender, EventArgs e)
		{

		}

	}
}

