using Domain.Entity;

namespace Application.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<IReadOnlyList<Product>> GetAllProductsAsync(int categoryId);
    }
}
