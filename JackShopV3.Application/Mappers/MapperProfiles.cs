using AutoMapper;
using JackShopV3.Application.InputModels;
using JackShopV3.Application.OutputModels;
using JackShopV3.Domain.Entities;

namespace JackShopV3.Application.Mappers
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<Product, ProductDto>();

            CreateMap<CategoryInputModel, Category>();
            CreateMap<ProductInputModel, Product>();


        }
    }
}
