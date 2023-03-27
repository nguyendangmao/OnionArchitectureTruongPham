using DomainLayer.Data;
using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.CategoryRepo
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context) { _context = context;  }
        public async Task<Category> AddCategory(Category category)
        {
            await _context.AddAsync(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<int> DeleteCategory(int id)
        {
            var deleteCategory=await _context.Categories!.FirstOrDefaultAsync(x => x.Id == id);
            if (deleteCategory != null)
            {
                _context.Remove(id);
            }
            else
            {
                throw new ArgumentNullException("Not Found");
            }
          
            await _context.SaveChangesAsync();
            return deleteCategory.Id;
        }

        public async Task<IEnumerable<Category>> GetAllCategory()
        {
           var getAllCategory= await _context.Categories!.ToListAsync();
            return getAllCategory;
        }

        public async Task<Category> GetByIdCategory(int id)
        {
            var getByIdCategory = await _context.Categories!.FindAsync(id);
            return getByIdCategory!;
        }

        public async Task<Category> UpdateCategory(Category category)
        {
            _context.Categories!.Update(category);
            await _context.SaveChangesAsync();
            return category;
        }
    }
}
