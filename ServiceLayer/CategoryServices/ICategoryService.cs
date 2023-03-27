using DomainLayer.Entities;
using ServiceLayer.DTOs.Resquests.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.CategoryServices
{
    public interface  ICategoryService
    {
        public Task<Category> GetByIdCategory(int id);
        public Task<IEnumerable<Category>> GetAllCategory();
        public Task<Category> AddCategory(ResquestAddCategory category);
        public Task<Category> UpdateCategory(Category category);
        public Task<int> DeleteCategory(int id);
    }
}
