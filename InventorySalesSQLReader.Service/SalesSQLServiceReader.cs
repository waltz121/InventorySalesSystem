using InventorySales.Common;
using InventorySales.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventorySalesSQLReader.Service.Models;
using Microsoft.EntityFrameworkCore;

namespace InventorySalesSQLReader.Service
{
    public class SalesSQLServiceReader : ISalesReader
    {
        InventorySalesManagementEntities entities = new InventorySalesManagementEntities();
        
        public IEnumerable<Sales> GetSales()
        {
            var returnTmp = from list in entities.Sales.ToList()
                            select new Sales
                            {
                                Date_of_Sale = list.Date_of_Sale.Value,
                                Sales_ID = list.Sales_ID,
                                Total_Amount_of_Sale = list.Total_Amount_of_Sale.Value
                            };
            return returnTmp;
        }
    }
}
