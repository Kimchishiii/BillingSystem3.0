using BillingSystem3._0.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            AddCollectionsUI display = new AddCollectionsUI(data,"save");
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
    }
}
