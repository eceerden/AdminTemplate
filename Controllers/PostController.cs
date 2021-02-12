using AdminTemplate.Managers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminTemplate.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            var model = PostManager.GetPosts();
            return View(model);
        }
    }
}
