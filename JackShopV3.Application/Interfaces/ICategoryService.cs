using JackShopV3.Application.InputModels;
using JackShopV3.Application.OutputModels;

namespace JackShopV3.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<List<CategoryDto>> GetCategoriesAsync();
        Task<List<CategoryDto>> GetCategoryTitleAsync(string title);
        Task<CategoryDto> Post(CategoryInputModel category);
        Task<CategoryDto> Put(CategoryInputModel category);
        Task<bool> Delete(Guid id);
    }
}
