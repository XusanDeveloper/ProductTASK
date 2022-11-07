using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductTASK.Models;

namespace ProductTASK.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData
                (
                    new Product
                    {
                        Id = new Guid("2E14795B-E06A-4971-99BC-FF9372E6ED74"),
                        Title = "HDD You 1TB",
                        Quantity = 55,
                        Price = 74.09,
                        TotalPrice = (decimal)((2.05) * (55 * 74.09)),
                        CreatedAt = DateTime.Now
                    },
                    new Product
                    {
                        Id = new Guid("B719B27F-D2AC-4F00-83BF-A4E56E194C70"),
                        Title = "HDD SSD 512GB",
                        Quantity = 102,
                        Price = 190.99,
                        TotalPrice = (decimal)((2.05) * (102 * 190.99)),
                        CreatedAt = DateTime.Now
                    },
                    new Product
                    {
                        Id = new Guid("7CDB71FB-BB3A-4B12-99DB-1F2DE85675A6"),
                        Title = "RAM DDR4 16GB",
                        Quantity = 47,
                        Price = 80.32,
                        TotalPrice = (decimal)((2.05) * (47 * 80.32)),
                        CreatedAt = DateTime.Now,
                    }
                );
        }
    }
}
