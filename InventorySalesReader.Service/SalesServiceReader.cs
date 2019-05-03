using InventorySales.Common;
using InventorySales.Common.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace InventorySalesReader.Service
{
    public class SalesServiceReader: ISalesReader
    {
        WebClient client = new WebClient();
        string baseUri = "http://localhost:9874/api/Sales";

        public IEnumerable<Sales> GetSales()
        {
            string result = client.DownloadString(baseUri);
            var sale = JsonConvert.DeserializeObject<IEnumerable<Sales>>(result);
            return sale;
        }
    }
}
