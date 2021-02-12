 using AdminTemplate.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AdminTemplate.Managers
{
    public class CategoryManager
    {
        static string data = File.ReadAllText(@"C:\Users\Ece\source\repos\AdminTemplate\wwwroot\categories.json");
        static List<CategoryVM> datum = JsonConvert.DeserializeObject<List<CategoryVM>>(data);

       

        public static List<CategoryVM> GetCategoryVMs()
        {
            return datum;
        }

        public static CategoryVM GetCategoryById(int id)
        {
           var model = datum.FirstOrDefault(q => q.id == id);
            return model;

        }
    }
}
