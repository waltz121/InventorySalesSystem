using InventorySales.Common;
using InventorySales.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventorySalesMVC.Controllers
{
    public class SalesController : Controller
    {

        SalesViewModel ViewModel;

    
        public SalesController()
        {
            ViewModel = new SalesViewModel();            
        }
        // GET: Sales
        public ActionResult Index()
        {
            ViewModel.RefreshSales();

            return View(ViewModel.Sales);
        }
    }
}