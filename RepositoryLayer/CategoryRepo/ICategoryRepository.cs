using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.CategoryRepo
{
    public interface ICategoryRepository
    {
        public Task<Category> GetByIdCategory(int id);
        public Task<IEnumerable<Category>> GetAllCategory();
        public Task<Category> AddCategory(Category category);
        public Task<Category> UpdateCategory(Category category);
        public Task<int> DeleteCategory(int id);
    }
}
