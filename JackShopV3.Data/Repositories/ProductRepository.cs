using JackShopV3.Data.DatabaseContext;
using JackShopV3.Domain.Entities;
using JackShopV3.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace JackShopV3.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {

        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<Product> _dataset;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
            _dataset = context.Set<Product>();
        }


        public async Task<Product> CreateAsync(Product product)
        {
            try
            {
                using (_context)
                {
                    var result = await _dataset.FirstOrDefaultAsync(c => c.Id.Equals(product.Id));

                    product.CreateAt = DateTime.Now;
                    _dataset.Add(product);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            try
            {
                using (_context)
                {
                    var result = await _dataset.SingleOrDefaultAsync(c => c.Id.Equals(product.Id));
                    if (result != null)
                    {

                        product.UpdateAt = DateTime.Now;
                        product.CreateAt = result.CreateAt;

                        _dataset.Entry(result).CurrentValues.SetValues(product);

                    }
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return product;
        }

        public async Task<bool> Delete(Guid id)
        {
            try
            {
                using (_context)
                {
                    var result = await _dataset.SingleOrDefaultAsync(c => c.Id.Equals(id));
                    if (result != null)
                        _dataset.Remove(result);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Product> GetProductCategoryAsync(Guid id)
        {
            try
            {
                using (_context)
                {
                    var product = await _dataset
                        .Include(c => c.Category)
                        .AsNoTracking()
                        .FirstOrDefaultAsync(p => p.Id.Equals(id));

                    return product;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Product> GetProductIdAsync(Guid id)
        {
            try
            {
                using (_context)
                {
                    var result = await _dataset.FirstOrDefaultAsync(c => c.Id.Equals(id));
                    if (result is null)
                        return null;

                    return result;

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IList<Product>> GetProductsAsync()
        {
            try
            {
                return await _dataset
                    .Take(20)
                    .ToListAsync();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Commit()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public Task Rollback()
        {
            return Task.CompletedTask;
        }


    }
}
