using ProductTASK.Models;

namespace ProductTASK.Services.Interfaces
{
    public interface IProductService
    {
        public ValueTask<IEnumerable<Product>> GetAllAsync();
        public ValueTask<Product> GetByIdAsync(Guid? productId);
        public ValueTask<Product> CreateProductAsync(Product product);
        ValueTask UpdateProductAsync(Guid productId, Product product);
        ValueTask DeleteProductAsync(Product product);
    }
}
