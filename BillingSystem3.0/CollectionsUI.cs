using BillingSystem3._0.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BillingSystem3._0
{
    public partial class CollectionsUI : Form
    {
        List<Collections> collections;
        List<Invoices> invoices;
        SqlConnection conn;
        SqlCommand cmd;

        public CollectionsUI()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            FetchInvoices();
        }

        private void btnAddCollection_Click(object sender, EventArgs e)
        {
            Collections data = GetData();
            AddCollectionsUI display = new AddCollectionsUI(data, "save");
            display.ShowDialog();
            FetchCollections();
            FetchInvoices();
        }

        private Collections GetData()
        {
            DataGridViewRow selectedRow = dtgRecords.CurrentRow;
            return new Collections
            {
                InvoiceId = Convert.ToInt32(selectedRow.Cells["InvoiceId"].Value),
                HomeOwnerId = Convert.ToInt32(selectedRow.Cells["HomeOwnerId"].Value),
                FullName = selectedRow.Cells["FullName"].Value.ToString(),
                GrossPayment = Convert.ToDecimal(selectedRow.Cells["NetAmount"].Value),
            };
        }

        public void FetchInvoices()
        {
            string selectquery = "select * from Invoices where PaymentStatus='unpaid'";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, conn);
            DataTable table = new DataTable();
            adpt.Fill(table);
            invoices = new List<Invoices>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                Invoices invoice = new Invoices();
                invoice.InvoiceId = Convert.ToInt32(table.Rows[i]["InvoiceId"]);
                invoice.HomeOwnerId = Convert.ToInt32(table.Rows[i]["HomeOwnerId"]);
                invoice.FullName = Convert.ToString(table.Rows[i]["FullName"]);
                invoice.TransDate = Convert.ToDateTime(table.Rows[i]["TransDate"]);
                invoice.GrossAmount = Convert.ToDecimal(table.Rows[i]["GrossAmount"]);
                invoice.Deductions = Convert.ToDecimal(table.Rows[i]["Deductions"]);
                invoice.NetAmount = Convert.ToDecimal(table.Rows[i]["NetAmount"]);
                invoice.Remarks = Convert.ToString(table.Rows[i]["Remarks"]);
                invoice.Created_at = Convert.ToDateTime(table.Rows[i]["Created_at"]);
                invoice.PaymentStatus = Convert.ToString(table.Rows[i]["PaymentStatus"]);
                invoices.Add(invoice);
            }
            dtgRecords.DataSource = invoices;
            LimitDataGridView();
        }

        public void FetchCollections()
        {
            string selectquery = "select * from Collections";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, conn);
            DataTable table = new DataTable();
            adpt.Fill(table);
            collections = new List<Collections>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                Collections collection = new Collections();
                collection.CollectionId = Convert.ToInt32(table.Rows[i]["CollectionId"]);
                collection.InvoiceId = Convert.ToInt32(table.Rows[i]["InvoiceId"]);
                collection.HomeOwnerId = Convert.ToInt32(table.Rows[i]["HomeOwnerId"]);
                collection.FullName = Convert.ToString(table.Rows[i]["FullName"]);
                collection.TransDate = Convert.ToDateTime(table.Rows[i]["TransDate"]);
                collection.ORNo = Convert.ToString(table.Rows[i]["ORNo"]);
                collection.GrossPayment = Convert.ToDecimal(table.Rows[i]["GrossPayment"]);
                collection.Penalty = Convert.ToDecimal(table.Rows[i]["Penalty"]);
                collection.NetPayment = Convert.ToDecimal(table.Rows[i]["NetPayment"]);
                collection.Remarks = Convert.ToString(table.Rows[i]["Remarks"]);
                collection.Created_at = Convert.ToDateTime(table.Rows[i]["Created_at"]);
                collections.Add(collection);
            }
            dtgRecords2.DataSource = collections;
            LimitDataGridView();
        }

        private void LimitDataGridView()
        {
            //dtgRecords.Columns["LastReading"].Visible = false;
            //dtgRecords.Columns["PreviousReading"].Visible = false;
            //dtgRecords.Columns["LastCollected"].Visible = false;
            //dtgRecords.Columns["WaterServiceStatus"].Width = 150;
            //dtgRecords.Columns["GarbageCollectionStatus"].Width = 176;
            //dtgRecords.Columns["GarbageCollectionFee"].Width = 150;
        }

        private void CollectionsUI_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(dbServer.ServerName);
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void btnViewCollections_Click(object sender, EventArgs e)
        {
            FetchCollections();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Edit logic here
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Collections selectedCollection = GetSelectedCollectionData();
            if (selectedCollection == null)
            {
                MessageBox.Show("Please select a collection to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected collection?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeleteCollection(selectedCollection);
                FetchCollections();
            }
        }

        private Collections GetSelectedCollectionData()
        {
            DataGridViewRow selectedRow = dtgRecords2.CurrentRow;
            if (selectedRow == null) return null;

            return new Collections
            {
                CollectionId = Convert.ToInt32(selectedRow.Cells["CollectionId"].Value),
                InvoiceId = Convert.ToInt32(selectedRow.Cells["InvoiceId"].Value),
                HomeOwnerId = Convert.ToInt32(selectedRow.Cells["HomeOwnerId"].Value),
                FullName = selectedRow.Cells["FullName"].Value.ToString(),
                TransDate = Convert.ToDateTime(selectedRow.Cells["TransDate"].Value),
                ORNo = selectedRow.Cells["ORNo"].Value.ToString(),
                GrossPayment = Convert.ToDecimal(selectedRow.Cells["GrossPayment"].Value),
                Penalty = Convert.ToDecimal(selectedRow.Cells["Penalty"].Value),
                NetPayment = Convert.ToDecimal(selectedRow.Cells["NetPayment"].Value),
                Remarks = selectedRow.Cells["Remarks"].Value.ToString(),
                Created_at = Convert.ToDateTime(selectedRow.Cells["Created_at"].Value)
            };
        }

        private void DeleteCollection(Collections collection)
        {
            if (collection == null) return;

            string deleteQuery = "DELETE FROM Collections WHERE CollectionId = @CollectionId";
            using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
            {
                cmd.Parameters.AddWithValue("@CollectionId", collection.CollectionId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private Invoices GetSelectedInvoiceData()
        {
            DataGridViewRow selectedRow = dtgRecords.CurrentRow;
            if (selectedRow == null) return null;

            return new Invoices
            {
                InvoiceId = Convert.ToInt32(selectedRow.Cells["InvoiceId"].Value),
                HomeOwnerId = Convert.ToInt32(selectedRow.Cells["HomeOwnerId"].Value),
                FullName = selectedRow.Cells["FullName"].Value.ToString(),
                TransDate = Convert.ToDateTime(selectedRow.Cells["TransDate"].Value),
                GrossAmount = Convert.ToDecimal(selectedRow.Cells["GrossAmount"].Value),
                Deductions = Convert.ToDecimal(selectedRow.Cells["Deductions"].Value),
                NetAmount = Convert.ToDecimal(selectedRow.Cells["NetAmount"].Value),
                Remarks = selectedRow.Cells["Remarks"].Value.ToString(),
                Created_at = Convert.ToDateTime(selectedRow.Cells["Created_at"].Value),
                PaymentStatus = selectedRow.Cells["PaymentStatus"].Value.ToString()
            };
        }

        private void DeleteInvoice(Invoices invoice)
        {
            if (invoice == null) return;

            string deleteQuery = "DELETE FROM Invoices WHERE InvoiceId = @InvoiceId";
            using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
            {
                cmd.Parameters.AddWithValue("@InvoiceId", invoice.InvoiceId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Invoices selectedInvoice = GetSelectedInvoiceData();
            if (selectedInvoice == null)
            {
                MessageBox.Show("Please select an invoice to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected invoice?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeleteInvoice(selectedInvoice);
                FetchInvoices();
            }
        }
    }
}
