using AutoMapper;
using JackShopV3.Application.InputModels;
using JackShopV3.Application.Interfaces;
using JackShopV3.Application.OutputModels;
using JackShopV3.Domain.Entities;
using JackShopV3.Domain.Interfaces;

namespace JackShopV3.Application.Services
{
    public class CategoryService : ICategoryService
    {
        protected readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            await _repository.Delete(id);
            return await _repository.Commit();

        }

        public async Task<List<CategoryDto>> GetCategoriesAsync()
        {
            var categories = await _repository.GetCategoriesAsync();

            return _mapper.Map<List<CategoryDto>>(categories);

        }

        public async Task<List<CategoryDto>> GetCategoryTitleAsync(string title)
        {
            var categories = await _repository.GetCategoryTitleAsync(title);

            return _mapper.Map<List<CategoryDto>>(title);
        }

        public async Task<CategoryDto> Post(CategoryInputModel category)
        {
            var entity = _mapper.Map<Category>(category);

            await _repository.CreateAsync(entity);

            _ = _repository.Commit();

            return _mapper.Map<CategoryDto>(entity);

        }

        public async Task<CategoryDto> Put(CategoryInputModel category)
        {
            var entity = _mapper.Map<Category>(category);

            await _repository.UpdateAsync(entity);

            _ = _repository.Commit();

            return _mapper.Map<CategoryDto>(entity);
        }
    }
}
