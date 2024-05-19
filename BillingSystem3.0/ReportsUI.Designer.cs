namespace BillingSystem3._0
{
    partial class ReportsUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ViewReport = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Label();
            this.txtbox_SearchReport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_toReport = new System.Windows.Forms.DateTimePicker();
            this.dtp_fromReport = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.billingSystemDataSet = new BillingSystem3._0.BillingSystemDataSet();
            this.generateReadingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generateReadingsTableAdapter = new BillingSystem3._0.BillingSystemDataSetTableAdapters.GenerateReadingsTableAdapter();
            this.readingIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeOwnerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phaseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastReadingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previousReadingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterServiceStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentReadingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varianceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateReadingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
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
            this.panel1.Size = new System.Drawing.Size(1359, 102);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1082, 28);
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
            this.label2.Location = new System.Drawing.Point(704, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Date to:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(689, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date from:";
            // 
            // dtp_toReport
            // 
            this.dtp_toReport.Location = new System.Drawing.Point(765, 57);
            this.dtp_toReport.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_toReport.Name = "dtp_toReport";
            this.dtp_toReport.Size = new System.Drawing.Size(265, 22);
            this.dtp_toReport.TabIndex = 10;
            this.dtp_toReport.ValueChanged += new System.EventHandler(this.dtp_toReport_ValueChanged);
            // 
            // dtp_fromReport
            // 
            this.dtp_fromReport.Location = new System.Drawing.Point(765, 23);
            this.dtp_fromReport.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_fromReport.Name = "dtp_fromReport";
            this.dtp_fromReport.Size = new System.Drawing.Size(265, 22);
            this.dtp_fromReport.TabIndex = 9;
            this.dtp_fromReport.ValueChanged += new System.EventHandler(this.dtp_fromReport_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.readingIdDataGridViewTextBoxColumn,
            this.homeOwnerIdDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.phaseNameDataGridViewTextBoxColumn,
            this.blockDataGridViewTextBoxColumn,
            this.lotDataGridViewTextBoxColumn,
            this.lastReadingDataGridViewTextBoxColumn,
            this.previousReadingDataGridViewTextBoxColumn,
            this.waterServiceStatusDataGridViewTextBoxColumn,
            this.currentReadingDataGridViewTextBoxColumn,
            this.varianceDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.readingDateDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn,
            this.paymentStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.generateReadingsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1359, 692);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // billingSystemDataSet
            // 
            this.billingSystemDataSet.DataSetName = "BillingSystemDataSet";
            this.billingSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generateReadingsBindingSource
            // 
            this.generateReadingsBindingSource.DataMember = "GenerateReadings";
            this.generateReadingsBindingSource.DataSource = this.billingSystemDataSet;
            // 
            // generateReadingsTableAdapter
            // 
            this.generateReadingsTableAdapter.ClearBeforeFill = true;
            // 
            // readingIdDataGridViewTextBoxColumn
            // 
            this.readingIdDataGridViewTextBoxColumn.DataPropertyName = "ReadingId";
            this.readingIdDataGridViewTextBoxColumn.HeaderText = "ReadingId";
            this.readingIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.readingIdDataGridViewTextBoxColumn.Name = "readingIdDataGridViewTextBoxColumn";
            this.readingIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.readingIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // homeOwnerIdDataGridViewTextBoxColumn
            // 
            this.homeOwnerIdDataGridViewTextBoxColumn.DataPropertyName = "HomeOwnerId";
            this.homeOwnerIdDataGridViewTextBoxColumn.HeaderText = "HomeOwnerId";
            this.homeOwnerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.homeOwnerIdDataGridViewTextBoxColumn.Name = "homeOwnerIdDataGridViewTextBoxColumn";
            this.homeOwnerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phaseNameDataGridViewTextBoxColumn
            // 
            this.phaseNameDataGridViewTextBoxColumn.DataPropertyName = "PhaseName";
            this.phaseNameDataGridViewTextBoxColumn.HeaderText = "PhaseName";
            this.phaseNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phaseNameDataGridViewTextBoxColumn.Name = "phaseNameDataGridViewTextBoxColumn";
            this.phaseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // blockDataGridViewTextBoxColumn
            // 
            this.blockDataGridViewTextBoxColumn.DataPropertyName = "Block";
            this.blockDataGridViewTextBoxColumn.HeaderText = "Block";
            this.blockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.blockDataGridViewTextBoxColumn.Name = "blockDataGridViewTextBoxColumn";
            this.blockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lotDataGridViewTextBoxColumn
            // 
            this.lotDataGridViewTextBoxColumn.DataPropertyName = "Lot";
            this.lotDataGridViewTextBoxColumn.HeaderText = "Lot";
            this.lotDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lotDataGridViewTextBoxColumn.Name = "lotDataGridViewTextBoxColumn";
            this.lotDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastReadingDataGridViewTextBoxColumn
            // 
            this.lastReadingDataGridViewTextBoxColumn.DataPropertyName = "LastReading";
            this.lastReadingDataGridViewTextBoxColumn.HeaderText = "LastReading";
            this.lastReadingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastReadingDataGridViewTextBoxColumn.Name = "lastReadingDataGridViewTextBoxColumn";
            this.lastReadingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // previousReadingDataGridViewTextBoxColumn
            // 
            this.previousReadingDataGridViewTextBoxColumn.DataPropertyName = "PreviousReading";
            this.previousReadingDataGridViewTextBoxColumn.HeaderText = "PreviousReading";
            this.previousReadingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.previousReadingDataGridViewTextBoxColumn.Name = "previousReadingDataGridViewTextBoxColumn";
            this.previousReadingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // waterServiceStatusDataGridViewTextBoxColumn
            // 
            this.waterServiceStatusDataGridViewTextBoxColumn.DataPropertyName = "WaterServiceStatus";
            this.waterServiceStatusDataGridViewTextBoxColumn.HeaderText = "WaterServiceStatus";
            this.waterServiceStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.waterServiceStatusDataGridViewTextBoxColumn.Name = "waterServiceStatusDataGridViewTextBoxColumn";
            this.waterServiceStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentReadingDataGridViewTextBoxColumn
            // 
            this.currentReadingDataGridViewTextBoxColumn.DataPropertyName = "CurrentReading";
            this.currentReadingDataGridViewTextBoxColumn.HeaderText = "CurrentReading";
            this.currentReadingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currentReadingDataGridViewTextBoxColumn.Name = "currentReadingDataGridViewTextBoxColumn";
            this.currentReadingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // varianceDataGridViewTextBoxColumn
            // 
            this.varianceDataGridViewTextBoxColumn.DataPropertyName = "Variance";
            this.varianceDataGridViewTextBoxColumn.HeaderText = "Variance";
            this.varianceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.varianceDataGridViewTextBoxColumn.Name = "varianceDataGridViewTextBoxColumn";
            this.varianceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // readingDateDataGridViewTextBoxColumn
            // 
            this.readingDateDataGridViewTextBoxColumn.DataPropertyName = "ReadingDate";
            this.readingDateDataGridViewTextBoxColumn.HeaderText = "ReadingDate";
            this.readingDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.readingDateDataGridViewTextBoxColumn.Name = "readingDateDataGridViewTextBoxColumn";
            this.readingDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "Created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "Created_at";
            this.createdatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            this.createdatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentStatusDataGridViewTextBoxColumn
            // 
            this.paymentStatusDataGridViewTextBoxColumn.DataPropertyName = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.HeaderText = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentStatusDataGridViewTextBoxColumn.Name = "paymentStatusDataGridViewTextBoxColumn";
            this.paymentStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ReportsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1359, 794);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "ReportsUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportsUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportsUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateReadingsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_ViewReport;
        private System.Windows.Forms.Label btn_Search;
        private System.Windows.Forms.TextBox txtbox_SearchReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_toReport;
        private System.Windows.Forms.DateTimePicker dtp_fromReport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BillingSystemDataSet billingSystemDataSet;
        private System.Windows.Forms.BindingSource generateReadingsBindingSource;
        private BillingSystemDataSetTableAdapters.GenerateReadingsTableAdapter generateReadingsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn readingIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeOwnerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phaseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastReadingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn previousReadingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waterServiceStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentReadingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varianceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn readingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentStatusDataGridViewTextBoxColumn;
    }
}