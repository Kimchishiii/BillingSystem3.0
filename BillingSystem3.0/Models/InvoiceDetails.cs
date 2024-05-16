﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem3._0.Models
{
    public class InvoiceDetails
    {
        int invoiceDetailId;
        int invoiceId;
        int homeOwnerId;
        string fullName;
        decimal totalAmount;
        string type;

        public int HomeOwnerId { get => homeOwnerId; set => homeOwnerId = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public decimal TotalAmount { get => totalAmount; set => totalAmount = value; }
        public string Type { get => type; set => type = value; }
        public int InvoiceDetailId { get => invoiceDetailId; set => invoiceDetailId = value; }
        public int InvoiceId { get => invoiceId; set => invoiceId = value; }
    }
}
