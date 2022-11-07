using ProductTASK.Models;

namespace ProductTASK.Services.Interfaces
{
    public interface IProductService
    {
        public ValueTask<IEnumerable<Product>> GetAllAsync();
        public ValueTask<Product> GetByIdAsync(Guid? productId);
        public ValueTask<Product> CreateProductAsync(string userId, Product product);
        ValueTask UpdateProductAsync(string userId, Guid productId, Product product);
        ValueTask DeleteProductAsync(string userId, Product product);
    }
}
