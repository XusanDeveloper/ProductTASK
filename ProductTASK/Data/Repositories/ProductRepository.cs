using ProductTASK.Data.Context;
using ProductTASK.Data.Repositories.Interfaces;
using ProductTASK.Models;

namespace ProductTASK.Data.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
