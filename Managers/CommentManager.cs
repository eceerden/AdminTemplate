using AdminTemplate.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AdminTemplate.Managers
{
    public class CommentManager
    {
        static string data = File.ReadAllText(@"C:\Users\Ece\source\repos\AdminTemplate\wwwroot\comments.json");

      

        static List<CommentVM> comments = JsonConvert.DeserializeObject<List<CommentVM>>(data);

        public static List<CommentVM> GetCommentById(int id)
        {
            var model = comments.Where(w => w.postId == id).ToList();
            return model;
        }
    }
}
