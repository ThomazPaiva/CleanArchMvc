using CleanArchMvcDomain.Entities;

namespace CleanArchMvcDomain.Interfaces
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetCategories();

        Task<Category> GetById(int? id);

        Task<Category> Create(Category category);

        Task<Category> Update(Category category);

        Task<Category> Delete(Category category);
    }
}
