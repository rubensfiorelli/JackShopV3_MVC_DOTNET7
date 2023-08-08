using AutoMapper;
using JackShopV3.Application.InputModels;
using JackShopV3.Application.Interfaces;
using JackShopV3.Application.OutputModels;
using JackShopV3.Domain.Entities;
using JackShopV3.Domain.Interfaces;

namespace JackShopV3.Application.Services
{
    public class ProductService : IProductService
    {

        protected readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ProductDto> Post(ProductInputModel product)
        {
            var entity = _mapper.Map<Product>(product);

            await _repository.CreateAsync(entity);

            _ = _repository.Commit();

            return _mapper.Map<ProductDto>(entity);
        }

        public async Task<ProductDto> Put(ProductInputModel product)
        {
            var entity = _mapper.Map<Product>(product);

            await _repository.UpdateAsync(entity);

            _ = _repository.Commit();

            return _mapper.Map<ProductDto>(entity);
        }

        public async Task<bool> Delete(Guid id)
        {
            await _repository.Delete(id);
            return await _repository.Commit();
        }

        public async Task<ProductDto> GetProductCategoryAsync(Guid id)
        {
            var product = await _repository.GetProductCategoryAsync(id);

            return _mapper.Map<ProductDto>(product);
        }

        public async Task<ProductDto> GetProductIdAsync(Guid id)
        {
            var product = await _repository.GetProductIdAsync(id);

            return _mapper.Map<ProductDto>(product);
        }

        public async Task<IList<ProductDto>> GetProductsAsync()
        {
            var products = await _repository.GetProductsAsync();

            return _mapper.Map<List<ProductDto>>(products);
        }


    }
}
