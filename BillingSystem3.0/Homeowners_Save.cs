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
    public partial class Homeowners_Save : Form
    {
        List<HomeOwners> homeOwners;
        HomeOwners homeOwner;
        SqlConnection conn;
        SqlCommand cmd;
        HomeownersUI ui;
        public Homeowners_Save()
        {
            InitializeComponent();
        }
        public Homeowners_Save(HomeOwners homeOwner) : this()
        {
            this.homeOwner = homeOwner;
            button3.Text = "Update";
            DisplayRecords();
        }
        public void DisplayRecords()
        {
            txtGenerateId.Text = homeOwner.HomeOwnerId.ToString();
            txtFullName.Text = homeOwner.FullName;
            cbPhaseName.Text = homeOwner.PhaseName;
            txtBlock.Text = homeOwner.Block;
            txtLot.Text = homeOwner.Lot;
            txtContactNo.Text = homeOwner.ContactNo;
            txtEmail.Text = homeOwner.Email;
            dtMoveInDate.Value = homeOwner.MoveInDate;
            dtLastReading.Value = homeOwner.LastReading;
            txtPreviousReading.Text = homeOwner.PreviousReading.ToString();
            dtLastCollected.Value = homeOwner.LastCollected;
            cboWaterServiceStatus.Text = homeOwner.WaterServiceStatus;
            cboGarbageCollectionStatus.Text = homeOwner.GarbageCollectionStatus;
            txtGarbageCollectionFee.Text = homeOwner.GarbageCollectionFee.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            HomeOwners data = GetData();
            string query = "";
            string msg = "Saved";
            if (button3.Text == "Save")
            {
                query = $"insert into HomeOwners (FullName,ContactNo,Email,PhaseName,Block,Lot,MoveInDate,Created_at,LastReading,PreviousReading,LastCollected," +
                    $"WaterServiceStatus,GarbageCollectionStatus, GarbageCollectionFee) VALUES(" +
                    $"@FullName," +
                    $"@ContactNo," +
                    $"@Email," +
                    $"@PhaseName," +
                    $"@Block," +
                    $"@Lot," +
                    $"@MoveInDate," +
                    $"@Created_at," +
                    $"@LastReading," +
                    $"@PreviousReading," +
                    $"@LastCollected," +
                    $"@WaterServiceStatus," +
                    $"@GarbageCollectionStatus," +
                    $"@GarbageCollectionFee" +
                    $")";
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
                    $"where HomeOwnerId='{homeOwner.HomeOwnerId}'";
            }
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@FullName", data.FullName);
            cmd.Parameters.AddWithValue("@ContactNo", data.ContactNo);
            cmd.Parameters.AddWithValue("@Email", data.Email);
            cmd.Parameters.AddWithValue("@PhaseName", data.PhaseName);
            cmd.Parameters.AddWithValue("@Block", data.Block);
            cmd.Parameters.AddWithValue("@Lot", data.Lot);
            cmd.Parameters.AddWithValue("@MoveInDate", data.MoveInDate);
            cmd.Parameters.AddWithValue("@Created_at", DateTime.Now);
            cmd.Parameters.AddWithValue("@LastReading", data.LastReading);
            cmd.Parameters.AddWithValue("@PreviousReading", data.PreviousReading);
            cmd.Parameters.AddWithValue("@LastCollected", data.LastCollected);
            cmd.Parameters.AddWithValue("@WaterServiceStatus", data.WaterServiceStatus);
            cmd.Parameters.AddWithValue("@GarbageCollectionStatus", data.GarbageCollectionStatus);
            cmd.Parameters.AddWithValue("@GarbageCollectionFee", data.GarbageCollectionFee);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully " + msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
        private HomeOwners GetData()
        {
            return new HomeOwners
            {
                FullName = txtFullName.Text,
                ContactNo = txtContactNo.Text,
                Email = txtEmail.Text,
                PhaseName = cbPhaseName.Text,
                Block = txtBlock.Text,
                Lot = txtLot.Text,
                MoveInDate = dtMoveInDate.Value.Date,
                LastReading = dtLastReading.Value.Date,
                PreviousReading = Convert.ToDecimal(txtPreviousReading.Text),
                LastCollected = dtLastCollected.Value.Date,
                WaterServiceStatus = cboWaterServiceStatus.Text,
                GarbageCollectionStatus = cboGarbageCollectionStatus.Text,
                GarbageCollectionFee = Convert.ToDecimal(txtGarbageCollectionFee.Text) 
            };
        }

        private void Homeowners_Save_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(dbServer.ServerName);
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }
    }
}
