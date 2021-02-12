using AdminTemplate.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AdminTemplate.Managers
{
    public class PostManager
    {
        static string data = File.ReadAllText(@"C:\Users\Ece\source\repos\AdminTemplate\wwwroot\posts.json");

        static List<PostVM> posts = JsonConvert.DeserializeObject<List<PostVM>>(data);

        public static List<PostVM> GetPosts()
        {
            return posts;
        }

    }
}
