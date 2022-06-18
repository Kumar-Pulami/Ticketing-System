using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepal_Recreation_Centre
{
    public static class Storage
    {
        public static List<Visitor> visitorList = new List<Visitor>();

        public static List<GroupPrice> groupPriceList = new List<GroupPrice>();

        public static List<IndividualPrice> individualPriceList = new List<IndividualPrice>();

        /// <summary>
        ///  Creating arrary of 2 Dimensional 
        ///  where values are represented as "Roles", "UserName", "Password"
        /// </summary>
        public static String[,] loginCredentials = new String[,] {
                                                                {"Admin", "admin", "admin"},
                                                                { "Staff", "kumar", "kumar123"}
                                                             };

    }
}
