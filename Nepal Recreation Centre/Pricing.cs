using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepal_Recreation_Centre
{
    public class GroupPrice
    {
        public GroupPrice(String groupCount, int discountPer)
        {
            GroupCount = groupCount;
            DiscountPer = discountPer;
        }

        public String GroupCount { get; set; }

        public int DiscountPer { get; set; }
    }

    public class IndividualPrice
    {
        public IndividualPrice(String ageCategory, int regularPrice, int weekendPrice, String hour)
        {
            AgeCategory = ageCategory;
            Hour = hour;
            RegularPrice = regularPrice;
            WeekendPrice = weekendPrice;            
        }

        public String AgeCategory { get; set; }

        public String Hour { get; set; }

        public int RegularPrice { get; set; }

        public int WeekendPrice { get; set; }

    }
}