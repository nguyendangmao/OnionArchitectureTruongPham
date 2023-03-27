using AutoMapper;
using DomainLayer.Entities;
using ServiceLayer.DTOs.Resquests.Category;

namespace ServiceLayer.Mapper
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
          
            CreateMap<Category, ResquestAddCategory>().ReverseMap();
        }
    }
}
