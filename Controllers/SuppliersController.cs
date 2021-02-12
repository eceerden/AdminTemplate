using AdminTemplate.Managers;
using AdminTemplate.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminTemplate.Controllers
{
    public class SuppliersController : Controller
    {
        public IActionResult Index()
        {
            var model = SupplierManager.GetSupplierVMs();            
                return View(model);
        }

        public IActionResult Detail(int id)
        {
            var model = SupplierManager.GetSupplierByID(id);
                {
                if(model != null)
                {
                    return View(model);
                }
                else
                {
                    return View(new SupplierVM());
                }
            }
        }
    }
}
