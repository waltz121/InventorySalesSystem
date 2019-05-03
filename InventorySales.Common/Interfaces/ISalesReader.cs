using System;
using System.Collections.Generic;
using System.Text;

namespace InventorySales.Common.Interfaces
{
    public interface ISalesReader
    {
        IEnumerable<Sales> GetSales();
    }
}
