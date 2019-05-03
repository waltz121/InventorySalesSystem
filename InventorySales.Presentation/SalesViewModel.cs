using System;
using System.Collections.Generic;
using System.Text;
using InventorySales.Common;
using InventorySalesReader.Service;

namespace InventorySales.Presentation
{
    public class SalesViewModel
    {
        protected SalesServiceReader DataReader;

        private IEnumerable<Sales> _sales;

        public IEnumerable<Sales> Sales;

        public SalesViewModel()
        {
            DataReader = new SalesServiceReader();
        }

        public void RefreshSales()
        {
            Sales = DataReader.GetSales();
        }
    }
}
