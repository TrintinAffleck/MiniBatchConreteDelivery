namespace MiniBatchConreteDelivery
{
	partial class TransactionSystemForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.openReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.LookupByGroupBox = new System.Windows.Forms.GroupBox();
			this.ClearAllFieldsBtn1 = new System.Windows.Forms.Button();
			this.LookupSearchBtn = new System.Windows.Forms.Button();
			this.InvoiceOrdersGroupBox = new System.Windows.Forms.GroupBox();
			this.InvoiceNumberComboBox = new System.Windows.Forms.ComboBox();
			this.OrderNumberComboBox = new System.Windows.Forms.ComboBox();
			this.OrderNumberLabel = new System.Windows.Forms.Label();
			this.InvoiceNumberLabel = new System.Windows.Forms.Label();
			this.ProductsGroupBox = new System.Windows.Forms.GroupBox();
			this.ProductNumberComboBox = new System.Windows.Forms.ComboBox();
			this.ProductNumberLabel = new System.Windows.Forms.Label();
			this.CustomerGroupBox = new System.Windows.Forms.GroupBox();
			this.PhoneNumberTextBox = new System.Windows.Forms.MaskedTextBox();
			this.PhoneNumberLabel = new System.Windows.Forms.Label();
			this.NameLabel = new System.Windows.Forms.Label();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.CustomerListGroupBox = new System.Windows.Forms.GroupBox();
			this.CustomerListDataGrid = new System.Windows.Forms.DataGridView();
			this.customerNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.balanceOwingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.miniBatchDataSet = new MiniBatchConreteDelivery.MiniBatchDataSet();
			this.CustomerListSaveBtn = new System.Windows.Forms.Button();
			this.CustomerListEditBtn = new System.Windows.Forms.Button();
			this.CustomerListClearFieldsBtn = new System.Windows.Forms.Button();
			this.CustomerListCancelBtn = new System.Windows.Forms.Button();
			this.HistoryGroupBox = new System.Windows.Forms.GroupBox();
			this.InvoiceHistorySaveBtn = new System.Windows.Forms.Button();
			this.InvoiceHistoryDataGrid = new System.Windows.Forms.DataGridView();
			this.invoiceNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dueDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deliveryCostDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.discountAmtDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.InvoiceHistoryEditBtn = new System.Windows.Forms.Button();
			this.InvoiceHistoryClearFieldsBtn = new System.Windows.Forms.Button();
			this.InvoiceHistoryCancelBtn = new System.Windows.Forms.Button();
			this.ProductsOnOrderGroupBox = new System.Windows.Forms.GroupBox();
			this.ProductsSaveBtn = new System.Windows.Forms.Button();
			this.productsDataGrid = new System.Windows.Forms.DataGridView();
			this.itemCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reOrderQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unitOfMeassureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sellPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.invoiceNumberDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderNumberDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ProductsEditBtn = new System.Windows.Forms.Button();
			this.ProductsClearFieldsBtn = new System.Windows.Forms.Button();
			this.ProductsCancelBtn = new System.Windows.Forms.Button();
			this.invoiceNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deliveryCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.discountAmtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CreateOrderInvoiceGroupBox = new System.Windows.Forms.GroupBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.Creation_ProductsPurchasedLabel = new System.Windows.Forms.Label();
			this.InvoiceGroupBox = new System.Windows.Forms.GroupBox();
			this.Creation_InvoiceNumberComboBox = new System.Windows.Forms.ComboBox();
			this.Creation_DateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.Creation_InvoiceNumberLabel = new System.Windows.Forms.Label();
			this.Creation_DueDateLabel = new System.Windows.Forms.Label();
			this.Creation_ProductNumberLabel = new System.Windows.Forms.Label();
			this.CreationProductNumberDropdown = new System.Windows.Forms.ComboBox();
			this.CustomerGroupBox2 = new System.Windows.Forms.GroupBox();
			this.Creation_DiscountAmtTextBox = new System.Windows.Forms.TextBox();
			this.Creation_DiscountAmtLabel = new System.Windows.Forms.Label();
			this.Creation_DeliveryCostTextBox = new System.Windows.Forms.TextBox();
			this.Creation_DeliveryCostLabel = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.Creation_CustomerNumberLabel = new System.Windows.Forms.Label();
			this.OrderInfoGroupBox = new System.Windows.Forms.GroupBox();
			this.PmtMtdComboBox = new System.Windows.Forms.ComboBox();
			this.Creation_PmtMtdLabel = new System.Windows.Forms.Label();
			this.Creation_OrderDatePIcker = new System.Windows.Forms.DateTimePicker();
			this.Creation_TimePickerBox = new System.Windows.Forms.DateTimePicker();
			this.Creation_OrderNumberTextBox = new System.Windows.Forms.TextBox();
			this.Creation_TimeLabel = new System.Windows.Forms.Label();
			this.Creation_OrderNumberLabel = new System.Windows.Forms.Label();
			this.Creation_OrderDateLabel = new System.Windows.Forms.Label();
			this.customerTableAdapter = new MiniBatchConreteDelivery.MiniBatchDataSetTableAdapters.CustomerTableAdapter();
			this.tableAdapterManager1 = new MiniBatchConreteDelivery.MiniBatchDataSetTableAdapters.TableAdapterManager();
			this.invoiceTableAdapter = new MiniBatchConreteDelivery.MiniBatchDataSetTableAdapters.InvoiceTableAdapter();
			this.productTableAdapter = new MiniBatchConreteDelivery.MiniBatchDataSetTableAdapters.ProductTableAdapter();
			this.menuStrip1.SuspendLayout();
			this.LookupByGroupBox.SuspendLayout();
			this.InvoiceOrdersGroupBox.SuspendLayout();
			this.ProductsGroupBox.SuspendLayout();
			this.CustomerGroupBox.SuspendLayout();
			this.CustomerListGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CustomerListDataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.miniBatchDataSet)).BeginInit();
			this.HistoryGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.InvoiceHistoryDataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
			this.ProductsOnOrderGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
			this.CreateOrderInvoiceGroupBox.SuspendLayout();
			this.InvoiceGroupBox.SuspendLayout();
			this.CustomerGroupBox2.SuspendLayout();
			this.OrderInfoGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openReportToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
			this.menuStrip1.Size = new System.Drawing.Size(1057, 25);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// openReportToolStripMenuItem
			// 
			this.openReportToolStripMenuItem.Name = "openReportToolStripMenuItem";
			this.openReportToolStripMenuItem.Size = new System.Drawing.Size(86, 19);
			this.openReportToolStripMenuItem.Text = "Open Report";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(407, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(215, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Transaction System";
			this.label1.Click += new System.EventHandler(this.HeaderLabel_Click);
			// 
			// LookupByGroupBox
			// 
			this.LookupByGroupBox.Controls.Add(this.ClearAllFieldsBtn1);
			this.LookupByGroupBox.Controls.Add(this.LookupSearchBtn);
			this.LookupByGroupBox.Controls.Add(this.InvoiceOrdersGroupBox);
			this.LookupByGroupBox.Controls.Add(this.ProductsGroupBox);
			this.LookupByGroupBox.Controls.Add(this.CustomerGroupBox);
			this.LookupByGroupBox.Location = new System.Drawing.Point(20, 48);
			this.LookupByGroupBox.Margin = new System.Windows.Forms.Padding(4, 0, 0, 4);
			this.LookupByGroupBox.Name = "LookupByGroupBox";
			this.LookupByGroupBox.Padding = new System.Windows.Forms.Padding(4);
			this.LookupByGroupBox.Size = new System.Drawing.Size(1025, 208);
			this.LookupByGroupBox.TabIndex = 1;
			this.LookupByGroupBox.TabStop = false;
			this.LookupByGroupBox.Text = "Lookup By";
			this.LookupByGroupBox.Enter += new System.EventHandler(this.LookUpGroupBox_Enter);
			// 
			// ClearAllFieldsBtn1
			// 
			this.ClearAllFieldsBtn1.Location = new System.Drawing.Point(625, 146);
			this.ClearAllFieldsBtn1.Name = "ClearAllFieldsBtn1";
			this.ClearAllFieldsBtn1.Size = new System.Drawing.Size(100, 30);
			this.ClearAllFieldsBtn1.TabIndex = 6;
			this.ClearAllFieldsBtn1.Text = "Clear All Fields";
			this.ClearAllFieldsBtn1.UseVisualStyleBackColor = true;
			this.ClearAllFieldsBtn1.Click += new System.EventHandler(this.ClearAllFieldsBtn1_Click);
			// 
			// LookupSearchBtn
			// 
			this.LookupSearchBtn.Location = new System.Drawing.Point(765, 146);
			this.LookupSearchBtn.Margin = new System.Windows.Forms.Padding(4);
			this.LookupSearchBtn.Name = "LookupSearchBtn";
			this.LookupSearchBtn.Size = new System.Drawing.Size(100, 30);
			this.LookupSearchBtn.TabIndex = 6;
			this.LookupSearchBtn.Text = "Search";
			this.LookupSearchBtn.UseVisualStyleBackColor = true;
			this.LookupSearchBtn.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// InvoiceOrdersGroupBox
			// 
			this.InvoiceOrdersGroupBox.Controls.Add(this.InvoiceNumberComboBox);
			this.InvoiceOrdersGroupBox.Controls.Add(this.OrderNumberComboBox);
			this.InvoiceOrdersGroupBox.Controls.Add(this.OrderNumberLabel);
			this.InvoiceOrdersGroupBox.Controls.Add(this.InvoiceNumberLabel);
			this.InvoiceOrdersGroupBox.Location = new System.Drawing.Point(512, 18);
			this.InvoiceOrdersGroupBox.Margin = new System.Windows.Forms.Padding(4);
			this.InvoiceOrdersGroupBox.Name = "InvoiceOrdersGroupBox";
			this.InvoiceOrdersGroupBox.Padding = new System.Windows.Forms.Padding(4);
			this.InvoiceOrdersGroupBox.Size = new System.Drawing.Size(499, 100);
			this.InvoiceOrdersGroupBox.TabIndex = 4;
			this.InvoiceOrdersGroupBox.TabStop = false;
			this.InvoiceOrdersGroupBox.Text = "Invoice/Orders";
			// 
			// InvoiceNumberComboBox
			// 
			this.InvoiceNumberComboBox.FormattingEnabled = true;
			this.InvoiceNumberComboBox.Location = new System.Drawing.Point(128, 23);
			this.InvoiceNumberComboBox.Margin = new System.Windows.Forms.Padding(4);
			this.InvoiceNumberComboBox.Name = "InvoiceNumberComboBox";
			this.InvoiceNumberComboBox.Size = new System.Drawing.Size(339, 25);
			this.InvoiceNumberComboBox.TabIndex = 4;
			// 
			// OrderNumberComboBox
			// 
			this.OrderNumberComboBox.FormattingEnabled = true;
			this.OrderNumberComboBox.Location = new System.Drawing.Point(128, 60);
			this.OrderNumberComboBox.Margin = new System.Windows.Forms.Padding(4);
			this.OrderNumberComboBox.Name = "OrderNumberComboBox";
			this.OrderNumberComboBox.Size = new System.Drawing.Size(339, 25);
			this.OrderNumberComboBox.TabIndex = 5;
			// 
			// OrderNumberLabel
			// 
			this.OrderNumberLabel.AutoSize = true;
			this.OrderNumberLabel.Location = new System.Drawing.Point(19, 63);
			this.OrderNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.OrderNumberLabel.Name = "OrderNumberLabel";
			this.OrderNumberLabel.Size = new System.Drawing.Size(106, 17);
			this.OrderNumberLabel.TabIndex = 3;
			this.OrderNumberLabel.Text = "Order Number:";
			// 
			// InvoiceNumberLabel
			// 
			this.InvoiceNumberLabel.AutoSize = true;
			this.InvoiceNumberLabel.Location = new System.Drawing.Point(10, 26);
			this.InvoiceNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.InvoiceNumberLabel.Name = "InvoiceNumberLabel";
			this.InvoiceNumberLabel.Size = new System.Drawing.Size(113, 17);
			this.InvoiceNumberLabel.TabIndex = 2;
			this.InvoiceNumberLabel.Text = "Invoice Number:";
			// 
			// ProductsGroupBox
			// 
			this.ProductsGroupBox.Controls.Add(this.ProductNumberComboBox);
			this.ProductsGroupBox.Controls.Add(this.ProductNumberLabel);
			this.ProductsGroupBox.Location = new System.Drawing.Point(8, 123);
			this.ProductsGroupBox.Margin = new System.Windows.Forms.Padding(4);
			this.ProductsGroupBox.Name = "ProductsGroupBox";
			this.ProductsGroupBox.Padding = new System.Windows.Forms.Padding(4);
			this.ProductsGroupBox.Size = new System.Drawing.Size(496, 71);
			this.ProductsGroupBox.TabIndex = 1;
			this.ProductsGroupBox.TabStop = false;
			this.ProductsGroupBox.Text = "Products";
			// 
			// ProductNumberComboBox
			// 
			this.ProductNumberComboBox.FormattingEnabled = true;
			this.ProductNumberComboBox.Location = new System.Drawing.Point(124, 26);
			this.ProductNumberComboBox.Margin = new System.Windows.Forms.Padding(4);
			this.ProductNumberComboBox.Name = "ProductNumberComboBox";
			this.ProductNumberComboBox.Size = new System.Drawing.Size(346, 25);
			this.ProductNumberComboBox.TabIndex = 3;
			// 
			// ProductNumberLabel
			// 
			this.ProductNumberLabel.AutoSize = true;
			this.ProductNumberLabel.Location = new System.Drawing.Point(4, 30);
			this.ProductNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ProductNumberLabel.Name = "ProductNumberLabel";
			this.ProductNumberLabel.Size = new System.Drawing.Size(119, 17);
			this.ProductNumberLabel.TabIndex = 2;
			this.ProductNumberLabel.Text = "Product Number:";
			this.ProductNumberLabel.Click += new System.EventHandler(this.ProductNumberLabel_Click);
			// 
			// CustomerGroupBox
			// 
			this.CustomerGroupBox.Controls.Add(this.PhoneNumberTextBox);
			this.CustomerGroupBox.Controls.Add(this.PhoneNumberLabel);
			this.CustomerGroupBox.Controls.Add(this.NameLabel);
			this.CustomerGroupBox.Controls.Add(this.NameTextBox);
			this.CustomerGroupBox.Location = new System.Drawing.Point(8, 18);
			this.CustomerGroupBox.Margin = new System.Windows.Forms.Padding(4);
			this.CustomerGroupBox.Name = "CustomerGroupBox";
			this.CustomerGroupBox.Padding = new System.Windows.Forms.Padding(4);
			this.CustomerGroupBox.Size = new System.Drawing.Size(496, 100);
			this.CustomerGroupBox.TabIndex = 0;
			this.CustomerGroupBox.TabStop = false;
			this.CustomerGroupBox.Text = "Customer";
			// 
			// PhoneNumberTextBox
			// 
			this.PhoneNumberTextBox.Location = new System.Drawing.Point(119, 59);
			this.PhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.PhoneNumberTextBox.Mask = "(999) 000-0000";
			this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
			this.PhoneNumberTextBox.Size = new System.Drawing.Size(351, 25);
			this.PhoneNumberTextBox.TabIndex = 2;
			// 
			// PhoneNumberLabel
			// 
			this.PhoneNumberLabel.AutoSize = true;
			this.PhoneNumberLabel.Location = new System.Drawing.Point(8, 62);
			this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.PhoneNumberLabel.Name = "PhoneNumberLabel";
			this.PhoneNumberLabel.Size = new System.Drawing.Size(110, 17);
			this.PhoneNumberLabel.TabIndex = 3;
			this.PhoneNumberLabel.Text = "Phone Number:";
			this.PhoneNumberLabel.Click += new System.EventHandler(this.LookupPhoneNumberLabel_Click);
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(66, 25);
			this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(51, 17);
			this.NameLabel.TabIndex = 2;
			this.NameLabel.Text = "Name:";
			this.NameLabel.Click += new System.EventHandler(this.LookupNameLabel_Click);
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(119, 25);
			this.NameTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(351, 25);
			this.NameTextBox.TabIndex = 0;
			this.NameTextBox.TextChanged += new System.EventHandler(this.LookupNameTextBox_TextChanged);
			// 
			// CustomerListGroupBox
			// 
			this.CustomerListGroupBox.Controls.Add(this.CustomerListDataGrid);
			this.CustomerListGroupBox.Controls.Add(this.CustomerListSaveBtn);
			this.CustomerListGroupBox.Controls.Add(this.CustomerListEditBtn);
			this.CustomerListGroupBox.Controls.Add(this.CustomerListClearFieldsBtn);
			this.CustomerListGroupBox.Controls.Add(this.CustomerListCancelBtn);
			this.CustomerListGroupBox.Location = new System.Drawing.Point(20, 263);
			this.CustomerListGroupBox.Name = "CustomerListGroupBox";
			this.CustomerListGroupBox.Size = new System.Drawing.Size(1025, 219);
			this.CustomerListGroupBox.TabIndex = 2;
			this.CustomerListGroupBox.TabStop = false;
			this.CustomerListGroupBox.Text = "Customer List";
			// 
			// CustomerListDataGrid
			// 
			this.CustomerListDataGrid.AutoGenerateColumns = false;
			this.CustomerListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.CustomerListDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.balanceOwingDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.orderNumberDataGridViewTextBoxColumn,
            this.addressNumberDataGridViewTextBoxColumn});
			this.CustomerListDataGrid.DataSource = this.customerBindingSource;
			this.CustomerListDataGrid.Location = new System.Drawing.Point(16, 24);
			this.CustomerListDataGrid.Name = "CustomerListDataGrid";
			this.CustomerListDataGrid.Size = new System.Drawing.Size(995, 150);
			this.CustomerListDataGrid.TabIndex = 10;
			this.CustomerListDataGrid.Leave += new System.EventHandler(this.CustomerListCancelBtn_Click);
			// 
			// customerNumberDataGridViewTextBoxColumn
			// 
			this.customerNumberDataGridViewTextBoxColumn.DataPropertyName = "CustomerNumber";
			this.customerNumberDataGridViewTextBoxColumn.HeaderText = "CustomerNumber";
			this.customerNumberDataGridViewTextBoxColumn.Name = "customerNumberDataGridViewTextBoxColumn";
			this.customerNumberDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// balanceOwingDataGridViewTextBoxColumn
			// 
			this.balanceOwingDataGridViewTextBoxColumn.DataPropertyName = "BalanceOwing";
			this.balanceOwingDataGridViewTextBoxColumn.HeaderText = "BalanceOwing";
			this.balanceOwingDataGridViewTextBoxColumn.Name = "balanceOwingDataGridViewTextBoxColumn";
			// 
			// phoneNumberDataGridViewTextBoxColumn
			// 
			this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
			this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
			this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
			// 
			// orderNumberDataGridViewTextBoxColumn
			// 
			this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
			this.orderNumberDataGridViewTextBoxColumn.HeaderText = "OrderNumber";
			this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
			// 
			// addressNumberDataGridViewTextBoxColumn
			// 
			this.addressNumberDataGridViewTextBoxColumn.DataPropertyName = "AddressNumber";
			this.addressNumberDataGridViewTextBoxColumn.HeaderText = "AddressNumber";
			this.addressNumberDataGridViewTextBoxColumn.Name = "addressNumberDataGridViewTextBoxColumn";
			// 
			// customerBindingSource
			// 
			this.customerBindingSource.DataMember = "Customer";
			this.customerBindingSource.DataSource = this.miniBatchDataSet;
			// 
			// miniBatchDataSet
			// 
			this.miniBatchDataSet.DataSetName = "MiniBatchDataSet";
			this.miniBatchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// CustomerListSaveBtn
			// 
			this.CustomerListSaveBtn.Location = new System.Drawing.Point(911, 180);
			this.CustomerListSaveBtn.Name = "CustomerListSaveBtn";
			this.CustomerListSaveBtn.Size = new System.Drawing.Size(100, 30);
			this.CustomerListSaveBtn.TabIndex = 9;
			this.CustomerListSaveBtn.Text = "Save";
			this.CustomerListSaveBtn.UseVisualStyleBackColor = true;
			// 
			// CustomerListEditBtn
			// 
			this.CustomerListEditBtn.Location = new System.Drawing.Point(805, 180);
			this.CustomerListEditBtn.Name = "CustomerListEditBtn";
			this.CustomerListEditBtn.Size = new System.Drawing.Size(100, 30);
			this.CustomerListEditBtn.TabIndex = 8;
			this.CustomerListEditBtn.Text = "Edit";
			this.CustomerListEditBtn.UseVisualStyleBackColor = true;
			this.CustomerListEditBtn.Click += new System.EventHandler(this.CustomerListEditBtn_Click);
			// 
			// CustomerListClearFieldsBtn
			// 
			this.CustomerListClearFieldsBtn.Location = new System.Drawing.Point(630, 180);
			this.CustomerListClearFieldsBtn.Name = "CustomerListClearFieldsBtn";
			this.CustomerListClearFieldsBtn.Size = new System.Drawing.Size(169, 30);
			this.CustomerListClearFieldsBtn.TabIndex = 7;
			this.CustomerListClearFieldsBtn.Text = "Clear Selected Fields";
			this.CustomerListClearFieldsBtn.UseVisualStyleBackColor = true;
			this.CustomerListClearFieldsBtn.Click += new System.EventHandler(this.TransactionSystemForm_Load);
			// 
			// CustomerListCancelBtn
			// 
			this.CustomerListCancelBtn.Location = new System.Drawing.Point(524, 180);
			this.CustomerListCancelBtn.Name = "CustomerListCancelBtn";
			this.CustomerListCancelBtn.Size = new System.Drawing.Size(100, 30);
			this.CustomerListCancelBtn.TabIndex = 6;
			this.CustomerListCancelBtn.Text = "Cancel";
			this.CustomerListCancelBtn.UseVisualStyleBackColor = true;
			this.CustomerListCancelBtn.Click += new System.EventHandler(this.CustomerListCancelBtn_Click);
			// 
			// HistoryGroupBox
			// 
			this.HistoryGroupBox.Controls.Add(this.InvoiceHistorySaveBtn);
			this.HistoryGroupBox.Controls.Add(this.InvoiceHistoryDataGrid);
			this.HistoryGroupBox.Controls.Add(this.InvoiceHistoryEditBtn);
			this.HistoryGroupBox.Controls.Add(this.InvoiceHistoryClearFieldsBtn);
			this.HistoryGroupBox.Controls.Add(this.InvoiceHistoryCancelBtn);
			this.HistoryGroupBox.Location = new System.Drawing.Point(19, 488);
			this.HistoryGroupBox.Name = "HistoryGroupBox";
			this.HistoryGroupBox.Size = new System.Drawing.Size(1025, 214);
			this.HistoryGroupBox.TabIndex = 3;
			this.HistoryGroupBox.TabStop = false;
			this.HistoryGroupBox.Text = "Invoice History";
			this.HistoryGroupBox.Enter += new System.EventHandler(this.InvoiceHistoryGroupBox_Enter);
			// 
			// InvoiceHistorySaveBtn
			// 
			this.InvoiceHistorySaveBtn.Location = new System.Drawing.Point(912, 172);
			this.InvoiceHistorySaveBtn.Name = "InvoiceHistorySaveBtn";
			this.InvoiceHistorySaveBtn.Size = new System.Drawing.Size(100, 30);
			this.InvoiceHistorySaveBtn.TabIndex = 13;
			this.InvoiceHistorySaveBtn.Text = "Save";
			this.InvoiceHistorySaveBtn.UseVisualStyleBackColor = true;
			this.InvoiceHistorySaveBtn.Click += new System.EventHandler(this.InvoiceHistorySaveBtn_Click);
			// 
			// InvoiceHistoryDataGrid
			// 
			this.InvoiceHistoryDataGrid.AutoGenerateColumns = false;
			this.InvoiceHistoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.InvoiceHistoryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceNumberDataGridViewTextBoxColumn1,
            this.dueDateDataGridViewTextBoxColumn1,
            this.deliveryCostDataGridViewTextBoxColumn1,
            this.discountAmtDataGridViewTextBoxColumn1,
            this.orderNumberDataGridViewTextBoxColumn1,
            this.productNumberDataGridViewTextBoxColumn});
			this.InvoiceHistoryDataGrid.DataSource = this.invoiceBindingSource;
			this.InvoiceHistoryDataGrid.Location = new System.Drawing.Point(15, 24);
			this.InvoiceHistoryDataGrid.Name = "InvoiceHistoryDataGrid";
			this.InvoiceHistoryDataGrid.Size = new System.Drawing.Size(997, 142);
			this.InvoiceHistoryDataGrid.TabIndex = 0;
			this.InvoiceHistoryDataGrid.Leave += new System.EventHandler(this.InvoiceHistoryCancelBtn_Click);
			// 
			// invoiceNumberDataGridViewTextBoxColumn1
			// 
			this.invoiceNumberDataGridViewTextBoxColumn1.DataPropertyName = "InvoiceNumber";
			this.invoiceNumberDataGridViewTextBoxColumn1.HeaderText = "InvoiceNumber";
			this.invoiceNumberDataGridViewTextBoxColumn1.Name = "invoiceNumberDataGridViewTextBoxColumn1";
			this.invoiceNumberDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dueDateDataGridViewTextBoxColumn1
			// 
			this.dueDateDataGridViewTextBoxColumn1.DataPropertyName = "Due_Date";
			this.dueDateDataGridViewTextBoxColumn1.HeaderText = "Due_Date";
			this.dueDateDataGridViewTextBoxColumn1.Name = "dueDateDataGridViewTextBoxColumn1";
			// 
			// deliveryCostDataGridViewTextBoxColumn1
			// 
			this.deliveryCostDataGridViewTextBoxColumn1.DataPropertyName = "DeliveryCost";
			this.deliveryCostDataGridViewTextBoxColumn1.HeaderText = "DeliveryCost";
			this.deliveryCostDataGridViewTextBoxColumn1.Name = "deliveryCostDataGridViewTextBoxColumn1";
			// 
			// discountAmtDataGridViewTextBoxColumn1
			// 
			this.discountAmtDataGridViewTextBoxColumn1.DataPropertyName = "DiscountAmt";
			this.discountAmtDataGridViewTextBoxColumn1.HeaderText = "DiscountAmt";
			this.discountAmtDataGridViewTextBoxColumn1.Name = "discountAmtDataGridViewTextBoxColumn1";
			// 
			// orderNumberDataGridViewTextBoxColumn1
			// 
			this.orderNumberDataGridViewTextBoxColumn1.DataPropertyName = "OrderNumber";
			this.orderNumberDataGridViewTextBoxColumn1.HeaderText = "OrderNumber";
			this.orderNumberDataGridViewTextBoxColumn1.Name = "orderNumberDataGridViewTextBoxColumn1";
			// 
			// productNumberDataGridViewTextBoxColumn
			// 
			this.productNumberDataGridViewTextBoxColumn.DataPropertyName = "ProductNumber";
			this.productNumberDataGridViewTextBoxColumn.HeaderText = "ProductNumber";
			this.productNumberDataGridViewTextBoxColumn.Name = "productNumberDataGridViewTextBoxColumn";
			// 
			// invoiceBindingSource
			// 
			this.invoiceBindingSource.DataMember = "Invoice";
			this.invoiceBindingSource.DataSource = this.miniBatchDataSet;
			// 
			// InvoiceHistoryEditBtn
			// 
			this.InvoiceHistoryEditBtn.Location = new System.Drawing.Point(806, 172);
			this.InvoiceHistoryEditBtn.Name = "InvoiceHistoryEditBtn";
			this.InvoiceHistoryEditBtn.Size = new System.Drawing.Size(100, 30);
			this.InvoiceHistoryEditBtn.TabIndex = 12;
			this.InvoiceHistoryEditBtn.Text = "Edit";
			this.InvoiceHistoryEditBtn.UseVisualStyleBackColor = true;
			this.InvoiceHistoryEditBtn.Click += new System.EventHandler(this.InvoiceHistoryEditBtn_Click);
			// 
			// InvoiceHistoryClearFieldsBtn
			// 
			this.InvoiceHistoryClearFieldsBtn.Location = new System.Drawing.Point(631, 172);
			this.InvoiceHistoryClearFieldsBtn.Name = "InvoiceHistoryClearFieldsBtn";
			this.InvoiceHistoryClearFieldsBtn.Size = new System.Drawing.Size(169, 30);
			this.InvoiceHistoryClearFieldsBtn.TabIndex = 11;
			this.InvoiceHistoryClearFieldsBtn.Text = "Clear Selected Fields";
			this.InvoiceHistoryClearFieldsBtn.UseVisualStyleBackColor = true;
			this.InvoiceHistoryClearFieldsBtn.Click += new System.EventHandler(this.InvoiceHistoryClearFieldsBtn_Click);
			// 
			// InvoiceHistoryCancelBtn
			// 
			this.InvoiceHistoryCancelBtn.Location = new System.Drawing.Point(525, 172);
			this.InvoiceHistoryCancelBtn.Name = "InvoiceHistoryCancelBtn";
			this.InvoiceHistoryCancelBtn.Size = new System.Drawing.Size(100, 30);
			this.InvoiceHistoryCancelBtn.TabIndex = 10;
			this.InvoiceHistoryCancelBtn.Text = "Cancel";
			this.InvoiceHistoryCancelBtn.UseVisualStyleBackColor = true;
			this.InvoiceHistoryCancelBtn.Click += new System.EventHandler(this.InvoiceHistoryCancelBtn_Click);
			// 
			// ProductsOnOrderGroupBox
			// 
			this.ProductsOnOrderGroupBox.Controls.Add(this.ProductsSaveBtn);
			this.ProductsOnOrderGroupBox.Controls.Add(this.productsDataGrid);
			this.ProductsOnOrderGroupBox.Controls.Add(this.ProductsEditBtn);
			this.ProductsOnOrderGroupBox.Controls.Add(this.ProductsClearFieldsBtn);
			this.ProductsOnOrderGroupBox.Controls.Add(this.ProductsCancelBtn);
			this.ProductsOnOrderGroupBox.Location = new System.Drawing.Point(19, 708);
			this.ProductsOnOrderGroupBox.Name = "ProductsOnOrderGroupBox";
			this.ProductsOnOrderGroupBox.Size = new System.Drawing.Size(1025, 227);
			this.ProductsOnOrderGroupBox.TabIndex = 4;
			this.ProductsOnOrderGroupBox.TabStop = false;
			this.ProductsOnOrderGroupBox.Text = "Products On Order";
			// 
			// ProductsSaveBtn
			// 
			this.ProductsSaveBtn.Location = new System.Drawing.Point(912, 188);
			this.ProductsSaveBtn.Name = "ProductsSaveBtn";
			this.ProductsSaveBtn.Size = new System.Drawing.Size(100, 30);
			this.ProductsSaveBtn.TabIndex = 17;
			this.ProductsSaveBtn.Text = "Save";
			this.ProductsSaveBtn.UseVisualStyleBackColor = true;
			this.ProductsSaveBtn.Click += new System.EventHandler(this.ProductListSaveBtn_Click);
			// 
			// productsDataGrid
			// 
			this.productsDataGrid.AutoGenerateColumns = false;
			this.productsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.productsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemCodeDataGridViewTextBoxColumn,
            this.productDescriptionDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.productNumberDataGridViewTextBoxColumn1,
            this.reOrderQuantityDataGridViewTextBoxColumn,
            this.unitOfMeassureDataGridViewTextBoxColumn,
            this.sellPriceDataGridViewTextBoxColumn,
            this.invoiceNumberDataGridViewTextBoxColumn2,
            this.orderNumberDataGridViewTextBoxColumn2,
            this.qtyDataGridViewTextBoxColumn});
			this.productsDataGrid.DataSource = this.productBindingSource;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.NullValue = null;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.productsDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
			this.productsDataGrid.Location = new System.Drawing.Point(11, 20);
			this.productsDataGrid.MultiSelect = false;
			this.productsDataGrid.Name = "productsDataGrid";
			this.productsDataGrid.RowTemplate.DefaultCellStyle.NullValue = null;
			this.productsDataGrid.Size = new System.Drawing.Size(1001, 162);
			this.productsDataGrid.TabIndex = 0;
			this.productsDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellEdit_DoubleClick);
			this.productsDataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsListCell_Changed);
			this.productsDataGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridView1_DataError);
			this.productsDataGrid.Leave += new System.EventHandler(this.ProductCancelBtn_Click);
			// 
			// itemCodeDataGridViewTextBoxColumn
			// 
			this.itemCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.itemCodeDataGridViewTextBoxColumn.DataPropertyName = "ItemCode";
			this.itemCodeDataGridViewTextBoxColumn.HeaderText = "ItemCode";
			this.itemCodeDataGridViewTextBoxColumn.Name = "itemCodeDataGridViewTextBoxColumn";
			this.itemCodeDataGridViewTextBoxColumn.Width = 96;
			// 
			// productDescriptionDataGridViewTextBoxColumn
			// 
			this.productDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.productDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProductDescription";
			this.productDescriptionDataGridViewTextBoxColumn.HeaderText = "ProductDescription";
			this.productDescriptionDataGridViewTextBoxColumn.Name = "productDescriptionDataGridViewTextBoxColumn";
			this.productDescriptionDataGridViewTextBoxColumn.Width = 158;
			// 
			// valueDataGridViewTextBoxColumn
			// 
			this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
			this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
			this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
			this.valueDataGridViewTextBoxColumn.Width = 75;
			// 
			// productNumberDataGridViewTextBoxColumn1
			// 
			this.productNumberDataGridViewTextBoxColumn1.DataPropertyName = "ProductNumber";
			this.productNumberDataGridViewTextBoxColumn1.HeaderText = "ProductNumber";
			this.productNumberDataGridViewTextBoxColumn1.Name = "productNumberDataGridViewTextBoxColumn1";
			this.productNumberDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// reOrderQuantityDataGridViewTextBoxColumn
			// 
			this.reOrderQuantityDataGridViewTextBoxColumn.DataPropertyName = "ReOrderQuantity";
			this.reOrderQuantityDataGridViewTextBoxColumn.HeaderText = "ReOrderQuantity";
			this.reOrderQuantityDataGridViewTextBoxColumn.Name = "reOrderQuantityDataGridViewTextBoxColumn";
			// 
			// unitOfMeassureDataGridViewTextBoxColumn
			// 
			this.unitOfMeassureDataGridViewTextBoxColumn.DataPropertyName = "UnitOfMeassure";
			this.unitOfMeassureDataGridViewTextBoxColumn.HeaderText = "UnitOfMeassure";
			this.unitOfMeassureDataGridViewTextBoxColumn.Name = "unitOfMeassureDataGridViewTextBoxColumn";
			// 
			// sellPriceDataGridViewTextBoxColumn
			// 
			this.sellPriceDataGridViewTextBoxColumn.DataPropertyName = "SellPrice";
			this.sellPriceDataGridViewTextBoxColumn.HeaderText = "SellPrice";
			this.sellPriceDataGridViewTextBoxColumn.Name = "sellPriceDataGridViewTextBoxColumn";
			this.sellPriceDataGridViewTextBoxColumn.Width = 80;
			// 
			// invoiceNumberDataGridViewTextBoxColumn2
			// 
			this.invoiceNumberDataGridViewTextBoxColumn2.DataPropertyName = "InvoiceNumber";
			this.invoiceNumberDataGridViewTextBoxColumn2.HeaderText = "InvoiceNumber";
			this.invoiceNumberDataGridViewTextBoxColumn2.Name = "invoiceNumberDataGridViewTextBoxColumn2";
			this.invoiceNumberDataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// orderNumberDataGridViewTextBoxColumn2
			// 
			this.orderNumberDataGridViewTextBoxColumn2.DataPropertyName = "OrderNumber";
			this.orderNumberDataGridViewTextBoxColumn2.HeaderText = "OrderNumber";
			this.orderNumberDataGridViewTextBoxColumn2.Name = "orderNumberDataGridViewTextBoxColumn2";
			this.orderNumberDataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// qtyDataGridViewTextBoxColumn
			// 
			this.qtyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
			this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
			this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
			this.qtyDataGridViewTextBoxColumn.Width = 56;
			// 
			// productBindingSource
			// 
			this.productBindingSource.DataMember = "Product";
			this.productBindingSource.DataSource = this.miniBatchDataSet;
			// 
			// ProductsEditBtn
			// 
			this.ProductsEditBtn.Location = new System.Drawing.Point(806, 188);
			this.ProductsEditBtn.Name = "ProductsEditBtn";
			this.ProductsEditBtn.Size = new System.Drawing.Size(100, 30);
			this.ProductsEditBtn.TabIndex = 16;
			this.ProductsEditBtn.Text = "Edit";
			this.ProductsEditBtn.UseVisualStyleBackColor = true;
			this.ProductsEditBtn.Click += new System.EventHandler(this.ProductListEditBtn_Click);
			// 
			// ProductsClearFieldsBtn
			// 
			this.ProductsClearFieldsBtn.Location = new System.Drawing.Point(631, 188);
			this.ProductsClearFieldsBtn.Name = "ProductsClearFieldsBtn";
			this.ProductsClearFieldsBtn.Size = new System.Drawing.Size(169, 30);
			this.ProductsClearFieldsBtn.TabIndex = 15;
			this.ProductsClearFieldsBtn.Text = "Clear Selected Fields";
			this.ProductsClearFieldsBtn.UseVisualStyleBackColor = true;
			this.ProductsClearFieldsBtn.Click += new System.EventHandler(this.ProductClearFieldsBtn_Click);
			// 
			// ProductsCancelBtn
			// 
			this.ProductsCancelBtn.Location = new System.Drawing.Point(525, 188);
			this.ProductsCancelBtn.Name = "ProductsCancelBtn";
			this.ProductsCancelBtn.Size = new System.Drawing.Size(100, 30);
			this.ProductsCancelBtn.TabIndex = 14;
			this.ProductsCancelBtn.Text = "Cancel";
			this.ProductsCancelBtn.UseVisualStyleBackColor = true;
			this.ProductsCancelBtn.Click += new System.EventHandler(this.ProductCancelBtn_Click);
			// 
			// invoiceNumberDataGridViewTextBoxColumn
			// 
			this.invoiceNumberDataGridViewTextBoxColumn.DataPropertyName = "InvoiceNumber";
			this.invoiceNumberDataGridViewTextBoxColumn.HeaderText = "InvoiceNumber";
			this.invoiceNumberDataGridViewTextBoxColumn.MinimumWidth = 150;
			this.invoiceNumberDataGridViewTextBoxColumn.Name = "invoiceNumberDataGridViewTextBoxColumn";
			this.invoiceNumberDataGridViewTextBoxColumn.Width = 150;
			// 
			// dueDateDataGridViewTextBoxColumn
			// 
			this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "Due_Date";
			this.dueDateDataGridViewTextBoxColumn.HeaderText = "Due_Date";
			this.dueDateDataGridViewTextBoxColumn.MinimumWidth = 150;
			this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
			this.dueDateDataGridViewTextBoxColumn.Width = 150;
			// 
			// deliveryCostDataGridViewTextBoxColumn
			// 
			this.deliveryCostDataGridViewTextBoxColumn.DataPropertyName = "DeliveryCost";
			this.deliveryCostDataGridViewTextBoxColumn.HeaderText = "DeliveryCost";
			this.deliveryCostDataGridViewTextBoxColumn.MinimumWidth = 150;
			this.deliveryCostDataGridViewTextBoxColumn.Name = "deliveryCostDataGridViewTextBoxColumn";
			this.deliveryCostDataGridViewTextBoxColumn.Width = 150;
			// 
			// discountAmtDataGridViewTextBoxColumn
			// 
			this.discountAmtDataGridViewTextBoxColumn.DataPropertyName = "DiscountAmt";
			this.discountAmtDataGridViewTextBoxColumn.HeaderText = "DiscountAmt";
			this.discountAmtDataGridViewTextBoxColumn.MinimumWidth = 150;
			this.discountAmtDataGridViewTextBoxColumn.Name = "discountAmtDataGridViewTextBoxColumn";
			this.discountAmtDataGridViewTextBoxColumn.Width = 150;
			// 
			// CreateOrderInvoiceGroupBox
			// 
			this.CreateOrderInvoiceGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.CreateOrderInvoiceGroupBox.Controls.Add(this.listBox1);
			this.CreateOrderInvoiceGroupBox.Controls.Add(this.Creation_ProductsPurchasedLabel);
			this.CreateOrderInvoiceGroupBox.Controls.Add(this.InvoiceGroupBox);
			this.CreateOrderInvoiceGroupBox.Controls.Add(this.CustomerGroupBox2);
			this.CreateOrderInvoiceGroupBox.Controls.Add(this.OrderInfoGroupBox);
			this.CreateOrderInvoiceGroupBox.Location = new System.Drawing.Point(20, 941);
			this.CreateOrderInvoiceGroupBox.Name = "CreateOrderInvoiceGroupBox";
			this.CreateOrderInvoiceGroupBox.Size = new System.Drawing.Size(1025, 284);
			this.CreateOrderInvoiceGroupBox.TabIndex = 5;
			this.CreateOrderInvoiceGroupBox.TabStop = false;
			this.CreateOrderInvoiceGroupBox.Text = "Create Order & Invoice";
			this.CreateOrderInvoiceGroupBox.Enter += new System.EventHandler(this.CreationGroupBox_Enter);
			// 
			// listBox1
			// 
			this.listBox1.DataSource = this.productBindingSource;
			this.listBox1.DisplayMember = "ProductDescription";
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 17;
			this.listBox1.Location = new System.Drawing.Point(504, 175);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(261, 89);
			this.listBox1.TabIndex = 4;
			this.listBox1.ValueMember = "ProductDescription";
			// 
			// Creation_ProductsPurchasedLabel
			// 
			this.Creation_ProductsPurchasedLabel.AutoSize = true;
			this.Creation_ProductsPurchasedLabel.Location = new System.Drawing.Point(353, 178);
			this.Creation_ProductsPurchasedLabel.Name = "Creation_ProductsPurchasedLabel";
			this.Creation_ProductsPurchasedLabel.Size = new System.Drawing.Size(146, 17);
			this.Creation_ProductsPurchasedLabel.TabIndex = 3;
			this.Creation_ProductsPurchasedLabel.Text = "Products Purchased:";
			// 
			// InvoiceGroupBox
			// 
			this.InvoiceGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.InvoiceGroupBox.Controls.Add(this.Creation_InvoiceNumberComboBox);
			this.InvoiceGroupBox.Controls.Add(this.Creation_DateTimePicker);
			this.InvoiceGroupBox.Controls.Add(this.Creation_InvoiceNumberLabel);
			this.InvoiceGroupBox.Controls.Add(this.Creation_DueDateLabel);
			this.InvoiceGroupBox.Controls.Add(this.Creation_ProductNumberLabel);
			this.InvoiceGroupBox.Controls.Add(this.CreationProductNumberDropdown);
			this.InvoiceGroupBox.Location = new System.Drawing.Point(688, 24);
			this.InvoiceGroupBox.Name = "InvoiceGroupBox";
			this.InvoiceGroupBox.Size = new System.Drawing.Size(325, 141);
			this.InvoiceGroupBox.TabIndex = 2;
			this.InvoiceGroupBox.TabStop = false;
			this.InvoiceGroupBox.Text = "Invoice";
			// 
			// Creation_InvoiceNumberComboBox
			// 
			this.Creation_InvoiceNumberComboBox.FormattingEnabled = true;
			this.Creation_InvoiceNumberComboBox.Items.AddRange(new object[] {
            "product1",
            "product2",
            "product3"});
			this.Creation_InvoiceNumberComboBox.Location = new System.Drawing.Point(134, 94);
			this.Creation_InvoiceNumberComboBox.Name = "Creation_InvoiceNumberComboBox";
			this.Creation_InvoiceNumberComboBox.Size = new System.Drawing.Size(171, 25);
			this.Creation_InvoiceNumberComboBox.TabIndex = 7;
			// 
			// Creation_DateTimePicker
			// 
			this.Creation_DateTimePicker.CustomFormat = "MM/dd/yyyy h:mm tt";
			this.Creation_DateTimePicker.Font = new System.Drawing.Font("Arial", 11.25F);
			this.Creation_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.Creation_DateTimePicker.Location = new System.Drawing.Point(134, 57);
			this.Creation_DateTimePicker.Name = "Creation_DateTimePicker";
			this.Creation_DateTimePicker.Size = new System.Drawing.Size(171, 25);
			this.Creation_DateTimePicker.TabIndex = 6;
			// 
			// Creation_InvoiceNumberLabel
			// 
			this.Creation_InvoiceNumberLabel.AutoSize = true;
			this.Creation_InvoiceNumberLabel.Location = new System.Drawing.Point(15, 97);
			this.Creation_InvoiceNumberLabel.Name = "Creation_InvoiceNumberLabel";
			this.Creation_InvoiceNumberLabel.Size = new System.Drawing.Size(113, 17);
			this.Creation_InvoiceNumberLabel.TabIndex = 5;
			this.Creation_InvoiceNumberLabel.Text = "Invoice Number:";
			this.Creation_InvoiceNumberLabel.Click += new System.EventHandler(this.Creation_InvoiceNumberLabel_Click);
			// 
			// Creation_DueDateLabel
			// 
			this.Creation_DueDateLabel.AutoSize = true;
			this.Creation_DueDateLabel.Location = new System.Drawing.Point(54, 61);
			this.Creation_DueDateLabel.Name = "Creation_DueDateLabel";
			this.Creation_DueDateLabel.Size = new System.Drawing.Size(74, 17);
			this.Creation_DueDateLabel.TabIndex = 4;
			this.Creation_DueDateLabel.Text = "Due Date:";
			this.Creation_DueDateLabel.Click += new System.EventHandler(this.Creation_DueDateLabel_Click);
			// 
			// Creation_ProductNumberLabel
			// 
			this.Creation_ProductNumberLabel.AutoSize = true;
			this.Creation_ProductNumberLabel.Location = new System.Drawing.Point(9, 26);
			this.Creation_ProductNumberLabel.Name = "Creation_ProductNumberLabel";
			this.Creation_ProductNumberLabel.Size = new System.Drawing.Size(119, 17);
			this.Creation_ProductNumberLabel.TabIndex = 3;
			this.Creation_ProductNumberLabel.Text = "Product Number:";
			this.Creation_ProductNumberLabel.Click += new System.EventHandler(this.Creation_ProductNumberLabel_Click);
			// 
			// CreationProductNumberDropdown
			// 
			this.CreationProductNumberDropdown.FormattingEnabled = true;
			this.CreationProductNumberDropdown.Location = new System.Drawing.Point(134, 23);
			this.CreationProductNumberDropdown.Name = "CreationProductNumberDropdown";
			this.CreationProductNumberDropdown.Size = new System.Drawing.Size(171, 25);
			this.CreationProductNumberDropdown.TabIndex = 3;
			this.CreationProductNumberDropdown.SelectedIndexChanged += new System.EventHandler(this.CreationProductNumberDropdown_SelectedIndexChanged);
			// 
			// CustomerGroupBox2
			// 
			this.CustomerGroupBox2.Controls.Add(this.Creation_DiscountAmtTextBox);
			this.CustomerGroupBox2.Controls.Add(this.Creation_DiscountAmtLabel);
			this.CustomerGroupBox2.Controls.Add(this.Creation_DeliveryCostTextBox);
			this.CustomerGroupBox2.Controls.Add(this.Creation_DeliveryCostLabel);
			this.CustomerGroupBox2.Controls.Add(this.textBox1);
			this.CustomerGroupBox2.Controls.Add(this.Creation_CustomerNumberLabel);
			this.CustomerGroupBox2.Location = new System.Drawing.Point(348, 24);
			this.CustomerGroupBox2.Name = "CustomerGroupBox2";
			this.CustomerGroupBox2.Size = new System.Drawing.Size(325, 141);
			this.CustomerGroupBox2.TabIndex = 1;
			this.CustomerGroupBox2.TabStop = false;
			this.CustomerGroupBox2.Text = "Customer";
			// 
			// Creation_DiscountAmtTextBox
			// 
			this.Creation_DiscountAmtTextBox.Location = new System.Drawing.Point(136, 102);
			this.Creation_DiscountAmtTextBox.Name = "Creation_DiscountAmtTextBox";
			this.Creation_DiscountAmtTextBox.Size = new System.Drawing.Size(172, 25);
			this.Creation_DiscountAmtTextBox.TabIndex = 5;
			this.Creation_DiscountAmtTextBox.Text = "0";
			// 
			// Creation_DiscountAmtLabel
			// 
			this.Creation_DiscountAmtLabel.AutoSize = true;
			this.Creation_DiscountAmtLabel.Location = new System.Drawing.Point(31, 105);
			this.Creation_DiscountAmtLabel.Name = "Creation_DiscountAmtLabel";
			this.Creation_DiscountAmtLabel.Size = new System.Drawing.Size(99, 17);
			this.Creation_DiscountAmtLabel.TabIndex = 4;
			this.Creation_DiscountAmtLabel.Text = "Discount Amt:";
			// 
			// Creation_DeliveryCostTextBox
			// 
			this.Creation_DeliveryCostTextBox.Location = new System.Drawing.Point(136, 64);
			this.Creation_DeliveryCostTextBox.Name = "Creation_DeliveryCostTextBox";
			this.Creation_DeliveryCostTextBox.Size = new System.Drawing.Size(172, 25);
			this.Creation_DeliveryCostTextBox.TabIndex = 3;
			this.Creation_DeliveryCostTextBox.Text = "0";
			this.Creation_DeliveryCostTextBox.TextChanged += new System.EventHandler(this.Creation_DeliveryCostTextBox_TextChanged);
			// 
			// Creation_DeliveryCostLabel
			// 
			this.Creation_DeliveryCostLabel.AutoSize = true;
			this.Creation_DeliveryCostLabel.Location = new System.Drawing.Point(33, 72);
			this.Creation_DeliveryCostLabel.Name = "Creation_DeliveryCostLabel";
			this.Creation_DeliveryCostLabel.Size = new System.Drawing.Size(99, 17);
			this.Creation_DeliveryCostLabel.TabIndex = 2;
			this.Creation_DeliveryCostLabel.Text = "Delivery Cost:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(136, 30);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(172, 25);
			this.textBox1.TabIndex = 1;
			// 
			// Creation_CustomerNumberLabel
			// 
			this.Creation_CustomerNumberLabel.AutoSize = true;
			this.Creation_CustomerNumberLabel.Location = new System.Drawing.Point(2, 33);
			this.Creation_CustomerNumberLabel.Name = "Creation_CustomerNumberLabel";
			this.Creation_CustomerNumberLabel.Size = new System.Drawing.Size(133, 17);
			this.Creation_CustomerNumberLabel.TabIndex = 0;
			this.Creation_CustomerNumberLabel.Text = "Customer Number:";
			// 
			// OrderInfoGroupBox
			// 
			this.OrderInfoGroupBox.Controls.Add(this.PmtMtdComboBox);
			this.OrderInfoGroupBox.Controls.Add(this.Creation_PmtMtdLabel);
			this.OrderInfoGroupBox.Controls.Add(this.Creation_OrderDatePIcker);
			this.OrderInfoGroupBox.Controls.Add(this.Creation_TimePickerBox);
			this.OrderInfoGroupBox.Controls.Add(this.Creation_OrderNumberTextBox);
			this.OrderInfoGroupBox.Controls.Add(this.Creation_TimeLabel);
			this.OrderInfoGroupBox.Controls.Add(this.Creation_OrderNumberLabel);
			this.OrderInfoGroupBox.Controls.Add(this.Creation_OrderDateLabel);
			this.OrderInfoGroupBox.Location = new System.Drawing.Point(8, 24);
			this.OrderInfoGroupBox.Name = "OrderInfoGroupBox";
			this.OrderInfoGroupBox.Size = new System.Drawing.Size(325, 228);
			this.OrderInfoGroupBox.TabIndex = 0;
			this.OrderInfoGroupBox.TabStop = false;
			this.OrderInfoGroupBox.Text = "Order Info";
			// 
			// PmtMtdComboBox
			// 
			this.PmtMtdComboBox.FormattingEnabled = true;
			this.PmtMtdComboBox.Items.AddRange(new object[] {
            "Visa",
            "Mastercard",
            "Debit",
            "Cash"});
			this.PmtMtdComboBox.Location = new System.Drawing.Point(135, 151);
			this.PmtMtdComboBox.Name = "PmtMtdComboBox";
			this.PmtMtdComboBox.Size = new System.Drawing.Size(174, 25);
			this.PmtMtdComboBox.TabIndex = 3;
			this.PmtMtdComboBox.Text = "Visa";
			// 
			// Creation_PmtMtdLabel
			// 
			this.Creation_PmtMtdLabel.AutoSize = true;
			this.Creation_PmtMtdLabel.Location = new System.Drawing.Point(8, 154);
			this.Creation_PmtMtdLabel.Name = "Creation_PmtMtdLabel";
			this.Creation_PmtMtdLabel.Size = new System.Drawing.Size(121, 17);
			this.Creation_PmtMtdLabel.TabIndex = 8;
			this.Creation_PmtMtdLabel.Text = "Payment Method:";
			// 
			// Creation_OrderDatePIcker
			// 
			this.Creation_OrderDatePIcker.CustomFormat = "MM/dd/yyyy h:mm tt";
			this.Creation_OrderDatePIcker.Font = new System.Drawing.Font("Arial", 11.25F);
			this.Creation_OrderDatePIcker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.Creation_OrderDatePIcker.Location = new System.Drawing.Point(121, 33);
			this.Creation_OrderDatePIcker.Name = "Creation_OrderDatePIcker";
			this.Creation_OrderDatePIcker.Size = new System.Drawing.Size(189, 25);
			this.Creation_OrderDatePIcker.TabIndex = 5;
			// 
			// Creation_TimePickerBox
			// 
			this.Creation_TimePickerBox.CalendarFont = new System.Drawing.Font("Arial", 11.25F);
			this.Creation_TimePickerBox.Font = new System.Drawing.Font("Arial", 11.25F);
			this.Creation_TimePickerBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.Creation_TimePickerBox.Location = new System.Drawing.Point(120, 69);
			this.Creation_TimePickerBox.Name = "Creation_TimePickerBox";
			this.Creation_TimePickerBox.Size = new System.Drawing.Size(189, 25);
			this.Creation_TimePickerBox.TabIndex = 6;
			// 
			// Creation_OrderNumberTextBox
			// 
			this.Creation_OrderNumberTextBox.Location = new System.Drawing.Point(121, 105);
			this.Creation_OrderNumberTextBox.Name = "Creation_OrderNumberTextBox";
			this.Creation_OrderNumberTextBox.Size = new System.Drawing.Size(189, 25);
			this.Creation_OrderNumberTextBox.TabIndex = 7;
			// 
			// Creation_TimeLabel
			// 
			this.Creation_TimeLabel.AutoSize = true;
			this.Creation_TimeLabel.Location = new System.Drawing.Point(75, 72);
			this.Creation_TimeLabel.Name = "Creation_TimeLabel";
			this.Creation_TimeLabel.Size = new System.Drawing.Size(44, 17);
			this.Creation_TimeLabel.TabIndex = 2;
			this.Creation_TimeLabel.Text = "Time:";
			this.Creation_TimeLabel.Click += new System.EventHandler(this.Creation_TimeLabel_Click);
			// 
			// Creation_OrderNumberLabel
			// 
			this.Creation_OrderNumberLabel.AutoSize = true;
			this.Creation_OrderNumberLabel.Location = new System.Drawing.Point(14, 105);
			this.Creation_OrderNumberLabel.Name = "Creation_OrderNumberLabel";
			this.Creation_OrderNumberLabel.Size = new System.Drawing.Size(106, 17);
			this.Creation_OrderNumberLabel.TabIndex = 4;
			this.Creation_OrderNumberLabel.Text = "Order Number:";
			// 
			// Creation_OrderDateLabel
			// 
			this.Creation_OrderDateLabel.AutoSize = true;
			this.Creation_OrderDateLabel.Location = new System.Drawing.Point(35, 38);
			this.Creation_OrderDateLabel.Name = "Creation_OrderDateLabel";
			this.Creation_OrderDateLabel.Size = new System.Drawing.Size(85, 17);
			this.Creation_OrderDateLabel.TabIndex = 0;
			this.Creation_OrderDateLabel.Text = "Order Date:";
			// 
			// customerTableAdapter
			// 
			this.customerTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager1
			// 
			this.tableAdapterManager1.AddressTableAdapter = null;
			this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager1.CustomerTableAdapter = this.customerTableAdapter;
			this.tableAdapterManager1.InvoiceTableAdapter = this.invoiceTableAdapter;
			this.tableAdapterManager1.OrdersTableAdapter = null;
			this.tableAdapterManager1.ProductTableAdapter = this.productTableAdapter;
			this.tableAdapterManager1.UpdateOrder = MiniBatchConreteDelivery.MiniBatchDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// invoiceTableAdapter
			// 
			this.invoiceTableAdapter.ClearBeforeFill = true;
			// 
			// productTableAdapter
			// 
			this.productTableAdapter.ClearBeforeFill = true;
			// 
			// TransactionSystemForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1057, 1237);
			this.Controls.Add(this.CreateOrderInvoiceGroupBox);
			this.Controls.Add(this.ProductsOnOrderGroupBox);
			this.Controls.Add(this.HistoryGroupBox);
			this.Controls.Add(this.CustomerListGroupBox);
			this.Controls.Add(this.LookupByGroupBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Arial", 11.25F);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "TransactionSystemForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MiniBatchConcrete";
			this.Load += new System.EventHandler(this.TransactionSystemForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.LookupByGroupBox.ResumeLayout(false);
			this.InvoiceOrdersGroupBox.ResumeLayout(false);
			this.InvoiceOrdersGroupBox.PerformLayout();
			this.ProductsGroupBox.ResumeLayout(false);
			this.ProductsGroupBox.PerformLayout();
			this.CustomerGroupBox.ResumeLayout(false);
			this.CustomerGroupBox.PerformLayout();
			this.CustomerListGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.CustomerListDataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.miniBatchDataSet)).EndInit();
			this.HistoryGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.InvoiceHistoryDataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
			this.ProductsOnOrderGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
			this.CreateOrderInvoiceGroupBox.ResumeLayout(false);
			this.CreateOrderInvoiceGroupBox.PerformLayout();
			this.InvoiceGroupBox.ResumeLayout(false);
			this.InvoiceGroupBox.PerformLayout();
			this.CustomerGroupBox2.ResumeLayout(false);
			this.CustomerGroupBox2.PerformLayout();
			this.OrderInfoGroupBox.ResumeLayout(false);
			this.OrderInfoGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem openReportToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox LookupByGroupBox;
		private System.Windows.Forms.GroupBox ProductsGroupBox;
		private System.Windows.Forms.GroupBox CustomerGroupBox;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Label PhoneNumberLabel;
		private System.Windows.Forms.MaskedTextBox PhoneNumberTextBox;
		private System.Windows.Forms.Label ProductNumberLabel;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.GroupBox InvoiceOrdersGroupBox;
		private System.Windows.Forms.Label OrderNumberLabel;
		private System.Windows.Forms.Label InvoiceNumberLabel;
		private System.Windows.Forms.ComboBox ProductNumberComboBox;
		private System.Windows.Forms.ComboBox InvoiceNumberComboBox;
		private System.Windows.Forms.ComboBox OrderNumberComboBox;
		private System.Windows.Forms.Button LookupSearchBtn;
		private System.Windows.Forms.Button ClearAllFieldsBtn1;
		private System.Windows.Forms.GroupBox CustomerListGroupBox;
		private System.Windows.Forms.GroupBox HistoryGroupBox;
		private System.Windows.Forms.GroupBox ProductsOnOrderGroupBox;
		private System.Windows.Forms.DataGridView productsDataGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn deliveryCostDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn discountAmtDataGridViewTextBoxColumn;
		private System.Windows.Forms.GroupBox CreateOrderInvoiceGroupBox;
		private System.Windows.Forms.DataGridView InvoiceHistoryDataGrid;
		private System.Windows.Forms.GroupBox InvoiceGroupBox;
		private System.Windows.Forms.GroupBox CustomerGroupBox2;
		private System.Windows.Forms.GroupBox OrderInfoGroupBox;
		private System.Windows.Forms.Label Creation_InvoiceNumberLabel;
		private System.Windows.Forms.Label Creation_DueDateLabel;
		private System.Windows.Forms.Label Creation_ProductNumberLabel;
		private System.Windows.Forms.ComboBox CreationProductNumberDropdown;
		private System.Windows.Forms.DateTimePicker Creation_DateTimePicker;
		private System.Windows.Forms.ComboBox Creation_InvoiceNumberComboBox;
		private System.Windows.Forms.TextBox Creation_DiscountAmtTextBox;
		private System.Windows.Forms.Label Creation_DiscountAmtLabel;
		private System.Windows.Forms.TextBox Creation_DeliveryCostTextBox;
		private System.Windows.Forms.Label Creation_DeliveryCostLabel;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label Creation_CustomerNumberLabel;
		private System.Windows.Forms.DateTimePicker Creation_TimePickerBox;
		private System.Windows.Forms.TextBox Creation_OrderNumberTextBox;
		private System.Windows.Forms.Label Creation_TimeLabel;
		private System.Windows.Forms.Label Creation_OrderNumberLabel;
		private System.Windows.Forms.Label Creation_OrderDateLabel;
		private System.Windows.Forms.DateTimePicker Creation_OrderDatePIcker;
		private System.Windows.Forms.Button CustomerListSaveBtn;
		private System.Windows.Forms.Button CustomerListEditBtn;
		private System.Windows.Forms.Button CustomerListClearFieldsBtn;
		private System.Windows.Forms.Button CustomerListCancelBtn;
		private System.Windows.Forms.Button InvoiceHistorySaveBtn;
		private System.Windows.Forms.Button InvoiceHistoryEditBtn;
		private System.Windows.Forms.Button InvoiceHistoryClearFieldsBtn;
		private System.Windows.Forms.Button InvoiceHistoryCancelBtn;
		private System.Windows.Forms.Button ProductsSaveBtn;
		private System.Windows.Forms.Button ProductsEditBtn;
		private System.Windows.Forms.Button ProductsClearFieldsBtn;
		private System.Windows.Forms.Button ProductsCancelBtn;
		private System.Windows.Forms.DataGridView CustomerListDataGrid;
		private System.Windows.Forms.ComboBox PmtMtdComboBox;
		private System.Windows.Forms.Label Creation_PmtMtdLabel;
		private System.Windows.Forms.Label Creation_ProductsPurchasedLabel;
		private System.Windows.Forms.ListBox listBox1;
		private MiniBatchDataSet miniBatchDataSet;
		private System.Windows.Forms.BindingSource customerBindingSource;
		private MiniBatchDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
		private MiniBatchDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
		private System.Windows.Forms.DataGridViewTextBoxColumn customerNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn balanceOwingDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressNumberDataGridViewTextBoxColumn;
		private MiniBatchDataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
		private System.Windows.Forms.BindingSource invoiceBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNumberDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn deliveryCostDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn discountAmtDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn productNumberDataGridViewTextBoxColumn;
		private MiniBatchDataSetTableAdapters.ProductTableAdapter productTableAdapter;
		private System.Windows.Forms.BindingSource productBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemCodeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productDescriptionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productNumberDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn reOrderQuantityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn unitOfMeassureDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sellPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNumberDataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
	}
}

