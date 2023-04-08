using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class CategoryRepo
    {
        private static readonly NewsTaskDBContext Context;

        static CategoryRepo()
        {
            Context = new NewsTaskDBContext();
        }

        public static IEnumerable<Category> GetAllCategories()
        {
            return Context.Categories.ToList();
        }
    }
}
