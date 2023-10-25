using Application.Interfaces;

namespace Infrastructure.Repositories
{
    public class ApplicationDbContext : IApplicationDbContext
    {
        public ApplicationDbContext(ICategoryRepository categories, IProductRepository products) 
        {
            Categories = categories;
            Products = products;
        }

        public ICategoryRepository Categories { get; set; }
        public IProductRepository Products { get; set; }
    }
}
