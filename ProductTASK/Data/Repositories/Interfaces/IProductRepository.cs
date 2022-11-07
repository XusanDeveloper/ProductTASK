using ProductTASK.Models;

namespace ProductTASK.Data.Repositories.Interfaces
{
    public interface IProductRepository : IGenericRepository<Product> 
    {
        void SaveAudit(Product oldProduct, Product model);
        IQueryable<Audit> GetAllAuditLogs();
    }
}
