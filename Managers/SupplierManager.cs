using AdminTemplate.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AdminTemplate.Managers
{
    public class SupplierManager
    {
        static string data = File.ReadAllText(@"C:\Users\Ece\source\repos\AdminTemplate\wwwroot\suppliers.json");
        static List<SupplierVM> datum = JsonConvert.DeserializeObject<List<SupplierVM>>(data);

        public static List<SupplierVM> GetSupplierVMs()
        {
            return datum;
        }

        public static SupplierVM GetSupplierByID(int id)
        {
            var model = datum.FirstOrDefault(w => w.id == id);
            return model;
        }
    }
}
