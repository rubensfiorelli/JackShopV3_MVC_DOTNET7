using JackShopV3.Domain.Entities;

namespace JackShopV3.Domain.Interfaces
{
    public interface IProductRepository : IUnitOfWork
    {
        Task<IList<Product>> GetProductsAsync();
        Task<Product> GetProductIdAsync(Guid id);
        Task<Product> GetProductCategoryAsync(Guid id);
        Task<Product> CreateAsync(Product product);
        Task<Product> UpdateAsync(Product product);
        Task<bool> Delete(Guid id);
    }
}
