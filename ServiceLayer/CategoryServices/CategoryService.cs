using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.CategoryRepo;
using ServiceLayer.DTOs.Resquests.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository,IMapper mapper)
        {
            _categoryRepository=categoryRepository;
            _mapper=mapper;
        }
        public async Task<Category> AddCategory(ResquestAddCategory category)
        {
            var categoryMapper = _mapper.Map<Category>(category);
            try
            {
                var addCategory = await _categoryRepository.AddCategory(categoryMapper);
                return addCategory;
            }
            catch (Exception )
            {
                throw;
            }    
        }

        public Task<int> DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Category>> GetAllCategory()
        {
          var getAllCategory = await _categoryRepository.GetAllCategory();
            if(getAllCategory == null)
            {
                throw new Exception("Error null");
            }
            return getAllCategory;
        }

        public Task<Category> GetByIdCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Category> UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
