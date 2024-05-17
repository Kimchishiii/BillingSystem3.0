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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Homeownerbtn_Click(object sender, EventArgs e)
        {
            CloseCurrentForms();
            HomeownersUI mdiChild = new HomeownersUI();
            mdiChild.MdiParent = this;
            mdiChild.Show();
        }
        public void CloseCurrentForms()
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }

        private void ReadingsBtn_Click(object sender, EventArgs e)
        {
            CloseCurrentForms();
            ReadingsUI mdiChild = new ReadingsUI();
            mdiChild.MdiParent = this;
            mdiChild.Show();
        }

        private void BillingsBTN_Click(object sender, EventArgs e)
        {
            CloseCurrentForms();
            BillingUI mdiChild = new BillingUI();
            mdiChild.MdiParent = this;
            mdiChild.Show();
        }

        private void collectionsBTN_Click(object sender, EventArgs e)
        {
            CloseCurrentForms();
            CollectionsUI mdiChild = new CollectionsUI();
            mdiChild.MdiParent = this;
            mdiChild.Show();
        }

        private void configBTN_Click(object sender, EventArgs e)
        {
            // Close and reopen the main form
            CloseCurrentForms();
            var form = new Form1();
            form.Show();
        }
    }
}
