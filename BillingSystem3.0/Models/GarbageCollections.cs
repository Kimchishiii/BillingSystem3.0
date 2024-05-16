using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem3._0.Models
{
    public class GarbageCollections
    {
        int homeOwnerId;
        string fullName;
        int monthsDue;
        decimal totalAmount;

        public int HomeOwnerId { get => homeOwnerId; set => homeOwnerId = value; }
        public string FullName { get => fullName; set => fullName = value; }

        public int MonthsDue { get => monthsDue; set => monthsDue = value; }
        public decimal TotalAmount { get => totalAmount; set => totalAmount = value; }
    }
}
