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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRecords2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.selectAll_checkbx);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 98);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search:";
            // 
            // selectAll_checkbx
            // 
            this.selectAll_checkbx.AutoSize = true;
            this.selectAll_checkbx.Location = new System.Drawing.Point(503, 75);
            this.selectAll_checkbx.Name = "selectAll_checkbx";
            this.selectAll_checkbx.Size = new System.Drawing.Size(70, 17);
            this.selectAll_checkbx.TabIndex = 10;
            this.selectAll_checkbx.Text = "Select All";
            this.selectAll_checkbx.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(732, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 54);
            this.button2.TabIndex = 6;
            this.button2.Text = "Print Invoice";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(589, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 54);
            this.button3.TabIndex = 9;
            this.button3.Text = "Generate Bill";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(75, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 26);
            this.textBox1.TabIndex = 8;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(291, 35);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(87, 26);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgRecords);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 467);
            this.panel2.TabIndex = 1;
            // 
            // dtgRecords
            // 
            this.dtgRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgRecords.Location = new System.Drawing.Point(0, 0);
            this.dtgRecords.Name = "dtgRecords";
            this.dtgRecords.ReadOnly = true;
            this.dtgRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRecords.Size = new System.Drawing.Size(558, 467);
            this.dtgRecords.TabIndex = 0;
            this.dtgRecords.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgRecords_MouseClick);
            // 
            // dtgRecords2
            // 
            this.dtgRecords2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgRecords2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRecords2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgRecords2.Location = new System.Drawing.Point(558, 98);
            this.dtgRecords2.Name = "dtgRecords2";
            this.dtgRecords2.ReadOnly = true;
            this.dtgRecords2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRecords2.Size = new System.Drawing.Size(600, 467);
            this.dtgRecords2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(558, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 467);
            this.panel3.TabIndex = 3;
            // 
            // BillingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 565);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dtgRecords2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
    }
}