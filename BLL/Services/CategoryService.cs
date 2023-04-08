using BLL.DTOs;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CategoryService
    {
        public static List<CategoryDTO> GetAllCategories()
        {
            var data = CategoryRepo.GetAllCategories();
            return CategoryConverter(data);
        }


        private static List<CategoryDTO> CategoryConverter(IEnumerable<DAL.Models.Category> data)
        {
            return data.Select(CategoryConverter).ToList();
        }
        private static CategoryDTO CategoryConverter(DAL.Models.Category data)
        {
            var category = new CategoryDTO()
            {
                Id = data.Id,
                Name = data.Name,
            };
            return category;
        }

        private static DAL.Models.Category CategoryConverter(CategoryDTO data)
        {
            var category = new DAL.Models.Category()
            {
                Id = data.Id,
                Name = data.Name,
            };
            return category;
        }
    }
}
