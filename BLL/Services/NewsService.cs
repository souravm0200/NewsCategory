using BLL.DTOs;
using DAL.Models;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class NewsService
    {

        public static List<NewsDTO> GetAllNews()
        {
            var data = NewsRepo.GetAllNews();
            return NewsConverter(data);
        }

        private static List<NewsDTO> NewsConverter(IEnumerable<DAL.Models.News> data)
        {
            return data.Select(NewsConverter).ToList();
        }

        private static NewsDTO NewsConverter(DAL.Models.News data)
        {
            var news = new NewsDTO()
            {
                Id = data.Id,
                Title = data.Title,
                Description = data.Description,
                Cid = data.Cid,
                Date = data.Date,
                Category = CategoryConverter(data.Category)
            };
            return news;
        }

        private static DAL.Models.News NewsConverter(NewsDTO data)
        {
            var news = new DAL.Models.News()
            {
                Id = data.Id,
                Title = data.Title,
                Description = data.Description,
                Cid = data.Cid,
                Date = data.Date,
            };
            return news;
        }

        private static CategoryDTO CategoryConverter(DAL.Models.Category category)
        {
            return new CategoryDTO()
            {
                Id = category.Id,
                Name = category.Name,
            };
            
        }
    }
}
