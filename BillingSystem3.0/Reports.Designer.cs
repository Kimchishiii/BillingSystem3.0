namespace BillingSystem3._0
{
    partial class Reports
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ViewReport = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Label();
            this.txtbox_SearchReport = new System.Windows.Forms.TextBox();
            this.btn_PrintReport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_toReport = new System.Windows.Forms.DateTimePicker();
            this.dtp_fromReport = new System.Windows.Forms.DateTimePicker();
            this.dtgReports = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReports)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_ViewReport);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.txtbox_SearchReport);
            this.panel1.Controls.Add(this.btn_PrintReport);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtp_toReport);
            this.panel1.Controls.Add(this.dtp_fromReport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 123);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(838, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 46);
            this.button1.TabIndex = 17;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_ViewReport
            // 
            this.btn_ViewReport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ViewReport.FlatAppearance.BorderSize = 0;
            this.btn_ViewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewReport.Location = new System.Drawing.Point(342, 53);
            this.btn_ViewReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ViewReport.Name = "btn_ViewReport";
            this.btn_ViewReport.Size = new System.Drawing.Size(75, 27);
            this.btn_ViewReport.TabIndex = 16;
            this.btn_ViewReport.Text = "View";
            this.btn_ViewReport.UseVisualStyleBackColor = false;
            this.btn_ViewReport.Click += new System.EventHandler(this.btn_ViewReport_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.AutoSize = true;
            this.btn_Search.Location = new System.Drawing.Point(13, 60);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(53, 16);
            this.btn_Search.TabIndex = 15;
            this.btn_Search.Text = "Search:";
            // 
            // txtbox_SearchReport
            // 
            this.txtbox_SearchReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_SearchReport.Location = new System.Drawing.Point(74, 53);
            this.txtbox_SearchReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbox_SearchReport.Name = "txtbox_SearchReport";
            this.txtbox_SearchReport.Size = new System.Drawing.Size(260, 27);
            this.txtbox_SearchReport.TabIndex = 14;
            // 
            // btn_PrintReport
            // 
            this.btn_PrintReport.BackColor = System.Drawing.Color.Gold;
            this.btn_PrintReport.FlatAppearance.BorderSize = 0;
            this.btn_PrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PrintReport.Location = new System.Drawing.Point(986, 40);
            this.btn_PrintReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_PrintReport.Name = "btn_PrintReport";
            this.btn_PrintReport.Size = new System.Drawing.Size(143, 46);
            this.btn_PrintReport.TabIndex = 13;
            this.btn_PrintReport.Text = "Print Report";
            this.btn_PrintReport.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Date to:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date from:";
            // 
            // dtp_toReport
            // 
            this.dtp_toReport.Location = new System.Drawing.Point(528, 76);
            this.dtp_toReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_toReport.Name = "dtp_toReport";
            this.dtp_toReport.Size = new System.Drawing.Size(265, 22);
            this.dtp_toReport.TabIndex = 10;
            // 
            // dtp_fromReport
            // 
            this.dtp_fromReport.Location = new System.Drawing.Point(528, 34);
            this.dtp_fromReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_fromReport.Name = "dtp_fromReport";
            this.dtp_fromReport.Size = new System.Drawing.Size(265, 22);
            this.dtp_fromReport.TabIndex = 9;
            // 
            // dtgReports
            // 
            this.dtgReports.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dtgReports.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgReports.GridColor = System.Drawing.Color.White;
            this.dtgReports.Location = new System.Drawing.Point(0, 123);
            this.dtgReports.Margin = new System.Windows.Forms.Padding(4);
            this.dtgReports.Name = "dtgReports";
            this.dtgReports.ReadOnly = true;
            this.dtgReports.RowHeadersWidth = 51;
            this.dtgReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgReports.Size = new System.Drawing.Size(1164, 619);
            this.dtgReports.TabIndex = 3;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1164, 742);
            this.Controls.Add(this.dtgReports);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Reports";
            this.Text = "Reports";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_ViewReport;
        private System.Windows.Forms.Label btn_Search;
        private System.Windows.Forms.TextBox txtbox_SearchReport;
        private System.Windows.Forms.Button btn_PrintReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_toReport;
        private System.Windows.Forms.DateTimePicker dtp_fromReport;
        private System.Windows.Forms.DataGridView dtgReports;
    }
}