using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem3._0.Models
{
    public class Invoices
    {
        int invoiceId;
        DateTime transDate;
        int homeOwnerId;
        string fullName;
        decimal grossAmount;
        decimal deductions;
        decimal netAmount;
        string remarks;
        DateTime created_at;

        public int InvoiceId { get => invoiceId; set => invoiceId = value; }
        public DateTime TransDate { get => transDate; set => transDate = value; }
        public int HomeOwnerId { get => homeOwnerId; set => homeOwnerId = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public decimal GrossAmount { get => grossAmount; set => grossAmount = value; }
        public decimal Deductions { get => deductions; set => deductions = value; }
        public decimal NetAmount { get => netAmount; set => netAmount = value; }
        public string Remarks { get => remarks; set => remarks = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
    }
}
