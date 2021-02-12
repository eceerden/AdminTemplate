using AdminTemplate.Managers;
using AdminTemplate.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminTemplate.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            var model = OrderManager.GetOrderVMs();
            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var model = OrderManager.GetOrderById(id);
            if (model != null)
            {
                return View(model);

            }
            else
            {
                return View(new OrderVM());
            }
        }

    }
}
