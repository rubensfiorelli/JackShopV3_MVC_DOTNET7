using JackShopV3.Application.InputModels;
using JackShopV3.Application.OutputModels;

namespace JackShopV3.Application.Interfaces
{
    public interface IProductService
    {
        Task<IList<ProductDto>> GetProductsAsync();
        Task<ProductDto> GetProductIdAsync(Guid id);
        Task<ProductDto> GetProductCategoryAsync(Guid id);
        Task<ProductDto> Post(ProductInputModel product);
        Task<ProductDto> Put(ProductInputModel product);
        Task<bool> Delete(Guid id);
    }
}
