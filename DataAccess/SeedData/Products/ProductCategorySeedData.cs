using Bogus;
using DataAccess.Entities.Models.Products;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.Products
{
    internal class ProductCategorySeedData
    {
        internal static List<ProductCategory> GetProductCategories(int count)
        {
            List<ProductCategory> productCategories = new List<ProductCategory>();
            Faker faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                ProductCategory category = new ProductCategory
                {
                    Id = i + 1,
                    Guid = Guid.NewGuid().ToString(),
                    CreatedDate = RandomDatetime.GetDateTime(),
                    CreatedID = Guid.NewGuid().ToString(),
                    CreatedIPAddress = faker.Internet.IpAddress().ToString(),
                    Status = RandomEnum.GetRandomStatus(),
                    CategoryName = faker.Lorem.Word(),
                    CategoryType = RandomEnum.GetRandomCategoryType(),
                    Description = string.Join(" ",faker.Lorem.Words(4))
                };
                productCategories.Add(category);
            }
            return productCategories;
        }
    }
}
