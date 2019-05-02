using System;
using System.Collections.Generic;
using System.Text;

namespace InventorySales.Common
{
    class Product_Types
    {
        public int Product_Type_Code { get; set; }
        public int Parent_Product_Type_Code { get; set; }
        public string Product_Type_Description { get; set; }
    }
}
