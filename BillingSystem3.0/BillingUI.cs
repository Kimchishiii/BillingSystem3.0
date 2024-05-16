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
    public partial class BillingUI : Form
    {
        List<Billings> readings;
        List<Invoices> invoices;
        List<Billings> billings;
        List<GarbageCollections> garbageCollections;
        List<InvoiceDetails> fdetails;
        SqlConnection conn;
        SqlCommand cmd;
        string selectedHomeOwnerId = null;
        public BillingUI()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FetchGarbageCollections();
            FetchReadings();
            AddTotals();
        }
        public void MergeData()
        {
            fdetails = new List<InvoiceDetails>();
            foreach (var billing in billings)
            {
                if (Convert.ToInt32(selectedHomeOwnerId) == billing.HomeOwnerId)
                {
                    InvoiceDetails gdata = new InvoiceDetails();
                    gdata.HomeOwnerId = billing.HomeOwnerId;
                    gdata.FullName = billing.FullName;
                    gdata.Type = "Water";
                    gdata.TotalAmount = billing.TotalAmount;
                    fdetails.Add(gdata);
                }
            }
            foreach (var garbageCollection in garbageCollections)
            {
                if (Convert.ToInt32(selectedHomeOwnerId) == garbageCollection.HomeOwnerId)
                {
                    InvoiceDetails gdata = new InvoiceDetails();
                    gdata.HomeOwnerId = garbageCollection.HomeOwnerId;
                    gdata.FullName = garbageCollection.FullName;
                    gdata.Type = "GarbageCollection";
                    gdata.TotalAmount = garbageCollection.TotalAmount;
                    fdetails.Add(gdata);
                }
            }

            dtgRecords2.DataSource = fdetails;
            dtgRecords2.Columns["InvoiceId"].Visible = false;
            dtgRecords2.Columns["InvoiceDetailId"].Visible = false;
        }
        public void AddTotals()
        {
            foreach(var reading in readings)
            {
                foreach (var collection in garbageCollections) {
                    if(reading.HomeOwnerId == collection.HomeOwnerId)
                    {
                        reading.TotalAmount += collection.TotalAmount;
                    }
                    
                }
                foreach (var billing in billings)
                {
                    if (reading.HomeOwnerId == billing.HomeOwnerId)
                    {
                        reading.TotalAmount += billing.TotalAmount;
                    }
                }
            }
        }
        public void FetchGarbageCollections()
        {
            string selectquery = "select HomeOwnerId, FullName, DATEDIFF(MONTH, LastCollected, GETDATE()) AS MonthsDue,(DATEDIFF(MONTH, LastCollected, GETDATE()) * GarbageCollectionFee) AS TotalAmount from HomeOwners WHERE (DATEDIFF(MONTH, LastCollected, GETDATE()) * GarbageCollectionFee) != 0";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, conn);
            DataTable table = new DataTable();
            adpt.Fill(table);
            garbageCollections = new List<GarbageCollections>();
            readings = new List<Billings>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                GarbageCollections garbageCollection = new GarbageCollections();
                garbageCollection.HomeOwnerId = Convert.ToInt32(table.Rows[i]["HomeOwnerId"]);
                garbageCollection.FullName = Convert.ToString(table.Rows[i]["FullName"]);
                garbageCollection.MonthsDue = Convert.ToInt32(table.Rows[i]["MonthsDue"]);
                garbageCollection.TotalAmount = Convert.ToDecimal(table.Rows[i]["TotalAmount"]);
                garbageCollections.Add(garbageCollection);

                Billings reading = new Billings();
                reading.HomeOwnerId = Convert.ToInt32(table.Rows[i]["HomeOwnerId"]);
                reading.FullName = Convert.ToString(table.Rows[i]["FullName"]);
                reading.TotalAmount = 0;
                readings.Add(reading);
            }
            dtgRecords.DataSource = readings;
            dtgRecords.ClearSelection();
            //dtgRecords.DataSource = garbageCollections;
            LimitDataGridView();
        }

        public void FetchReadings()
        {
            string selectquery = "select HomeOwnerId, FullName, SUM(TotalAmount) AS TotalAmount from GenerateReadings WHERE PaymentStatus = 'unpaid' GROUP BY HomeOwnerId,FullName ";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, conn);
            DataTable table = new DataTable();
            adpt.Fill(table);
            billings = new List<Billings>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                Billings billing = new Billings();
                billing.HomeOwnerId = Convert.ToInt32(table.Rows[i]["HomeOwnerId"]);
                billing.FullName = Convert.ToString(table.Rows[i]["FullName"]);
                billing.TotalAmount = Convert.ToDecimal(table.Rows[i]["TotalAmount"]);
                billings.Add(billing);  
            }
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

        private void BillingUI_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(dbServer.ServerName);
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }
        private void dtgRecords_MouseClick(object sender, MouseEventArgs e)
        {
            if (dtgRecords.CurrentRow == null) return;
            selectedHomeOwnerId = dtgRecords.SelectedRows[0].Cells["HomeOwnerId"].Value.ToString();
            MergeData();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Invoices data = GetData();
            AddBillingUI display = new AddBillingUI(data,"save",fdetails);
            display.ShowDialog();
            FetchInvoices();
            FetchGarbageCollections();
            FetchReadings();
        }

        private Invoices GetData()
        {
            DataGridViewRow selectedRow = dtgRecords.CurrentRow;
            return new Invoices
            {
                HomeOwnerId = Convert.ToInt32(selectedRow.Cells["HomeOwnerId"].Value),
                FullName = selectedRow.Cells["FullName"].Value.ToString(),
                NetAmount = Convert.ToDecimal(selectedRow.Cells["TotalAmount"].Value),
            };
        }

        public void FetchInvoices()
        {
            string selectquery = "select * from Invoices";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, conn);
            DataTable table = new DataTable();
            adpt.Fill(table);
            invoices = new List<Invoices>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                Invoices invoice = new Invoices();
                invoice.InvoiceId = Convert.ToInt32(table.Rows[i]["InvoiceId"]);
                invoice.TransDate = Convert.ToDateTime(table.Rows[i]["TransDate"]);
                invoice.HomeOwnerId = Convert.ToInt32(table.Rows[i]["HomeOwnerId"]);
                invoice.FullName = Convert.ToString(table.Rows[i]["FullName"]);
                invoice.GrossAmount = Convert.ToDecimal(table.Rows[i]["GrossAmount"]);
                invoice.Deductions = Convert.ToDecimal(table.Rows[i]["Deductions"]);
                invoice.NetAmount = Convert.ToDecimal(table.Rows[i]["NetAmount"]);
                invoice.Remarks = Convert.ToString(table.Rows[i]["Remarks"]);
                invoice.Created_at = Convert.ToDateTime(table.Rows[i]["Created_at"]);
                invoices.Add(invoice);
            }
            dtgRecords3.DataSource = invoices;
        }

        private void btnShowInvoices_Click(object sender, EventArgs e)
        {
            FetchInvoices();
        }

        private void btnEditInvoice_Click(object sender, EventArgs e)
        {
            Invoices data = GetData2();
            AddBillingUI display = new AddBillingUI(data,"update",null);
            display.ShowDialog();
            FetchInvoices();
        }
        private Invoices GetData2()
        {
            DataGridViewRow selectedRow = dtgRecords3.CurrentRow;
            return new Invoices
            {
                InvoiceId = Convert.ToInt32(selectedRow.Cells["InvoiceId"].Value),
                TransDate = Convert.ToDateTime(selectedRow.Cells["TransDate"].Value),
                HomeOwnerId = Convert.ToInt32(selectedRow.Cells["HomeOwnerId"].Value),
                FullName = selectedRow.Cells["FullName"].Value.ToString(),
                GrossAmount = Convert.ToDecimal(selectedRow.Cells["GrossAmount"].Value),
                Deductions = Convert.ToDecimal(selectedRow.Cells["Deductions"].Value),
                NetAmount = Convert.ToDecimal(selectedRow.Cells["NetAmount"].Value),
                Created_at = Convert.ToDateTime(selectedRow.Cells["Created_at"].Value),
                Remarks = selectedRow.Cells["Remarks"].Value.ToString(),
            };
        }
    }
}
