//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventorySalesSQLReader.Service.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Daily_Inventory_Levels
    {
        public System.DateTime Day_Date { get; set; }
        public int Product_ID { get; set; }
        public int Levels { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Ref_Calendar Ref_Calendar { get; set; }
    }
}
