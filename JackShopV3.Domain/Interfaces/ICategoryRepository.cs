using JackShopV3.Domain.Entities;

namespace JackShopV3.Domain.Interfaces
{
    public interface ICategoryRepository : IUnitOfWork
    {
        Task<IList<Category>> GetCategoriesAsync();
        Task<Category> GetCategoryIdAsync(Guid id);
        Task<List<Category>> GetCategoryTitleAsync(string title);
        Task<Category> CreateAsync(Category category);
        Task<Category> UpdateAsync(Category category);
        Task<bool> Delete(Guid id);
    }
}
