using InventorySales.Presentation;
using InventorySalesReader.Service;
using InventorySalesSQLReader.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventorySalesMVC.Models
{
    public static class bootstrap
    {
        public static SalesViewModel _viewModel;
        public static void ComposeObjects()
        {

            //---------------- Data Access Layer ------------------//
            //For Sql DataAccess DB
            var sqlReader = new SalesSQLServiceReader();
            
            //For Static DataAccess DB
            var reader = new SalesServiceReader();

            //---------------- Presentation Layer ----------------//

            var viewModel = new SalesViewModel(sqlReader);
            _viewModel = viewModel;
        }
    }
}