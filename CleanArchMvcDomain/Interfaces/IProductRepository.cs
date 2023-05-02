using CleanArchMvcDomain.Entities;

namespace CleanArchMvcDomain.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductsAsync();

        Task<Product> GetByIdAsync(int? id);

        Task<Product> CreateAsync(Product category);

        Task<Product> UpdateAsync(Product category);

        Task<Product> DeleteAsync(Product category);
    }
}
