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
        SqlConnection conn;
        SqlCommand cmd;
        public AddBillingUI()
        {
            InitializeComponent();
        }
        public AddBillingUI(Invoices invoice,string type) : this()
        {
            if(type == "save")
            {
                this.invoice.HomeOwnerId = invoice.HomeOwnerId;
                txtHomeOwnerName.Text = invoice.FullName;
                txtGrossAmount.Text = invoice.NetAmount.ToString();
                Calculations();
            }
            else
            {
                this.invoice = invoice;
                btnSave.Text = "Update";
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
                query = $"insert into Invoices (TransDate,HomeOwnerId,FullName,GrossAmount,Deductions,NetAmount,Created_at,Remarks) VALUES(" +
                    $"@TransDate," +
                    $"@HomeOwnerId," +
                    $"@FullName," +
                    $"@GrossAmount," +
                    $"@Deductions," +
                    $"@NetAmount," +
                    $"@Created_at," +
                    $"@Remarks" +
                    $")";
            }
            else
            {
                msg = "Updated";
                query = $"update Invoices set " +
                   $"@TransDate," +
                    $"@HomeOwnerId," +
                    $"@FullName," +
                    $"@GrossAmount," +
                    $"@Deductions," +
                    $"@NetAmount," +
                    $"@Created_at," +
                    $"Remarks=@Remarks " +
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
            cmd.ExecuteNonQuery();
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
