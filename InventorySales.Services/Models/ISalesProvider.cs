using InventorySales.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySales.Services.Models
{
    public interface ISalesProvider
    {
        List<Sales> GetSales();
    }
}
