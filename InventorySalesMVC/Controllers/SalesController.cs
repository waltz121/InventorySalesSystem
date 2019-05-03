using InventorySales.Common;
using InventorySales.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventorySalesMVC.Models;

namespace InventorySalesMVC.Controllers
{
    public class SalesController : Controller
    {
        SalesViewModel ViewModel;

        public SalesController()
        {           
            ViewModel = bootstrap._viewModel;            
        }
        // GET: Sales
        public ActionResult Index()
        {
            ViewModel.RefreshSales();

            return View(ViewModel.Sales);
        }
    }
}