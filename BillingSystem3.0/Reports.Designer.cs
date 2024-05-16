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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 100);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(602, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 54);
            this.button1.TabIndex = 17;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_ViewReport
            // 
            this.btn_ViewReport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ViewReport.Location = new System.Drawing.Point(238, 36);
            this.btn_ViewReport.Name = "btn_ViewReport";
            this.btn_ViewReport.Size = new System.Drawing.Size(75, 38);
            this.btn_ViewReport.TabIndex = 16;
            this.btn_ViewReport.Text = "View";
            this.btn_ViewReport.UseVisualStyleBackColor = false;
            // 
            // btn_Search
            // 
            this.btn_Search.AutoSize = true;
            this.btn_Search.Location = new System.Drawing.Point(18, 49);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(44, 13);
            this.btn_Search.TabIndex = 15;
            this.btn_Search.Text = "Search:";
            // 
            // txtbox_SearchReport
            // 
            this.txtbox_SearchReport.Location = new System.Drawing.Point(68, 44);
            this.txtbox_SearchReport.Name = "txtbox_SearchReport";
            this.txtbox_SearchReport.Size = new System.Drawing.Size(164, 20);
            this.txtbox_SearchReport.TabIndex = 14;
            // 
            // btn_PrintReport
            // 
            this.btn_PrintReport.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_PrintReport.Location = new System.Drawing.Point(722, 27);
            this.btn_PrintReport.Name = "btn_PrintReport";
            this.btn_PrintReport.Size = new System.Drawing.Size(107, 54);
            this.btn_PrintReport.TabIndex = 13;
            this.btn_PrintReport.Text = "Print Report";
            this.btn_PrintReport.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Date to:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date from:";
            // 
            // dtp_toReport
            // 
            this.dtp_toReport.Location = new System.Drawing.Point(396, 62);
            this.dtp_toReport.Name = "dtp_toReport";
            this.dtp_toReport.Size = new System.Drawing.Size(200, 20);
            this.dtp_toReport.TabIndex = 10;
            // 
            // dtp_fromReport
            // 
            this.dtp_fromReport.Location = new System.Drawing.Point(396, 28);
            this.dtp_fromReport.Name = "dtp_fromReport";
            this.dtp_fromReport.Size = new System.Drawing.Size(200, 20);
            this.dtp_fromReport.TabIndex = 9;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 603);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Reports";
            this.Text = "Reports";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}