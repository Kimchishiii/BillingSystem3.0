using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem3._0.Models
{
    public class HomeOwners
    {
        int homeOwnerId;
        string fullName;
        string contactNo;
        string email;
        string phaseName;
        string block;
        string lot;
        DateTime moveInDate;
        DateTime created_at;
        DateTime lastReading;
        decimal previousReading;
        DateTime lastCollected;
        string waterServiceStatus;
        string garbageCollectionStatus;
        decimal garbageCollectionFee;

        public int HomeOwnerId { get => homeOwnerId; set => homeOwnerId = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string ContactNo { get => contactNo; set => contactNo = value; }
        public string Email { get => email; set => email = value; }
        public string PhaseName { get => phaseName; set => phaseName = value; }
        public string Block { get => block; set => block = value; }
        public string Lot { get => lot; set => lot = value; }
        public DateTime MoveInDate { get => moveInDate; set => moveInDate = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime LastReading { get => lastReading; set => lastReading = value; }
        public decimal PreviousReading { get => previousReading; set => previousReading = value; }
        public DateTime LastCollected { get => lastCollected; set => lastCollected = value; }
        public string WaterServiceStatus { get => waterServiceStatus; set => waterServiceStatus = value; }
        public string GarbageCollectionStatus { get => garbageCollectionStatus; set => garbageCollectionStatus = value; }
        public decimal GarbageCollectionFee { get => garbageCollectionFee; set => garbageCollectionFee = value; }
    }
}
