using System;
using System.Collections.Generic;
using System.Text;

namespace InventorySales.Common
{
    class Products
    {
        public int Product_ID { get; set; }
        public int Product_Type_Code { get; set; }
        public string Product_Name { get; set; }
        public double Unit_Price { get; set; }
        public string Product_Description { get; set; }
        public int Reorder_Level { get; set; }
        public int Reorder_Quantity { get; set; }
        public string Other_Details { get; set; }
    }
}
