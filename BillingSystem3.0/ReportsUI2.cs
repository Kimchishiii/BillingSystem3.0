using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem3._0
{
    public partial class ReportsUI2 : Form
    {
        public ReportsUI2()
        {
            InitializeComponent();
        }

        private void ReportsUI2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'billingSystemDataSet3.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.billingSystemDataSet3.Invoices);
            // TODO: This line of code loads data into the 'billingSystemDataSet2.Collections' table. You can move, or remove it, as needed.
            this.collectionsTableAdapter.Fill(this.billingSystemDataSet2.Collections);
        }

        private void txtbox_SearchReport_TextChanged(object sender, EventArgs e)
        {
            // No implementation needed here, filtering will be done on button click
        }

        private void FilterDataByName(string searchText)
        {
            // Assuming 'invoicesBindingSource' is the binding source for 'dataGridView1'
            // Assuming 'collectionsBindingSource' is the binding source for 'dataGridView2'

            // Apply the filter to the binding sources
            invoicesBindingSource.Filter = string.Format("FullName LIKE '%{0}%'", searchText);
            collectionsBindingSource.Filter = string.Format("FullName LIKE '%{0}%'", searchText);

            // Refresh the DataGridViews to display the filtered data
            dataGridView1.Refresh();
            dataGridView2.Refresh();
        }

        private void btn_ViewReport_Click(object sender, EventArgs e)
        {
            // Get the search text
            string searchText = txtbox_SearchReport.Text.Trim();

            // Filter the data based on the search text
            FilterDataByName(searchText);
        }

        private void ShowAllData()
        {
            // Clear the filters to show all data
            invoicesBindingSource.Filter = null;
            collectionsBindingSource.Filter = null;

            // Refresh the DataGridViews to display all data
            dataGridView1.Refresh();
            dataGridView2.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Show all data in both DataGridViews
            ShowAllData();
        }

        private void dtp_fromReport_ValueChanged(object sender, EventArgs e)
        {
            // Handle value changed event if needed
        }

        private void dtp_toReport_ValueChanged(object sender, EventArgs e)
        {
            // Handle value changed event if needed
        }

        private void FilterDataByDateRange(DateTime fromDate, DateTime toDate)
        {
            // Assuming 'invoicesBindingSource' is the binding source for 'dataGridView1'
            // Assuming 'collectionsBindingSource' is the binding source for 'dataGridView2'

            // Apply the filter to the binding sources
            invoicesBindingSource.Filter = string.Format("TransDate >= #{0}# AND TransDate <= #{1}#", fromDate.ToString("MM/dd/yyyy"), toDate.ToString("MM/dd/yyyy"));
            collectionsBindingSource.Filter = string.Format("TransDate >= #{0}# AND TransDate <= #{1}#", fromDate.ToString("MM/dd/yyyy"), toDate.ToString("MM/dd/yyyy"));

            // Refresh the DataGridViews to display the filtered data
            dataGridView1.Refresh();
            dataGridView2.Refresh();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click if needed
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click if needed
        }
    }
}
