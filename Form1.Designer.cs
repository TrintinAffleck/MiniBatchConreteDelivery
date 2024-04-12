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
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.balanceOwingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.miniBatchDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.miniBatchDataSet = new MiniBatchConreteDelivery.MiniBatchDataSet();
			this.HistoryGroupBox = new System.Windows.Forms.GroupBox();
			this.InvoiceHistoryDataGrid = new System.Windows.Forms.DataGridView();
			this.invoiceNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dueDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deliveryCostDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.discountAmtDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ProductsOnOrderGroupBox = new System.Windows.Forms.GroupBox();
			this.ProductsOnOrderDataGrid = new System.Windows.Forms.DataGridView();
			this.productNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reOrderQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unitOfMeassureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sellPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.invoiceNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deliveryCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.discountAmtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.invoiceTableAdapter = new MiniBatchConreteDelivery.MiniBatchDataSetTableAdapters.InvoiceTableAdapter();
			this.tableAdapterManager1 = new MiniBatchConreteDelivery.MiniBatchDataSetTableAdapters.TableAdapterManager();
			this.customerTableAdapter = new MiniBatchConreteDelivery.MiniBatchDataSetTableAdapters.CustomerTableAdapter();
			this.productTableAdapter = new MiniBatchConreteDelivery.MiniBatchDataSetTableAdapters.ProductTableAdapter();
			this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.CreateOrderInvoiceGroupBox = new System.Windows.Forms.GroupBox();
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
			this.Creation_OrderDatePIcker = new System.Windows.Forms.DateTimePicker();
			this.Creation_TimePickerBox = new System.Windows.Forms.DateTimePicker();
			this.Creation_OrderNumberTextBox = new System.Windows.Forms.TextBox();
			this.Creation_TimeLabel = new System.Windows.Forms.Label();
			this.Creation_OrderNumberLabel = new System.Windows.Forms.Label();
			this.Creation_OrderDateLabel = new System.Windows.Forms.Label();
			this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.menuStrip1.SuspendLayout();
			this.LookupByGroupBox.SuspendLayout();
			this.InvoiceOrdersGroupBox.SuspendLayout();
			this.ProductsGroupBox.SuspendLayout();
			this.CustomerGroupBox.SuspendLayout();
			this.CustomerListGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CustomerListDataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.miniBatchDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.miniBatchDataSet)).BeginInit();
			this.HistoryGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.InvoiceHistoryDataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
			this.ProductsOnOrderGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ProductsOnOrderDataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
			this.CreateOrderInvoiceGroupBox.SuspendLayout();
			this.InvoiceGroupBox.SuspendLayout();
			this.CustomerGroupBox2.SuspendLayout();
			this.OrderInfoGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
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
			this.ClearAllFieldsBtn1.Size = new System.Drawing.Size(109, 30);
			this.ClearAllFieldsBtn1.TabIndex = 6;
			this.ClearAllFieldsBtn1.Text = "Clear All Fields";
			this.ClearAllFieldsBtn1.UseVisualStyleBackColor = true;
			this.ClearAllFieldsBtn1.Click += new System.EventHandler(this.ClearAllFieldsBtn1_Click);
			// 
			// LookupSearchBtn
			// 
			this.LookupSearchBtn.Location = new System.Drawing.Point(773, 146);
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
			this.CustomerListGroupBox.Location = new System.Drawing.Point(20, 263);
			this.CustomerListGroupBox.Name = "CustomerListGroupBox";
			this.CustomerListGroupBox.Size = new System.Drawing.Size(1025, 230);
			this.CustomerListGroupBox.TabIndex = 2;
			this.CustomerListGroupBox.TabStop = false;
			this.CustomerListGroupBox.Text = "Customer List";
			// 
			// CustomerListDataGrid
			// 
			this.CustomerListDataGrid.AutoGenerateColumns = false;
			this.CustomerListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.CustomerListDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.customerNumberDataGridViewTextBoxColumn,
            this.balanceOwingDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn});
			this.CustomerListDataGrid.DataSource = this.customerBindingSource2;
			this.CustomerListDataGrid.Location = new System.Drawing.Point(3, 20);
			this.CustomerListDataGrid.Name = "CustomerListDataGrid";
			this.CustomerListDataGrid.Size = new System.Drawing.Size(998, 166);
			this.CustomerListDataGrid.TabIndex = 0;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// customerNumberDataGridViewTextBoxColumn
			// 
			this.customerNumberDataGridViewTextBoxColumn.DataPropertyName = "CustomerNumber";
			this.customerNumberDataGridViewTextBoxColumn.HeaderText = "CustomerNumber";
			this.customerNumberDataGridViewTextBoxColumn.MinimumWidth = 150;
			this.customerNumberDataGridViewTextBoxColumn.Name = "customerNumberDataGridViewTextBoxColumn";
			this.customerNumberDataGridViewTextBoxColumn.Width = 150;
			// 
			// balanceOwingDataGridViewTextBoxColumn
			// 
			this.balanceOwingDataGridViewTextBoxColumn.DataPropertyName = "BalanceOwing";
			this.balanceOwingDataGridViewTextBoxColumn.HeaderText = "BalanceOwing";
			this.balanceOwingDataGridViewTextBoxColumn.MinimumWidth = 150;
			this.balanceOwingDataGridViewTextBoxColumn.Name = "balanceOwingDataGridViewTextBoxColumn";
			this.balanceOwingDataGridViewTextBoxColumn.Width = 150;
			// 
			// phoneNumberDataGridViewTextBoxColumn
			// 
			this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
			this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
			this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 150;
			this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
			this.phoneNumberDataGridViewTextBoxColumn.Width = 150;
			// 
			// customerBindingSource2
			// 
			this.customerBindingSource2.DataMember = "Customer";
			this.customerBindingSource2.DataSource = this.miniBatchDataSetBindingSource;
			// 
			// miniBatchDataSetBindingSource
			// 
			this.miniBatchDataSetBindingSource.DataSource = this.miniBatchDataSet;
			this.miniBatchDataSetBindingSource.Position = 0;
			// 
			// miniBatchDataSet
			// 
			this.miniBatchDataSet.DataSetName = "MiniBatchDataSet";
			this.miniBatchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// HistoryGroupBox
			// 
			this.HistoryGroupBox.Controls.Add(this.InvoiceHistoryDataGrid);
			this.HistoryGroupBox.Location = new System.Drawing.Point(19, 499);
			this.HistoryGroupBox.Name = "HistoryGroupBox";
			this.HistoryGroupBox.Size = new System.Drawing.Size(1025, 237);
			this.HistoryGroupBox.TabIndex = 3;
			this.HistoryGroupBox.TabStop = false;
			this.HistoryGroupBox.Text = "Invoice History";
			// 
			// InvoiceHistoryDataGrid
			// 
			this.InvoiceHistoryDataGrid.AutoGenerateColumns = false;
			this.InvoiceHistoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.InvoiceHistoryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceNumberDataGridViewTextBoxColumn1,
            this.dueDateDataGridViewTextBoxColumn1,
            this.deliveryCostDataGridViewTextBoxColumn1,
            this.discountAmtDataGridViewTextBoxColumn1});
			this.InvoiceHistoryDataGrid.DataSource = this.invoiceBindingSource;
			this.InvoiceHistoryDataGrid.Location = new System.Drawing.Point(7, 24);
			this.InvoiceHistoryDataGrid.Name = "InvoiceHistoryDataGrid";
			this.InvoiceHistoryDataGrid.Size = new System.Drawing.Size(997, 142);
			this.InvoiceHistoryDataGrid.TabIndex = 0;
			// 
			// invoiceNumberDataGridViewTextBoxColumn1
			// 
			this.invoiceNumberDataGridViewTextBoxColumn1.DataPropertyName = "InvoiceNumber";
			this.invoiceNumberDataGridViewTextBoxColumn1.HeaderText = "InvoiceNumber";
			this.invoiceNumberDataGridViewTextBoxColumn1.Name = "invoiceNumberDataGridViewTextBoxColumn1";
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
			// invoiceBindingSource
			// 
			this.invoiceBindingSource.DataMember = "Invoice";
			this.invoiceBindingSource.DataSource = this.miniBatchDataSet;
			// 
			// ProductsOnOrderGroupBox
			// 
			this.ProductsOnOrderGroupBox.Controls.Add(this.ProductsOnOrderDataGrid);
			this.ProductsOnOrderGroupBox.Location = new System.Drawing.Point(19, 741);
			this.ProductsOnOrderGroupBox.Name = "ProductsOnOrderGroupBox";
			this.ProductsOnOrderGroupBox.Size = new System.Drawing.Size(1025, 235);
			this.ProductsOnOrderGroupBox.TabIndex = 4;
			this.ProductsOnOrderGroupBox.TabStop = false;
			this.ProductsOnOrderGroupBox.Text = "Products On Order";
			// 
			// ProductsOnOrderDataGrid
			// 
			this.ProductsOnOrderDataGrid.AutoGenerateColumns = false;
			this.ProductsOnOrderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ProductsOnOrderDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNumberDataGridViewTextBoxColumn,
            this.reOrderQuantityDataGridViewTextBoxColumn,
            this.unitOfMeassureDataGridViewTextBoxColumn,
            this.productDescriptionDataGridViewTextBoxColumn,
            this.sellPriceDataGridViewTextBoxColumn});
			this.ProductsOnOrderDataGrid.DataSource = this.productBindingSource;
			this.ProductsOnOrderDataGrid.Location = new System.Drawing.Point(3, 20);
			this.ProductsOnOrderDataGrid.Name = "ProductsOnOrderDataGrid";
			this.ProductsOnOrderDataGrid.Size = new System.Drawing.Size(1001, 162);
			this.ProductsOnOrderDataGrid.TabIndex = 0;
			// 
			// productNumberDataGridViewTextBoxColumn
			// 
			this.productNumberDataGridViewTextBoxColumn.DataPropertyName = "ProductNumber";
			this.productNumberDataGridViewTextBoxColumn.HeaderText = "ProductNumber";
			this.productNumberDataGridViewTextBoxColumn.MinimumWidth = 150;
			this.productNumberDataGridViewTextBoxColumn.Name = "productNumberDataGridViewTextBoxColumn";
			this.productNumberDataGridViewTextBoxColumn.Width = 150;
			// 
			// reOrderQuantityDataGridViewTextBoxColumn
			// 
			this.reOrderQuantityDataGridViewTextBoxColumn.DataPropertyName = "ReOrderQuantity";
			this.reOrderQuantityDataGridViewTextBoxColumn.HeaderText = "ReOrderQuantity";
			this.reOrderQuantityDataGridViewTextBoxColumn.MinimumWidth = 150;
			this.reOrderQuantityDataGridViewTextBoxColumn.Name = "reOrderQuantityDataGridViewTextBoxColumn";
			this.reOrderQuantityDataGridViewTextBoxColumn.Width = 150;
			// 
			// unitOfMeassureDataGridViewTextBoxColumn
			// 
			this.unitOfMeassureDataGridViewTextBoxColumn.DataPropertyName = "UnitOfMeassure";
			this.unitOfMeassureDataGridViewTextBoxColumn.HeaderText = "UnitOfMeassure";
			this.unitOfMeassureDataGridViewTextBoxColumn.MinimumWidth = 150;
			this.unitOfMeassureDataGridViewTextBoxColumn.Name = "unitOfMeassureDataGridViewTextBoxColumn";
			this.unitOfMeassureDataGridViewTextBoxColumn.Width = 150;
			// 
			// productDescriptionDataGridViewTextBoxColumn
			// 
			this.productDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProductDescription";
			this.productDescriptionDataGridViewTextBoxColumn.HeaderText = "ProductDescription";
			this.productDescriptionDataGridViewTextBoxColumn.MinimumWidth = 150;
			this.productDescriptionDataGridViewTextBoxColumn.Name = "productDescriptionDataGridViewTextBoxColumn";
			this.productDescriptionDataGridViewTextBoxColumn.Width = 150;
			// 
			// sellPriceDataGridViewTextBoxColumn
			// 
			this.sellPriceDataGridViewTextBoxColumn.DataPropertyName = "SellPrice";
			this.sellPriceDataGridViewTextBoxColumn.HeaderText = "SellPrice";
			this.sellPriceDataGridViewTextBoxColumn.MinimumWidth = 150;
			this.sellPriceDataGridViewTextBoxColumn.Name = "sellPriceDataGridViewTextBoxColumn";
			this.sellPriceDataGridViewTextBoxColumn.Width = 150;
			// 
			// productBindingSource
			// 
			this.productBindingSource.DataMember = "Product";
			this.productBindingSource.DataSource = this.miniBatchDataSetBindingSource;
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
			// invoiceTableAdapter
			// 
			this.invoiceTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager1
			// 
			this.tableAdapterManager1.addressTableAdapter = null;
			this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager1.CustomerTableAdapter = this.customerTableAdapter;
			this.tableAdapterManager1.InvoiceTableAdapter = this.invoiceTableAdapter;
			this.tableAdapterManager1.OrderTableAdapter = null;
			this.tableAdapterManager1.ProductTableAdapter = this.productTableAdapter;
			this.tableAdapterManager1.UpdateOrder = MiniBatchConreteDelivery.MiniBatchDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// customerTableAdapter
			// 
			this.customerTableAdapter.ClearBeforeFill = true;
			// 
			// productTableAdapter
			// 
			this.productTableAdapter.ClearBeforeFill = true;
			// 
			// customerBindingSource
			// 
			this.customerBindingSource.DataMember = "Customer";
			this.customerBindingSource.DataSource = this.miniBatchDataSet;
			// 
			// CreateOrderInvoiceGroupBox
			// 
			this.CreateOrderInvoiceGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.CreateOrderInvoiceGroupBox.Controls.Add(this.InvoiceGroupBox);
			this.CreateOrderInvoiceGroupBox.Controls.Add(this.CustomerGroupBox2);
			this.CreateOrderInvoiceGroupBox.Controls.Add(this.OrderInfoGroupBox);
			this.CreateOrderInvoiceGroupBox.Location = new System.Drawing.Point(19, 982);
			this.CreateOrderInvoiceGroupBox.Name = "CreateOrderInvoiceGroupBox";
			this.CreateOrderInvoiceGroupBox.Size = new System.Drawing.Size(1025, 199);
			this.CreateOrderInvoiceGroupBox.TabIndex = 5;
			this.CreateOrderInvoiceGroupBox.TabStop = false;
			this.CreateOrderInvoiceGroupBox.Text = "Create Order & Invoice";
			this.CreateOrderInvoiceGroupBox.Enter += new System.EventHandler(this.CreationGroupBox_Enter);
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
			this.InvoiceGroupBox.Location = new System.Drawing.Point(585, 24);
			this.InvoiceGroupBox.Name = "InvoiceGroupBox";
			this.InvoiceGroupBox.Size = new System.Drawing.Size(429, 152);
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
			this.Creation_InvoiceNumberComboBox.Size = new System.Drawing.Size(280, 25);
			this.Creation_InvoiceNumberComboBox.TabIndex = 7;
			// 
			// Creation_DateTimePicker
			// 
			this.Creation_DateTimePicker.CustomFormat = "MM/dd/yyyy h:mm tt";
			this.Creation_DateTimePicker.Font = new System.Drawing.Font("Arial", 11.25F);
			this.Creation_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.Creation_DateTimePicker.Location = new System.Drawing.Point(134, 57);
			this.Creation_DateTimePicker.Name = "Creation_DateTimePicker";
			this.Creation_DateTimePicker.Size = new System.Drawing.Size(280, 25);
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
			this.CreationProductNumberDropdown.Items.AddRange(new object[] {
            "product1",
            "product2",
            "product3"});
			this.CreationProductNumberDropdown.Location = new System.Drawing.Point(134, 23);
			this.CreationProductNumberDropdown.Name = "CreationProductNumberDropdown";
			this.CreationProductNumberDropdown.Size = new System.Drawing.Size(280, 25);
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
			this.CustomerGroupBox2.Location = new System.Drawing.Point(303, 24);
			this.CustomerGroupBox2.Name = "CustomerGroupBox2";
			this.CustomerGroupBox2.Size = new System.Drawing.Size(263, 152);
			this.CustomerGroupBox2.TabIndex = 1;
			this.CustomerGroupBox2.TabStop = false;
			this.CustomerGroupBox2.Text = "Customer";
			// 
			// Creation_DiscountAmtTextBox
			// 
			this.Creation_DiscountAmtTextBox.Location = new System.Drawing.Point(136, 102);
			this.Creation_DiscountAmtTextBox.Name = "Creation_DiscountAmtTextBox";
			this.Creation_DiscountAmtTextBox.Size = new System.Drawing.Size(102, 25);
			this.Creation_DiscountAmtTextBox.TabIndex = 5;
			// 
			// Creation_DiscountAmtLabel
			// 
			this.Creation_DiscountAmtLabel.AutoSize = true;
			this.Creation_DiscountAmtLabel.Location = new System.Drawing.Point(35, 105);
			this.Creation_DiscountAmtLabel.Name = "Creation_DiscountAmtLabel";
			this.Creation_DiscountAmtLabel.Size = new System.Drawing.Size(99, 17);
			this.Creation_DiscountAmtLabel.TabIndex = 4;
			this.Creation_DiscountAmtLabel.Text = "Discount Amt:";
			// 
			// Creation_DeliveryCostTextBox
			// 
			this.Creation_DeliveryCostTextBox.Location = new System.Drawing.Point(136, 69);
			this.Creation_DeliveryCostTextBox.Name = "Creation_DeliveryCostTextBox";
			this.Creation_DeliveryCostTextBox.Size = new System.Drawing.Size(102, 25);
			this.Creation_DeliveryCostTextBox.TabIndex = 3;
			// 
			// Creation_DeliveryCostLabel
			// 
			this.Creation_DeliveryCostLabel.AutoSize = true;
			this.Creation_DeliveryCostLabel.Location = new System.Drawing.Point(31, 72);
			this.Creation_DeliveryCostLabel.Name = "Creation_DeliveryCostLabel";
			this.Creation_DeliveryCostLabel.Size = new System.Drawing.Size(99, 17);
			this.Creation_DeliveryCostLabel.TabIndex = 2;
			this.Creation_DeliveryCostLabel.Text = "Delivery Cost:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(136, 30);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(102, 25);
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
			this.OrderInfoGroupBox.Controls.Add(this.Creation_OrderDatePIcker);
			this.OrderInfoGroupBox.Controls.Add(this.Creation_TimePickerBox);
			this.OrderInfoGroupBox.Controls.Add(this.Creation_OrderNumberTextBox);
			this.OrderInfoGroupBox.Controls.Add(this.Creation_TimeLabel);
			this.OrderInfoGroupBox.Controls.Add(this.Creation_OrderNumberLabel);
			this.OrderInfoGroupBox.Controls.Add(this.Creation_OrderDateLabel);
			this.OrderInfoGroupBox.Location = new System.Drawing.Point(4, 23);
			this.OrderInfoGroupBox.Name = "OrderInfoGroupBox";
			this.OrderInfoGroupBox.Size = new System.Drawing.Size(289, 152);
			this.OrderInfoGroupBox.TabIndex = 0;
			this.OrderInfoGroupBox.TabStop = false;
			this.OrderInfoGroupBox.Text = "Order Info";
			// 
			// Creation_OrderDatePIcker
			// 
			this.Creation_OrderDatePIcker.CustomFormat = "MM/dd/yyyy h:mm tt";
			this.Creation_OrderDatePIcker.Font = new System.Drawing.Font("Arial", 11.25F);
			this.Creation_OrderDatePIcker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.Creation_OrderDatePIcker.Location = new System.Drawing.Point(121, 33);
			this.Creation_OrderDatePIcker.Name = "Creation_OrderDatePIcker";
			this.Creation_OrderDatePIcker.Size = new System.Drawing.Size(156, 25);
			this.Creation_OrderDatePIcker.TabIndex = 5;
			// 
			// Creation_TimePickerBox
			// 
			this.Creation_TimePickerBox.CalendarFont = new System.Drawing.Font("Arial", 11.25F);
			this.Creation_TimePickerBox.Font = new System.Drawing.Font("Arial", 11.25F);
			this.Creation_TimePickerBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.Creation_TimePickerBox.Location = new System.Drawing.Point(121, 72);
			this.Creation_TimePickerBox.Name = "Creation_TimePickerBox";
			this.Creation_TimePickerBox.Size = new System.Drawing.Size(156, 25);
			this.Creation_TimePickerBox.TabIndex = 6;
			// 
			// Creation_OrderNumberTextBox
			// 
			this.Creation_OrderNumberTextBox.Location = new System.Drawing.Point(121, 105);
			this.Creation_OrderNumberTextBox.Name = "Creation_OrderNumberTextBox";
			this.Creation_OrderNumberTextBox.Size = new System.Drawing.Size(156, 25);
			this.Creation_OrderNumberTextBox.TabIndex = 7;
			// 
			// Creation_TimeLabel
			// 
			this.Creation_TimeLabel.AutoSize = true;
			this.Creation_TimeLabel.Location = new System.Drawing.Point(74, 76);
			this.Creation_TimeLabel.Name = "Creation_TimeLabel";
			this.Creation_TimeLabel.Size = new System.Drawing.Size(44, 17);
			this.Creation_TimeLabel.TabIndex = 2;
			this.Creation_TimeLabel.Text = "Time:";
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
			// customerBindingSource1
			// 
			this.customerBindingSource1.DataMember = "Customer";
			this.customerBindingSource1.DataSource = this.miniBatchDataSetBindingSource;
			// 
			// TransactionSystemForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1057, 1167);
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
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.miniBatchDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.miniBatchDataSet)).EndInit();
			this.HistoryGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.InvoiceHistoryDataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
			this.ProductsOnOrderGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ProductsOnOrderDataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
			this.CreateOrderInvoiceGroupBox.ResumeLayout(false);
			this.InvoiceGroupBox.ResumeLayout(false);
			this.InvoiceGroupBox.PerformLayout();
			this.CustomerGroupBox2.ResumeLayout(false);
			this.CustomerGroupBox2.PerformLayout();
			this.OrderInfoGroupBox.ResumeLayout(false);
			this.OrderInfoGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
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
		private System.Windows.Forms.DataGridView CustomerListDataGrid;
		private MiniBatchDataSet miniBatchDataSet;
		private System.Windows.Forms.BindingSource invoiceBindingSource;
		private MiniBatchDataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
		private MiniBatchDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
		private MiniBatchDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
		private System.Windows.Forms.BindingSource customerBindingSource;
		private System.Windows.Forms.DataGridView ProductsOnOrderDataGrid;
		private System.Windows.Forms.BindingSource miniBatchDataSetBindingSource;
		private MiniBatchDataSetTableAdapters.ProductTableAdapter productTableAdapter;
		private System.Windows.Forms.BindingSource productBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn productNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn reOrderQuantityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn unitOfMeassureDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productDescriptionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sellPriceDataGridViewTextBoxColumn;
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
		private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNumberDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn deliveryCostDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn discountAmtDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn customerNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn balanceOwingDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource customerBindingSource2;
		private System.Windows.Forms.BindingSource customerBindingSource1;
	}
}

