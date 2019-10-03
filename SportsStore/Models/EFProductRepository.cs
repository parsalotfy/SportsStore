using System.Linq;

namespace SportsStore.Models
{
    public class EFProductRepository : IProductRepository
    {
        private SportsStoreContext context;
        public EFProductRepository(SportsStoreContext sportsStoreContext)
        {
            context = sportsStoreContext;
        }
        public IQueryable<Product> Products => context.Products;
    }
}
