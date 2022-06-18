using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepal_Recreation_Centre
{
    public class Visitor
    {
        public Visitor(long visitorID, String visitorName, long contactNumber, String address, DateTime entryTime, String ageCategory, String groupCount, int? price, DateTime? departureTime)
        {
            VisitorID = visitorID;
            VisitorName = visitorName;
            ContactNumber = contactNumber;
            Address = address;           
            EntryTime = entryTime;
            AgeCategory = ageCategory;
            GroupCount = groupCount;
            Price = price;
            DepartureTime = departureTime;
        }
        
        public long VisitorID { get; set; }

        public String VisitorName { get; set; }

        public long ContactNumber { get; set; }

        public String Address { get; set; }

        public String AgeCategory  { get; set; }

        public String GroupCount { get; set; }

        public DateTime EntryTime { get; set; }

        public int? Price { get; set; }

        public DateTime? DepartureTime { get; set; }
    }
}
