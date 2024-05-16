namespace BillingSystem3._0
{
    partial class ReadingsUI
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddReading = new System.Windows.Forms.Button();
            this.btnGenerateReading = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgRecords = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalRecords);
            this.groupBox2.Location = new System.Drawing.Point(855, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(491, 95);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblTotalRecords.Location = new System.Drawing.Point(15, 33);
            this.lblTotalRecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(300, 36);
            this.lblTotalRecords.TabIndex = 0;
            this.lblTotalRecords.Text = "TOTAL RECORDS: 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnAddReading);
            this.groupBox1.Controls.Add(this.btnGenerateReading);
            this.groupBox1.Location = new System.Drawing.Point(16, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(831, 95);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gold;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(587, 23);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(222, 54);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddReading
            // 
            this.btnAddReading.BackColor = System.Drawing.Color.Gold;
            this.btnAddReading.FlatAppearance.BorderSize = 0;
            this.btnAddReading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReading.Location = new System.Drawing.Point(302, 23);
            this.btnAddReading.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddReading.Name = "btnAddReading";
            this.btnAddReading.Size = new System.Drawing.Size(265, 54);
            this.btnAddReading.TabIndex = 0;
            this.btnAddReading.Text = "Edit Reading";
            this.btnAddReading.UseVisualStyleBackColor = false;
            this.btnAddReading.Click += new System.EventHandler(this.btnAddReading_Click);
            // 
            // btnGenerateReading
            // 
            this.btnGenerateReading.BackColor = System.Drawing.Color.Gold;
            this.btnGenerateReading.FlatAppearance.BorderSize = 0;
            this.btnGenerateReading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReading.Location = new System.Drawing.Point(21, 23);
            this.btnGenerateReading.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerateReading.Name = "btnGenerateReading";
            this.btnGenerateReading.Size = new System.Drawing.Size(255, 54);
            this.btnGenerateReading.TabIndex = 0;
            this.btnGenerateReading.Text = "Generate Reading";
            this.btnGenerateReading.UseVisualStyleBackColor = false;
            this.btnGenerateReading.Click += new System.EventHandler(this.btnGenerateReading_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1359, 110);
            this.panel1.TabIndex = 4;
            // 
            // dtgRecords
            // 
            this.dtgRecords.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dtgRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgRecords.GridColor = System.Drawing.Color.White;
            this.dtgRecords.Location = new System.Drawing.Point(0, 110);
            this.dtgRecords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgRecords.Name = "dtgRecords";
            this.dtgRecords.ReadOnly = true;
            this.dtgRecords.RowHeadersWidth = 51;
            this.dtgRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRecords.Size = new System.Drawing.Size(1359, 638);
            this.dtgRecords.TabIndex = 5;
            // 
            // ReadingsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 748);
            this.Controls.Add(this.dtgRecords);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReadingsUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReadingsUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReadingsUI_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddReading;
        private System.Windows.Forms.Button btnGenerateReading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgRecords;
    }
}