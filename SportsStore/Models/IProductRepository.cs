using System.Linq;

namespace SportsStore.Models
{
    interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
