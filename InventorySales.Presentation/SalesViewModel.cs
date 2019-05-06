using System;
using System.Collections.Generic;
using System.Text;
using InventorySales.Common;
using InventorySales.Common.Interfaces;
using InventorySalesReader.Service;

namespace InventorySales.Presentation
{
    public class SalesViewModel
    {
        protected ISalesReader DataReader;

        public IEnumerable<Sales> Sales;

        public SalesViewModel(ISalesReader dataReader)
        {
            DataReader = dataReader;
        }

        public void RefreshSales()
        {
            Sales = DataReader.GetSales();
        }
    }
}
