using AdminTemplate.Managers;
using AdminTemplate.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminTemplate.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {


            var model = CategoryManager.GetCategoryVMs();
            return View(model);

        }

        public IActionResult Detail(int id)
        {
            var model = CategoryManager.GetCategoryById(id);
            if(model != null)
            {
                return View(model);
            }
            else
            {
                return View(new CategoryVM());
            }
            
        }
    }
}
