using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem3._0
{
    public partial class ReportsUI : Form
    {
        public ReportsUI()
        {
            InitializeComponent();
        }

        private void ReportsUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'billingSystemDataSet.GenerateReadings' table. You can move, or remove it, as needed.
            this.generateReadingsTableAdapter.Fill(this.billingSystemDataSet.GenerateReadings);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click if needed
        }

        private void dtp_fromReport_ValueChanged(object sender, EventArgs e)
        {
            // Handle value changed event if needed
        }

        private void dtp_toReport_ValueChanged(object sender, EventArgs e)
        {
            // Handle value changed event if needed
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the selected date range
            DateTime fromDate = dtp_fromReport.Value.Date;
            DateTime toDate = dtp_toReport.Value.Date;

            // Validate the date range
            if (fromDate > toDate)
            {
                MessageBox.Show("The 'From' date cannot be later than the 'To' date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Filter the data based on the selected date range
            FilterDataByDateRange(fromDate, toDate);
        }

        private void FilterDataByDateRange(DateTime fromDate, DateTime toDate)
        {
            // Assuming 'generateReadingsBindingSource' is the binding source for 'dataGridView1'
            // Apply the filter to the binding source
            generateReadingsBindingSource.Filter = string.Format("ReadingDate >= #{0}# AND ReadingDate <= #{1}#", fromDate.ToString("MM/dd/yyyy"), toDate.ToString("MM/dd/yyyy"));

            // Refresh the DataGridView to display the filtered data
            dataGridView1.Refresh();
        }

        private void btn_PrintReport_Click(object sender, EventArgs e)
        {
            // Implementation for printing the report can go here
        }

        private void txtbox_SearchReport_TextChanged(object sender, EventArgs e)
        {
            // Get the search text
            string searchText = txtbox_SearchReport.Text;

            // Filter the data based on the search text
            FilterDataByName(searchText);
        }

        private void FilterDataByName(string searchText)
        {
            // Assuming 'generateReadingsBindingSource' is the binding source for 'dataGridView1'
            // Apply the filter to the binding source
            generateReadingsBindingSource.Filter = string.Format("FullName LIKE '%{0}%'", searchText);

            // Refresh the DataGridView to display the filtered data
            dataGridView1.Refresh();
        }

        private void btn_ViewReport_Click(object sender, EventArgs e)
        {
            // Implementation for viewing the report can go here
        }
    }
}
