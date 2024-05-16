namespace BillingSystem3._0
{
    partial class BillingUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.selectAll_checkbx = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgRecords = new System.Windows.Forms.DataGridView();
            this.dtgRecords2 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditInvoice = new System.Windows.Forms.Button();
            this.btnShowInvoices = new System.Windows.Forms.Button();
            this.dtgRecords3 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRecords2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRecords3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.selectAll_checkbx);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1581, 121);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search:";
            // 
            // selectAll_checkbx
            // 
            this.selectAll_checkbx.AutoSize = true;
            this.selectAll_checkbx.Location = new System.Drawing.Point(671, 92);
            this.selectAll_checkbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectAll_checkbx.Name = "selectAll_checkbx";
            this.selectAll_checkbx.Size = new System.Drawing.Size(85, 20);
            this.selectAll_checkbx.TabIndex = 10;
            this.selectAll_checkbx.Text = "Select All";
            this.selectAll_checkbx.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1089, 33);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "Print Invoice";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(909, 33);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 50);
            this.button3.TabIndex = 9;
            this.button3.Text = "Generate Bill";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(100, 43);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(431, 30);
            this.textBox1.TabIndex = 8;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.White;
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Location = new System.Drawing.Point(539, 43);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(116, 30);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgRecords);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 620);
            this.panel2.TabIndex = 1;
            // 
            // dtgRecords
            // 
            this.dtgRecords.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dtgRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgRecords.Location = new System.Drawing.Point(0, 0);
            this.dtgRecords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgRecords.Name = "dtgRecords";
            this.dtgRecords.ReadOnly = true;
            this.dtgRecords.RowHeadersWidth = 51;
            this.dtgRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRecords.Size = new System.Drawing.Size(744, 620);
            this.dtgRecords.TabIndex = 0;
            this.dtgRecords.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgRecords_MouseClick);
            // 
            // dtgRecords2
            // 
            this.dtgRecords2.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dtgRecords2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgRecords2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRecords2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgRecords2.Location = new System.Drawing.Point(0, 0);
            this.dtgRecords2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgRecords2.Name = "dtgRecords2";
            this.dtgRecords2.ReadOnly = true;
            this.dtgRecords2.RowHeadersWidth = 51;
            this.dtgRecords2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRecords2.Size = new System.Drawing.Size(830, 257);
            this.dtgRecords2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(744, 121);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 620);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgRecords2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(751, 121);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(830, 257);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkOrange;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.btnEditInvoice);
            this.panel5.Controls.Add(this.btnShowInvoices);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(751, 378);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(830, 69);
            this.panel5.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(33, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "History";
            // 
            // btnEditInvoice
            // 
            this.btnEditInvoice.BackColor = System.Drawing.Color.Gold;
            this.btnEditInvoice.FlatAppearance.BorderSize = 0;
            this.btnEditInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditInvoice.Location = new System.Drawing.Point(338, 20);
            this.btnEditInvoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditInvoice.Name = "btnEditInvoice";
            this.btnEditInvoice.Size = new System.Drawing.Size(160, 32);
            this.btnEditInvoice.TabIndex = 7;
            this.btnEditInvoice.Text = "Edit";
            this.btnEditInvoice.UseVisualStyleBackColor = false;
            this.btnEditInvoice.Click += new System.EventHandler(this.btnEditInvoice_Click);
            // 
            // btnShowInvoices
            // 
            this.btnShowInvoices.BackColor = System.Drawing.Color.Gold;
            this.btnShowInvoices.FlatAppearance.BorderSize = 0;
            this.btnShowInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowInvoices.Location = new System.Drawing.Point(158, 20);
            this.btnShowInvoices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowInvoices.Name = "btnShowInvoices";
            this.btnShowInvoices.Size = new System.Drawing.Size(159, 32);
            this.btnShowInvoices.TabIndex = 7;
            this.btnShowInvoices.Text = "Show";
            this.btnShowInvoices.UseVisualStyleBackColor = false;
            this.btnShowInvoices.Click += new System.EventHandler(this.btnShowInvoices_Click);
            // 
            // dtgRecords3
            // 
            this.dtgRecords3.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dtgRecords3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRecords3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgRecords3.Location = new System.Drawing.Point(751, 447);
            this.dtgRecords3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgRecords3.Name = "dtgRecords3";
            this.dtgRecords3.ReadOnly = true;
            this.dtgRecords3.RowHeadersWidth = 51;
            this.dtgRecords3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRecords3.Size = new System.Drawing.Size(830, 294);
            this.dtgRecords3.TabIndex = 7;
            // 
            // BillingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 741);
            this.Controls.Add(this.dtgRecords3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BillingUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillingUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BillingUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRecords2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRecords3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox selectAll_checkbx;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgRecords;
        private System.Windows.Forms.DataGridView dtgRecords2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowInvoices;
        private System.Windows.Forms.DataGridView dtgRecords3;
        private System.Windows.Forms.Button btnEditInvoice;
    }
}