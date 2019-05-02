using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventorySales.Common;

namespace InventorySales.Services.Models
{
    public class StaticSalesProvider : ISalesProvider
    {
        public List<Sales> GetSales()
        {
            var s = new List<Sales>()
            {
                new Sales() { Sales_ID =1, Date_of_Sale=new DateTime(2019, 04,14),Total_Amount_of_Sale=350 },
                new Sales() {Sales_ID = 2, Date_of_Sale=new DateTime(2019, 03,07), Total_Amount_of_Sale=250 },
                new Sales() {Sales_ID = 3, Date_of_Sale=new DateTime(2019,04,10), Total_Amount_of_Sale = 150 },
                new Sales() {Sales_ID = 4, Date_of_Sale=new DateTime(2019,04,08), Total_Amount_of_Sale = 250 },
                new Sales() {Sales_ID = 5, Date_of_Sale=new DateTime(2019,05,10), Total_Amount_of_Sale = 1200 }

            };

            return s;
        }
    }
}
