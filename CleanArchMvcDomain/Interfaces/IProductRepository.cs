using CleanArchMvcDomain.Entities;

namespace CleanArchMvcDomain.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductsAsync();

        Task<Product> GetByIdAsync(int? id);

        Task<Product> CreateAsync(Product product);

        Task<Product> UpdateAsync(Product product);

        Task<Product> DeleteAsync(Product product);
    }
}
