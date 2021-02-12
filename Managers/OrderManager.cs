using AdminTemplate.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AdminTemplate.Managers
{
    public class OrderManager
    {
        static string data = File.ReadAllText(@"C:\Users\Ece\source\repos\AdminTemplate\wwwroot\orders.json");
        static List<OrderVM> datum = JsonConvert.DeserializeObject<List<OrderVM>>(data);

        public static List<OrderVM> GetOrderVMs()
        {
            return datum;
        }

     

        public static OrderVM GetOrderById(int id)
        {
            var model = datum.FirstOrDefault(q => q.id == id);
            return model;

        }

    }
}
