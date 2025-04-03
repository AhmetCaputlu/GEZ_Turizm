using Bogus;
using DataAccess.Entities.Models.Products;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.Products
{
    internal class ProductSeedData
    {
        internal static List<Product> GetProducts(int count)
        {
            List<Product> products = new List<Product>();
            Faker faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                Product product = new Product
                {
                    Id = i + 1,
                    Guid = Guid.NewGuid().ToString(),
                    CreatedDate = RandomDatetime.GetDateTime(),
                    CreatedID = Guid.NewGuid().ToString(),
                    CreatedIPAddress = faker.Internet.IpAddress().ToString(),
                    Status = RandomEnum.GetRandomStatus(),
                    IsUpdated = faker.Random.Bool(0.2f),
                    ProductName = faker.Lorem.Word() + faker.Lorem.Word() + faker.Lorem.Word(),
                    Description = string.Join(" ", faker.Lorem.Words(6)),
                    UnitPrice = faker.Random.Float(min: 100f, max: 1200f),
                    UnitsInStock = faker.Random.Byte(10, 180),
                    ProductSupplierId = RandomNavId.GetNavIdMax5(),
                    CategoryId = RandomNavId.GetNavIdMax5(),
                };
                products.Add(product);
            }
            return products;
        }
    }
}
