using ProductTASK.Data.Context;
using ProductTASK.Data.Repositories.Interfaces;
using ProductTASK.Models;

namespace ProductTASK.Data.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public readonly ApplicationDbContext dbContext;
        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public void SaveAudit(Product oldProduct, Product model) => dbContext.Entry(oldProduct).CurrentValues.SetValues(model);

        IQueryable<Audit> IProductRepository.GetAllAuditLogs() => dbContext.Set<Audit>();
    }
}
