using ProductTASK.Data.Repositories.Interfaces;
using ProductTASK.Models;
using ProductTASK.Services.Interfaces;

namespace ProductTASK.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async ValueTask<Product> CreateProductAsync(Product product) =>
            await productRepository.AddAsync(product);
            
       

        public async ValueTask DeleteProductAsync(Product product)
        {
            if (product != null)
                await productRepository.RemoveAsync(product);
        }

        public ValueTask<IEnumerable<Product>> GetAllAsync() => 
            new ValueTask<IEnumerable<Product>>(productRepository.FindAll());


        public ValueTask<Product> GetByIdAsync(Guid? productId) => 
            new ValueTask<Product>(productRepository.FindByIdAsync(productId));



        public async ValueTask UpdateProductAsync(Guid productId, Product product) =>
            await productRepository.UpdateAsync(product);
            

    }
}
