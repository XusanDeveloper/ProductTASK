using ProductTASK.Data.Context;
using ProductTASK.Data.Repositories.Interfaces;
using ProductTASK.Models;
using ProductTASK.Services.Interfaces;
using System.Security.Claims;

namespace ProductTASK.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        private readonly ApplicationDbContext dbContext;


        public ProductService(IProductRepository productRepository, ApplicationDbContext dbContext)
        {
            this.productRepository = productRepository;
            this.dbContext = dbContext;
        }

        public async ValueTask<Product> CreateProductAsync(string userId, Product product) 
        {
            var newProduct = await productRepository.AddAsync(product);
            await productRepository.SaveChanges(userId);

            return newProduct;
        }
            
       

        public async ValueTask DeleteProductAsync(string userId, Product product)
        {
            if (product != null)
                await productRepository.RemoveAsync(product);
            await productRepository.SaveChanges(userId);
        }

        public ValueTask<IEnumerable<Product>> GetAllAsync() => 
            new ValueTask<IEnumerable<Product>>(productRepository.FindAll());


        public ValueTask<Product> GetByIdAsync(Guid? productId) => 
            new ValueTask<Product>(productRepository.FindByIdAsync(productId));



        public async ValueTask UpdateProductAsync(string userId, Guid productId, Product product)
        {
            var oldProduct = productRepository.FindByIdAsync(productId);

            await productRepository.UpdateAsync(product);

            productRepository.SaveAudit(oldProduct!, product);

            await productRepository.SaveChanges(userId);
        }
            


    }
}
