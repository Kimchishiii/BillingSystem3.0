using BillingSystem3._0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem3._0
{
    public partial class AddBillingUI : Form
    {
        Invoices invoice = new Invoices();
        List<InvoiceDetails> invoiceDetails;
        SqlConnection conn;
        SqlCommand cmd;
        public AddBillingUI()
        {
            InitializeComponent();
        }
        public AddBillingUI(Invoices invoice,string type, List<InvoiceDetails> invoiceDetails) : this()
        {
            if(type == "save")
            {
                this.invoice.HomeOwnerId = invoice.HomeOwnerId;
                txtHomeOwnerName.Text = invoice.FullName;
                txtGrossAmount.Text = invoice.NetAmount.ToString();
                Calculations();
                this.invoiceDetails = invoiceDetails;
            }
            else
            {
                this.invoice = invoice;
                btnSave.Text = "Update";
                DisplayRecords();
            }
           
        }

        public void Calculations()
        {
            if (txtDeductions.Text == "") return;
            decimal grossAmount = Convert.ToDecimal(txtGrossAmount.Text);
            decimal deductions = Convert.ToDecimal(txtDeductions.Text);
            decimal netAmount = grossAmount - deductions;
            txtTotalAmount.Text = netAmount.ToString();
        }
        public void DisplayRecords()
        {
            dtTransDate.Value = invoice.TransDate;
            txtHomeOwnerName.Text = invoice.FullName;
            txtGrossAmount.Text = invoice.GrossAmount.ToString();
            txtDeductions.Text = invoice.Deductions.ToString();
            txtTotalAmount.Text = invoice.NetAmount.ToString();
            txtRemarks.Text = invoice.Remarks.ToString();

        }
        private void AddBillingUI_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(dbServer.ServerName);
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Invoices data = GetData();
            string query = "";
            string msg = "Saved";
            if (btnSave.Text == "Save")
            {
                query = $"insert into Invoices (TransDate,HomeOwnerId,FullName,GrossAmount,Deductions,NetAmount,Created_at,Remarks,PaymentStatus) VALUES(" +
                    $"@TransDate," +
                    $"@HomeOwnerId," +
                    $"@FullName," +
                    $"@GrossAmount," +
                    $"@Deductions," +
                    $"@NetAmount," +
                    $"@Created_at," +
                    $"@Remarks, " +
                    $"'unpaid'" +
                    $") SELECT SCOPE_IDENTITY()";
            }
            else
            {
                msg = "Updated";
                query = $"update Invoices set " +
                   $"TransDate=@TransDate," +
                    $"HomeOwnerId=@HomeOwnerId," +
                    $"FullName=@FullName," +
                    $"GrossAmount=@GrossAmount," +
                    $"Deductions=@Deductions," +
                    $"NetAmount=@NetAmount," +
                    $"Created_at=@Created_at," +
                    $"Remarks=@Remarks" +
                    $"where InvoiceId='{invoice.InvoiceId}'";
            }
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@TransDate", data.TransDate);
            cmd.Parameters.AddWithValue("@HomeOwnerId", data.HomeOwnerId);
            cmd.Parameters.AddWithValue("@FullName", data.FullName);
            cmd.Parameters.AddWithValue("@GrossAmount", data.GrossAmount);
            cmd.Parameters.AddWithValue("@Deductions", data.Deductions);
            cmd.Parameters.AddWithValue("@NetAmount", data.NetAmount);
            cmd.Parameters.AddWithValue("@Remarks", data.Remarks);
            cmd.Parameters.AddWithValue("@Created_at", DateTime.Now);

            conn.Open();
            var rowsaffected = cmd.ExecuteScalar();
            if(rowsaffected != null && btnSave.Text == "Save")
            {
                foreach(var detail in invoiceDetails)
                {
                    string additionalQuery = "INSERT INTO InvoiceDetails (InvoiceId,HomeOwnerId,FullName,Type,Amount) VALUES(" +
                        "@InvoiceId," +
                        "@HomeOwnerId," +
                        "@FullName," +
                        "@Type," +
                        "@Amount)";
                    SqlCommand additionalCommand = new SqlCommand(additionalQuery, conn);
                    additionalCommand.Parameters.AddWithValue("@InvoiceId", Convert.ToInt32(rowsaffected));
                    additionalCommand.Parameters.AddWithValue("@HomeOwnerId", detail.HomeOwnerId);
                    additionalCommand.Parameters.AddWithValue("@FullName", detail.FullName);
                    additionalCommand.Parameters.AddWithValue("@Type", detail.Type);
                    additionalCommand.Parameters.AddWithValue("@Amount", detail.TotalAmount);
                    additionalCommand.ExecuteNonQuery();   
                }
                
                string additionalQuery2 = "UPDATE GenerateReadings SET PaymentStatus = @PaymentStatus WHERE HomeOwnerId = @homeOwnerId";
                SqlCommand additionalCommand2 = new SqlCommand(additionalQuery2, conn);
                additionalCommand2.Parameters.AddWithValue("@PaymentStatus","paid");
                additionalCommand2.Parameters.AddWithValue("@HomeOwnerId", data.HomeOwnerId);
                additionalCommand2.ExecuteNonQuery();

                string additionalQuery3 = "UPDATE HomeOwners SET LastCollected = @LastCollected WHERE HomeOwnerId = @homeOwnerId";
                SqlCommand additionalCommand3 = new SqlCommand(additionalQuery3, conn);
                additionalCommand3.Parameters.AddWithValue("@LastCollected", DateTime.Now);
                additionalCommand3.Parameters.AddWithValue("@HomeOwnerId", data.HomeOwnerId);
                additionalCommand3.ExecuteNonQuery();

            }
            conn.Close();
            MessageBox.Show("Successfully " + msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
        private Invoices GetData()
        {
            return new Invoices
            {
                TransDate = dtTransDate.Value.Date,
                HomeOwnerId = invoice.HomeOwnerId,
                FullName = txtHomeOwnerName.Text,
                GrossAmount = Convert.ToDecimal(txtGrossAmount.Text),
                Deductions = Convert.ToDecimal(txtDeductions.Text),
                NetAmount = Convert.ToDecimal(txtTotalAmount.Text),
                Created_at = DateTime.Now,
                Remarks = txtRemarks.Text
                
            };
        }
        private void txtDeductions_TextChanged(object sender, EventArgs e)
        {
            Calculations();
        }
    }
}
