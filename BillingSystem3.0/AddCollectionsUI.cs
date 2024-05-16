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
    public partial class AddCollectionsUI : Form
    {
        Collections collection;
        SqlConnection conn;
        SqlCommand cmd;
        public AddCollectionsUI()
        {
            InitializeComponent();
        }

        public AddCollectionsUI(Collections collection, string type) : this()
        {
            if (type == "save")
            {
                txtGrossPayment.Text = collection.GrossPayment.ToString();
                txtHomeOwner.Text = collection.FullName;
                this.collection = collection;
                Calculations();
            }
            else
            {
               
                btnSave.Text = "Update";
               
            }

        }
        public void Calculations()
        {
            decimal grossAmount = Convert.ToDecimal(txtGrossPayment.Text);
            decimal penalty = Convert.ToDecimal(txtPenalty.Text);
            decimal netPayment = grossAmount + penalty;
            txtNetPayment.Text = netPayment.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Collections data = GetData();
            string query = "";
            string msg = "Saved";
            if (btnSave.Text == "Save")
            {
                query = $"insert into Collections (InvoiceId,HomeOwnerId,FullName,TransDate,ORNo,GrossPayment,Penalty,NetPayment,Remarks,Created_at) VALUES(" +
                    $"@InvoiceId," +
                    $"@HomeOwnerId," +
                    $"@FullName," +
                    $"@TransDate," +
                    $"@ORNo," +
                    $"@GrossPayment," +
                    $"@Penalty," +
                    $"@NetPayment," +
                    $"@Remarks," +
                    $"@Created_at " +
                    $") SELECT SCOPE_IDENTITY();";
            }
            else
            {
                msg = "Updated";
                query = $"update HomeOwners set FullName=@FullName, " +
                    $"ContactNo=@ContactNo, " +
                    $"Email=@Email, " +
                    $"PhaseName=@PhaseName, " +
                    $"Block=@Block, " +
                    $"Lot=@Lot, " +
                    $"MoveInDate=@MoveInDate, " +
                    $"Created_at=@Created_at, " +
                    $"LastReading=@LastReading, " +
                    $"PreviousReading=@PreviousReading, " +
                    $"LastCollected=@LastCollected, " +
                    $"WaterServiceStatus=@WaterServiceStatus," +
                    $"GarbageCollectionStatus=@GarbageCollectionStatus, " +
                    $"GarbageCollectionFee=@GarbageCollectionFee " +
                    $"where HomeOwnerId='{collection.CollectionId}'";
            }
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@InvoiceId", data.InvoiceId);
            cmd.Parameters.AddWithValue("@HomeOwnerId", data.HomeOwnerId);
            cmd.Parameters.AddWithValue("@FullName", data.FullName);
            cmd.Parameters.AddWithValue("@TransDate", data.TransDate);
            cmd.Parameters.AddWithValue("@ORNo", data.ORNo);
            cmd.Parameters.AddWithValue("@GrossPayment", data.GrossPayment);
            cmd.Parameters.AddWithValue("@Penalty", data.Penalty);
            cmd.Parameters.AddWithValue("@NetPayment", data.NetPayment);
            cmd.Parameters.AddWithValue("@Remarks", data.Remarks);
            cmd.Parameters.AddWithValue("@Created_at", DateTime.Now);

            conn.Open();
            int ifSuccess = cmd.ExecuteNonQuery();
            if (ifSuccess > 0 && btnSave.Text == "Save")
            {
                string additionalQuery2 = "UPDATE Invoices SET PaymentStatus = @PaymentStatus WHERE InvoiceId = @InvoiceId";
                SqlCommand additionalCommand2 = new SqlCommand(additionalQuery2, conn);
                additionalCommand2.Parameters.AddWithValue("@PaymentStatus", "paid");
                additionalCommand2.Parameters.AddWithValue("@InvoiceId", data.InvoiceId);
                additionalCommand2.ExecuteNonQuery();
            }
            conn.Close();
            MessageBox.Show("Successfully " + msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
        private Collections GetData()
        {
            return new Collections
            {
                InvoiceId = collection.InvoiceId,
                TransDate = dtTransDate.Value.Date,
                HomeOwnerId = collection.HomeOwnerId,
                FullName = txtHomeOwner.Text,
                ORNo = txtORNo.Text,
                GrossPayment = Convert.ToDecimal(txtGrossPayment.Text),
                Penalty = Convert.ToDecimal(txtPenalty.Text),
                NetPayment = Convert.ToDecimal(txtNetPayment.Text),
                Created_at = DateTime.Now,
                Remarks = txtRemarks.Text,
            };
        }
        private void txtPenalty_TextChanged(object sender, EventArgs e)
        {
            Calculations();
        }

        private void AddCollectionsUI_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(dbServer.ServerName);
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }
    }
}
