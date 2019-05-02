using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventorySales.Common;
using InventorySales.Services.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventorySales.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        ISalesProvider provider;

        public SalesController(ISalesProvider provider)
        {
            this.provider = provider;
        }

        [HttpGet]
        public IEnumerable<Sales> Get()
        {
            return provider.GetSales();
        }


    }
}