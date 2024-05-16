using BillingSystem3._0.Models;
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
    public partial class EditReadingUI : Form
    {
        GenerateReading generateReading;
        ReadingsUI ui;
        public EditReadingUI()
        {
            InitializeComponent();
        }
        public EditReadingUI(GenerateReading generateReading, ReadingsUI ui) : this()
        {
            this.ui = ui;
            this.generateReading = generateReading;
            txtPreviousReading.Text = generateReading.PreviousReading.ToString("n2");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ui.UpdateDisplayRecord(PassData());
            this.Dispose();
        }
        public GenerateReading PassData()
        {
            return new GenerateReading
            {
                HomeOwnerId = generateReading.HomeOwnerId,
                PreviousReading = generateReading.PreviousReading,
                CurrentReading = Convert.ToDecimal(txtCurrentReading.Text)
            };
        }

        private void EditReadingUI_Load(object sender, EventArgs e)
        {

        }
    }
}
