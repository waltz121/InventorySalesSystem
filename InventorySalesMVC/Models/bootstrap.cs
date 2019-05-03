using InventorySales.Presentation;
using InventorySalesReader.Service;
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
            var reader = new SalesServiceReader();
            var viewModel = new SalesViewModel(reader);
            _viewModel = viewModel;
        }
    }
}