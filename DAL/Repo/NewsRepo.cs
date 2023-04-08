using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class NewsRepo
    {
        static NewsRepo()
        {
            Context = new NewsTaskDBContext();
        }

        public static NewsTaskDBContext Context { get; }

        public static IEnumerable<News> GetAllNews()
        {
            return Context.News.ToList();
        }
    }
}
