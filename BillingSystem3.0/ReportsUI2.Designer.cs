namespace BillingSystem3._0
{
    partial class ReportsUI2
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
            this.generateReadingsTableAdapter = new BillingSystem3._0.BillingSystemDataSetTableAdapters.GenerateReadingsTableAdapter();
            this.generateReadingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billingSystemDataSet = new BillingSystem3._0.BillingSystemDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ViewReport = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Label();
            this.txtbox_SearchReport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_toReport = new System.Windows.Forms.DateTimePicker();
            this.dtp_fromReport = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.collectionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeOwnerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penaltyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billingSystemDataSet2 = new BillingSystem3._0.BillingSystemDataSet2();
            this.collectionsTableAdapter = new BillingSystem3._0.BillingSystemDataSet2TableAdapters.CollectionsTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.invoiceIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeOwnerIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deductionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billingSystemDataSet3 = new BillingSystem3._0.BillingSystemDataSet3();
            this.invoicesTableAdapter = new BillingSystem3._0.BillingSystemDataSet3TableAdapters.InvoicesTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.generateReadingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingSystemDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingSystemDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // generateReadingsTableAdapter
            // 
            this.generateReadingsTableAdapter.ClearBeforeFill = true;
            // 
            // generateReadingsBindingSource
            // 
            this.generateReadingsBindingSource.DataMember = "GenerateReadings";
            this.generateReadingsBindingSource.DataSource = this.billingSystemDataSet;
            // 
            // billingSystemDataSet
            // 
            this.billingSystemDataSet.DataSetName = "BillingSystemDataSet";
            this.billingSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1185, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 46);
            this.button1.TabIndex = 17;
            this.button1.Text = "Generate Reports";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ViewReport
            // 
            this.btn_ViewReport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ViewReport.FlatAppearance.BorderSize = 0;
            this.btn_ViewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewReport.Location = new System.Drawing.Point(502, 38);
            this.btn_ViewReport.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ViewReport.Name = "btn_ViewReport";
            this.btn_ViewReport.Size = new System.Drawing.Size(92, 27);
            this.btn_ViewReport.TabIndex = 16;
            this.btn_ViewReport.Text = "Search";
            this.btn_ViewReport.UseVisualStyleBackColor = false;
            this.btn_ViewReport.Click += new System.EventHandler(this.btn_ViewReport_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.AutoSize = true;
            this.btn_Search.Location = new System.Drawing.Point(48, 43);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(53, 16);
            this.btn_Search.TabIndex = 15;
            this.btn_Search.Text = "Search:";
            // 
            // txtbox_SearchReport
            // 
            this.txtbox_SearchReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_SearchReport.Location = new System.Drawing.Point(109, 38);
            this.txtbox_SearchReport.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_SearchReport.Name = "txtbox_SearchReport";
            this.txtbox_SearchReport.Size = new System.Drawing.Size(385, 27);
            this.txtbox_SearchReport.TabIndex = 14;
            this.txtbox_SearchReport.TextChanged += new System.EventHandler(this.txtbox_SearchReport_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(807, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Date to:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(792, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date from:";
            // 
            // dtp_toReport
            // 
            this.dtp_toReport.Location = new System.Drawing.Point(868, 58);
            this.dtp_toReport.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_toReport.Name = "dtp_toReport";
            this.dtp_toReport.Size = new System.Drawing.Size(265, 22);
            this.dtp_toReport.TabIndex = 10;
            this.dtp_toReport.ValueChanged += new System.EventHandler(this.dtp_toReport_ValueChanged);
            // 
            // dtp_fromReport
            // 
            this.dtp_fromReport.Location = new System.Drawing.Point(868, 24);
            this.dtp_fromReport.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_fromReport.Name = "dtp_fromReport";
            this.dtp_fromReport.Size = new System.Drawing.Size(265, 22);
            this.dtp_fromReport.TabIndex = 9;
            this.dtp_fromReport.ValueChanged += new System.EventHandler(this.dtp_fromReport_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_ViewReport);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.txtbox_SearchReport);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtp_toReport);
            this.panel1.Controls.Add(this.dtp_fromReport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1619, 167);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1100, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 39);
            this.label4.TabIndex = 19;
            this.label4.Text = "INVOICE Reports";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(146, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 39);
            this.label3.TabIndex = 18;
            this.label3.Text = "Collection Reports";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.collectionIdDataGridViewTextBoxColumn,
            this.invoiceIdDataGridViewTextBoxColumn,
            this.homeOwnerIdDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.transDateDataGridViewTextBoxColumn,
            this.oRNoDataGridViewTextBoxColumn,
            this.grossPaymentDataGridViewTextBoxColumn,
            this.penaltyDataGridViewTextBoxColumn,
            this.netPaymentDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.collectionsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(831, 478);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // collectionIdDataGridViewTextBoxColumn
            // 
            this.collectionIdDataGridViewTextBoxColumn.DataPropertyName = "CollectionId";
            this.collectionIdDataGridViewTextBoxColumn.HeaderText = "CollectionId";
            this.collectionIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.collectionIdDataGridViewTextBoxColumn.Name = "collectionIdDataGridViewTextBoxColumn";
            this.collectionIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.collectionIdDataGridViewTextBoxColumn.Visible = false;
            this.collectionIdDataGridViewTextBoxColumn.Width = 106;
            // 
            // invoiceIdDataGridViewTextBoxColumn
            // 
            this.invoiceIdDataGridViewTextBoxColumn.DataPropertyName = "InvoiceId";
            this.invoiceIdDataGridViewTextBoxColumn.HeaderText = "InvoiceId";
            this.invoiceIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.invoiceIdDataGridViewTextBoxColumn.Name = "invoiceIdDataGridViewTextBoxColumn";
            this.invoiceIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceIdDataGridViewTextBoxColumn.Visible = false;
            this.invoiceIdDataGridViewTextBoxColumn.Width = 90;
            // 
            // homeOwnerIdDataGridViewTextBoxColumn
            // 
            this.homeOwnerIdDataGridViewTextBoxColumn.DataPropertyName = "HomeOwnerId";
            this.homeOwnerIdDataGridViewTextBoxColumn.HeaderText = "HomeOwnerId";
            this.homeOwnerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.homeOwnerIdDataGridViewTextBoxColumn.Name = "homeOwnerIdDataGridViewTextBoxColumn";
            this.homeOwnerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.homeOwnerIdDataGridViewTextBoxColumn.Visible = false;
            this.homeOwnerIdDataGridViewTextBoxColumn.Width = 122;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullNameDataGridViewTextBoxColumn.Width = 94;
            // 
            // transDateDataGridViewTextBoxColumn
            // 
            this.transDateDataGridViewTextBoxColumn.DataPropertyName = "TransDate";
            this.transDateDataGridViewTextBoxColumn.HeaderText = "TransDate";
            this.transDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transDateDataGridViewTextBoxColumn.Name = "transDateDataGridViewTextBoxColumn";
            this.transDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oRNoDataGridViewTextBoxColumn
            // 
            this.oRNoDataGridViewTextBoxColumn.DataPropertyName = "ORNo";
            this.oRNoDataGridViewTextBoxColumn.HeaderText = "ORNo";
            this.oRNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oRNoDataGridViewTextBoxColumn.Name = "oRNoDataGridViewTextBoxColumn";
            this.oRNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.oRNoDataGridViewTextBoxColumn.Width = 74;
            // 
            // grossPaymentDataGridViewTextBoxColumn
            // 
            this.grossPaymentDataGridViewTextBoxColumn.DataPropertyName = "GrossPayment";
            this.grossPaymentDataGridViewTextBoxColumn.HeaderText = "GrossPayment";
            this.grossPaymentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.grossPaymentDataGridViewTextBoxColumn.Name = "grossPaymentDataGridViewTextBoxColumn";
            this.grossPaymentDataGridViewTextBoxColumn.ReadOnly = true;
            this.grossPaymentDataGridViewTextBoxColumn.Width = 125;
            // 
            // penaltyDataGridViewTextBoxColumn
            // 
            this.penaltyDataGridViewTextBoxColumn.DataPropertyName = "Penalty";
            this.penaltyDataGridViewTextBoxColumn.HeaderText = "Penalty";
            this.penaltyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.penaltyDataGridViewTextBoxColumn.Name = "penaltyDataGridViewTextBoxColumn";
            this.penaltyDataGridViewTextBoxColumn.ReadOnly = true;
            this.penaltyDataGridViewTextBoxColumn.Width = 81;
            // 
            // netPaymentDataGridViewTextBoxColumn
            // 
            this.netPaymentDataGridViewTextBoxColumn.DataPropertyName = "NetPayment";
            this.netPaymentDataGridViewTextBoxColumn.HeaderText = "NetPayment";
            this.netPaymentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.netPaymentDataGridViewTextBoxColumn.Name = "netPaymentDataGridViewTextBoxColumn";
            this.netPaymentDataGridViewTextBoxColumn.ReadOnly = true;
            this.netPaymentDataGridViewTextBoxColumn.Width = 110;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.ReadOnly = true;
            this.remarksDataGridViewTextBoxColumn.Width = 91;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "Created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "Created_at";
            this.createdatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            this.createdatDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdatDataGridViewTextBoxColumn.Visible = false;
            this.createdatDataGridViewTextBoxColumn.Width = 102;
            // 
            // collectionsBindingSource
            // 
            this.collectionsBindingSource.DataMember = "Collections";
            this.collectionsBindingSource.DataSource = this.billingSystemDataSet2;
            // 
            // billingSystemDataSet2
            // 
            this.billingSystemDataSet2.DataSetName = "BillingSystemDataSet2";
            this.billingSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // collectionsTableAdapter
            // 
            this.collectionsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceIdDataGridViewTextBoxColumn1,
            this.transDateDataGridViewTextBoxColumn1,
            this.homeOwnerIdDataGridViewTextBoxColumn1,
            this.fullNameDataGridViewTextBoxColumn1,
            this.grossAmountDataGridViewTextBoxColumn,
            this.deductionsDataGridViewTextBoxColumn,
            this.netAmountDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn1,
            this.remarksDataGridViewTextBoxColumn1,
            this.paymentStatusDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.invoicesBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.GridColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(831, 167);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(788, 478);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // invoiceIdDataGridViewTextBoxColumn1
            // 
            this.invoiceIdDataGridViewTextBoxColumn1.DataPropertyName = "InvoiceId";
            this.invoiceIdDataGridViewTextBoxColumn1.HeaderText = "InvoiceId";
            this.invoiceIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.invoiceIdDataGridViewTextBoxColumn1.Name = "invoiceIdDataGridViewTextBoxColumn1";
            this.invoiceIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.invoiceIdDataGridViewTextBoxColumn1.Visible = false;
            this.invoiceIdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // transDateDataGridViewTextBoxColumn1
            // 
            this.transDateDataGridViewTextBoxColumn1.DataPropertyName = "TransDate";
            this.transDateDataGridViewTextBoxColumn1.HeaderText = "TransDate";
            this.transDateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.transDateDataGridViewTextBoxColumn1.Name = "transDateDataGridViewTextBoxColumn1";
            this.transDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // homeOwnerIdDataGridViewTextBoxColumn1
            // 
            this.homeOwnerIdDataGridViewTextBoxColumn1.DataPropertyName = "HomeOwnerId";
            this.homeOwnerIdDataGridViewTextBoxColumn1.HeaderText = "HomeOwnerId";
            this.homeOwnerIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.homeOwnerIdDataGridViewTextBoxColumn1.Name = "homeOwnerIdDataGridViewTextBoxColumn1";
            this.homeOwnerIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.homeOwnerIdDataGridViewTextBoxColumn1.Visible = false;
            this.homeOwnerIdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // fullNameDataGridViewTextBoxColumn1
            // 
            this.fullNameDataGridViewTextBoxColumn1.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn1.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn1.Name = "fullNameDataGridViewTextBoxColumn1";
            this.fullNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fullNameDataGridViewTextBoxColumn1.Width = 94;
            // 
            // grossAmountDataGridViewTextBoxColumn
            // 
            this.grossAmountDataGridViewTextBoxColumn.DataPropertyName = "GrossAmount";
            this.grossAmountDataGridViewTextBoxColumn.HeaderText = "GrossAmount";
            this.grossAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.grossAmountDataGridViewTextBoxColumn.Name = "grossAmountDataGridViewTextBoxColumn";
            this.grossAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.grossAmountDataGridViewTextBoxColumn.Width = 117;
            // 
            // deductionsDataGridViewTextBoxColumn
            // 
            this.deductionsDataGridViewTextBoxColumn.DataPropertyName = "Deductions";
            this.deductionsDataGridViewTextBoxColumn.HeaderText = "Deductions";
            this.deductionsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deductionsDataGridViewTextBoxColumn.Name = "deductionsDataGridViewTextBoxColumn";
            this.deductionsDataGridViewTextBoxColumn.ReadOnly = true;
            this.deductionsDataGridViewTextBoxColumn.Width = 104;
            // 
            // netAmountDataGridViewTextBoxColumn
            // 
            this.netAmountDataGridViewTextBoxColumn.DataPropertyName = "NetAmount";
            this.netAmountDataGridViewTextBoxColumn.HeaderText = "NetAmount";
            this.netAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.netAmountDataGridViewTextBoxColumn.Name = "netAmountDataGridViewTextBoxColumn";
            this.netAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.netAmountDataGridViewTextBoxColumn.Width = 102;
            // 
            // createdatDataGridViewTextBoxColumn1
            // 
            this.createdatDataGridViewTextBoxColumn1.DataPropertyName = "Created_at";
            this.createdatDataGridViewTextBoxColumn1.HeaderText = "Created_at";
            this.createdatDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.createdatDataGridViewTextBoxColumn1.Name = "createdatDataGridViewTextBoxColumn1";
            this.createdatDataGridViewTextBoxColumn1.ReadOnly = true;
            this.createdatDataGridViewTextBoxColumn1.Visible = false;
            this.createdatDataGridViewTextBoxColumn1.Width = 125;
            // 
            // remarksDataGridViewTextBoxColumn1
            // 
            this.remarksDataGridViewTextBoxColumn1.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn1.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.remarksDataGridViewTextBoxColumn1.Name = "remarksDataGridViewTextBoxColumn1";
            this.remarksDataGridViewTextBoxColumn1.ReadOnly = true;
            this.remarksDataGridViewTextBoxColumn1.Width = 91;
            // 
            // paymentStatusDataGridViewTextBoxColumn
            // 
            this.paymentStatusDataGridViewTextBoxColumn.DataPropertyName = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.HeaderText = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentStatusDataGridViewTextBoxColumn.Name = "paymentStatusDataGridViewTextBoxColumn";
            this.paymentStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentStatusDataGridViewTextBoxColumn.Width = 126;
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices";
            this.invoicesBindingSource.DataSource = this.billingSystemDataSet3;
            // 
            // billingSystemDataSet3
            // 
            this.billingSystemDataSet3.DataSetName = "BillingSystemDataSet3";
            this.billingSystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(602, 38);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 27);
            this.button2.TabIndex = 20;
            this.button2.Text = "View All";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReportsUI2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1619, 645);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "ReportsUI2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportsUI2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportsUI2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.generateReadingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingSystemDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingSystemDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BillingSystemDataSetTableAdapters.GenerateReadingsTableAdapter generateReadingsTableAdapter;
        private System.Windows.Forms.BindingSource generateReadingsBindingSource;
        private BillingSystemDataSet billingSystemDataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_ViewReport;
        private System.Windows.Forms.Label btn_Search;
        private System.Windows.Forms.TextBox txtbox_SearchReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_toReport;
        private System.Windows.Forms.DateTimePicker dtp_fromReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BillingSystemDataSet2 billingSystemDataSet2;
        private System.Windows.Forms.BindingSource collectionsBindingSource;
        private BillingSystemDataSet2TableAdapters.CollectionsTableAdapter collectionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeOwnerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penaltyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private BillingSystemDataSet3 billingSystemDataSet3;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private BillingSystemDataSet3TableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn transDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeOwnerIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deductionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}