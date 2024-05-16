using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem3._0.Models
{
    public class Collections
    {
        int collectionId;
        int invoiceId;
        int homeOwnerId;
        string fullName;
        DateTime transDate;
        string oRNo;
        decimal grossPayment;
        decimal penalty;
        decimal netPayment;
        string remarks;
        DateTime created_at;

        public int CollectionId { get => collectionId; set => collectionId = value; }
        public int InvoiceId { get => invoiceId; set => invoiceId = value; }
        public int HomeOwnerId { get => homeOwnerId; set => homeOwnerId = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public DateTime TransDate { get => transDate; set => transDate = value; }
        public string ORNo { get => oRNo; set => oRNo = value; }
        public decimal GrossPayment { get => grossPayment; set => grossPayment = value; }
        public decimal Penalty { get => penalty; set => penalty = value; }
        public decimal NetPayment { get => netPayment; set => netPayment = value; }
        public string Remarks { get => remarks; set => remarks = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
    }
}
