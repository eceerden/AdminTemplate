using AdminTemplate.Managers;
using AdminTemplate.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminTemplate.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index(int id)
        {
            var model = CommentManager.GetCommentById(id);

            if(model != null)
            {
            return View(model);
            }
            else
            {
                return View(new CommentVM());
            }
            
        }
    }
}
