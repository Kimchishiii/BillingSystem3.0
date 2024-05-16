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
    public partial class ReadingsUI : Form
    {
        List<GenerateReading> generateReadings;
        SqlConnection conn;
        SqlCommand cmd;
        public ReadingsUI()
        {
            InitializeComponent();
        }

        private void btnGenerateReading_Click(object sender, EventArgs e)
        {
            FetchData();
        }
        public void FetchData()
        {
            string selectquery = "select * from HomeOwners";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, conn);
            DataTable table = new DataTable();
            adpt.Fill(table);
            generateReadings = new List<GenerateReading>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                GenerateReading reading = new GenerateReading();
                reading.HomeOwnerId = Convert.ToInt32(table.Rows[i]["HomeOwnerId"]);
                reading.FullName = Convert.ToString(table.Rows[i]["FullName"]);
                reading.PhaseName = Convert.ToString(table.Rows[i]["PhaseName"]);
                reading.Block = Convert.ToString(table.Rows[i]["Block"]);
                reading.Lot = Convert.ToString(table.Rows[i]["Lot"]);
                reading.LastReading = Convert.ToDateTime(table.Rows[i]["LastReading"]);
                reading.PreviousReading = Convert.ToDecimal(table.Rows[i]["PreviousReading"]);
                reading.WaterServiceStatus = Convert.ToString(table.Rows[i]["WaterServiceStatus"]);
                generateReadings.Add(reading);
            }
            DisplayRecords();
        }
        public void DisplayRecords()
        {
            dtgRecords.DataSource = generateReadings;
            LimitDataGridView();
        }
        private void LimitDataGridView()
        {
            foreach (DataGridViewColumn column in dtgRecords.Columns)
            {
                column.ReadOnly = true;
                column.Visible = false;
            }
            dtgRecords.Columns["HomeOwnerId"].Visible = true;
            dtgRecords.Columns["FullName"].Visible = true;
            dtgRecords.Columns["PhaseName"].Visible = true;
            dtgRecords.Columns["Block"].Visible = true;
            dtgRecords.Columns["Lot"].Visible = true;
            dtgRecords.Columns["LastReading"].Visible = true;
            dtgRecords.Columns["PreviousReading"].Visible = true;
            dtgRecords.Columns["PreviousReading"].DefaultCellStyle.Format = $"N{2}";
            dtgRecords.Columns["PreviousReading"].Width = 150;
            dtgRecords.Columns["CurrentReading"].Visible = true;
            dtgRecords.Columns["CurrentReading"].DefaultCellStyle.Format = $"N{2}";
            dtgRecords.Columns["CurrentReading"].Width = 150;
            dtgRecords.Columns["Variance"].Visible = true;
            dtgRecords.Columns["Variance"].DefaultCellStyle.Format = $"N{2}";
            dtgRecords.Columns["Variance"].Width = 150;
            dtgRecords.Columns["TotalAmount"].Visible = true;
            dtgRecords.Columns["TotalAmount"].DefaultCellStyle.Format = $"N{2}";
            dtgRecords.Columns["TotalAmount"].Width = 150;
            lblTotalRecords.Text = "TOTAL RECORDS: " + generateReadings.Count();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (GenerateReading data in generateReadings)
            {
                if (data.CurrentReading <= 0) continue;

                string query = "";
                query = $"insert into GenerateReadings (ReadingDate,HomeOwnerId,FullName,PhaseName," +
                    $"Block,Lot,LastReading,PreviousReading,CurrentReading,Variance,TotalAmount,PaymentStatus,Created_at) VALUES(" +
                       $"@ReadingDate," +
                       $"@HomeOwnerId," +
                       $"@FullName," +
                       $"@PhaseName," +
                       $"@Block," +
                       $"@Lot," +
                       $"@LastReading," +
                       $"@PreviousReading," +
                       $"@CurrentReading," +
                       $"@Variance," +
                       $"@TotalAmount," +
                       $"@PaymentStatus," +
                       $"@Created_at" +
                       $")";
                cmd.CommandText = query;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ReadingDate", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@HomeOwnerId", data.HomeOwnerId);
                cmd.Parameters.AddWithValue("@FullName", data.FullName);
                cmd.Parameters.AddWithValue("@PhaseName", data.PhaseName);
                cmd.Parameters.AddWithValue("@Block", data.Block);
                cmd.Parameters.AddWithValue("@Lot", data.Lot);
                cmd.Parameters.AddWithValue("@LastReading", data.LastReading);
                cmd.Parameters.AddWithValue("@PreviousReading", data.PreviousReading);
                cmd.Parameters.AddWithValue("@CurrentReading", data.CurrentReading);
                cmd.Parameters.AddWithValue("@Variance", data.Variance);
                cmd.Parameters.AddWithValue("@TotalAmount", data.TotalAmount);
                cmd.Parameters.AddWithValue("@PaymentStatus", "unpaid");
                cmd.Parameters.AddWithValue("@Created_at", DateTime.Now);
                conn.Open();
                int rowsaffected = cmd.ExecuteNonQuery();
                if(rowsaffected > 0)
                {
                    string additionalQuery = "UPDATE HomeOwners SET PreviousReading = @previousReading, LastReading = @lastReading WHERE HomeOwnerId = @homeOwnerId";
                    SqlCommand additionalCommand = new SqlCommand(additionalQuery, conn);
                    additionalCommand.Parameters.AddWithValue("@PreviousReading", data.CurrentReading);
                    additionalCommand.Parameters.AddWithValue("@LastReading", DateTime.Now.Date);
                    additionalCommand.Parameters.AddWithValue("@HomeOwnerId", data.HomeOwnerId);
                    additionalCommand.ExecuteNonQuery();
                }
                conn.Close();
            }
            MessageBox.Show("Successfully Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            generateReadings = new List<GenerateReading>();
            DisplayRecords();
        }

        private void ReadingsUI_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(dbServer.ServerName);
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void btnAddReading_Click(object sender, EventArgs e)
        {
            GenerateReading data = GetData();
            EditReadingUI displayUpdateHomeownerForm = new EditReadingUI(data, this);
            displayUpdateHomeownerForm.ShowDialog();
            DisplayRecords();
        }
        public void UpdateDisplayRecord(GenerateReading reading)
        {
            generateReadings.ForEach(res => {
                if (res.HomeOwnerId == reading.HomeOwnerId)
                {
                    decimal variance = reading.CurrentReading - res.PreviousReading;
                    res.CurrentReading = reading.CurrentReading;
                    res.Variance = variance;
                    res.TotalAmount = GetTotalBill(variance);
                }
            });
        }
        public decimal GetTotalBill(decimal variance)
        {
            if (variance <= 10)
                return 350;
            else if (variance > 10 && variance <= 20)
                return 350 + (variance - 10) * 40;
            else if (variance > 20 && variance <= 30)
                return 350 + (variance - 20) * 45;
            else if (variance > 30 && variance <= 40)
                return 350 + (variance - 30) * 70;
            else if (variance > 40)
                return 350 + (variance - 40) * 80;
            else
                return 0;
        }
        private GenerateReading GetData()
        {
            DataGridViewRow selectedRow = dtgRecords.CurrentRow;
            return new GenerateReading
            {
                HomeOwnerId = Convert.ToInt32(selectedRow.Cells["HomeOwnerId"].Value),
                PreviousReading = Convert.ToDecimal(selectedRow.Cells["PreviousReading"].Value),
                CurrentReading = Convert.ToDecimal(selectedRow.Cells["CurrentReading"].Value),
            };
        }
    }
}
