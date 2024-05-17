namespace BillingSystem3._0
{
    partial class AddCollectionsUI
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
            this.txtORNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTransDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHomeOwner = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGrossPayment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPenalty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNetPayment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtORNo
            // 
            this.txtORNo.Location = new System.Drawing.Point(142, 65);
            this.txtORNo.Name = "txtORNo";
            this.txtORNo.Size = new System.Drawing.Size(262, 26);
            this.txtORNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ORNo:";
            // 
            // dtTransDate
            // 
            this.dtTransDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTransDate.Location = new System.Drawing.Point(142, 31);
            this.dtTransDate.Name = "dtTransDate";
            this.dtTransDate.Size = new System.Drawing.Size(262, 26);
            this.dtTransDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "TransDate:";
            // 
            // txtHomeOwner
            // 
            this.txtHomeOwner.Location = new System.Drawing.Point(142, 94);
            this.txtHomeOwner.Name = "txtHomeOwner";
            this.txtHomeOwner.ReadOnly = true;
            this.txtHomeOwner.Size = new System.Drawing.Size(262, 26);
            this.txtHomeOwner.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "HomeOwner:";
            // 
            // txtGrossPayment
            // 
            this.txtGrossPayment.Location = new System.Drawing.Point(142, 123);
            this.txtGrossPayment.Name = "txtGrossPayment";
            this.txtGrossPayment.ReadOnly = true;
            this.txtGrossPayment.Size = new System.Drawing.Size(262, 26);
            this.txtGrossPayment.TabIndex = 0;
            this.txtGrossPayment.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "GrossPayment:";
            // 
            // txtPenalty
            // 
            this.txtPenalty.Location = new System.Drawing.Point(142, 152);
            this.txtPenalty.Name = "txtPenalty";
            this.txtPenalty.Size = new System.Drawing.Size(262, 26);
            this.txtPenalty.TabIndex = 0;
            this.txtPenalty.Text = "0.00";
            this.txtPenalty.TextChanged += new System.EventHandler(this.txtPenalty_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Penalty:";
            // 
            // txtNetPayment
            // 
            this.txtNetPayment.Location = new System.Drawing.Point(142, 181);
            this.txtNetPayment.Name = "txtNetPayment";
            this.txtNetPayment.ReadOnly = true;
            this.txtNetPayment.Size = new System.Drawing.Size(262, 26);
            this.txtNetPayment.TabIndex = 0;
            this.txtNetPayment.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "NetPayment:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(142, 210);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(262, 125);
            this.txtRemarks.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Remarks:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(48, 355);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(355, 55);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddCollectionsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 424);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtTransDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtNetPayment);
            this.Controls.Add(this.txtPenalty);
            this.Controls.Add(this.txtGrossPayment);
            this.Controls.Add(this.txtHomeOwner);
            this.Controls.Add(this.txtORNo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddCollectionsUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCollectionsUI";
            this.Load += new System.EventHandler(this.AddCollectionsUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtORNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTransDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHomeOwner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGrossPayment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPenalty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNetPayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
    }
}