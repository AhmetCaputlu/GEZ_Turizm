using Bogus;
using DataAccess.Entities.Models.OrderDetails;
using DataAccess.SeedData.Products;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.OrderDetails
{
    internal class ProductOrderDetailSeedData
    {
        internal static List<ProductOrderDetail> GetProductOrderDetails(int count)
        {
            List<ProductOrderDetail> productOrderDetails = new List<ProductOrderDetail>();
            Faker faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                ProductOrderDetail productOrderDetail = new ProductOrderDetail
                {
                    Id = i + 1,
                    Guid = Guid.NewGuid().ToString(),
                    CreatedDate = RandomDatetime.GetDateTime(),
                    CreatedID = Guid.NewGuid().ToString(),
                    CreatedIPAddress = faker.Internet.IpAddress().ToString(),
                    Status = RandomEnum.GetRandomStatus(),
                    IsUpdated = faker.Random.Bool(0.2f),
                    UnitPrice = faker.Random.Decimal(100m, 1200m),
                    Quantity = faker.Random.Byte(1, 4),
                    Discount = faker.Random.Decimal(0, 0.5m),
                    ProductId = faker.Random.Int(1,500),
                    ProductOrderId = faker.Random.Int(1,80)
                };

                productOrderDetails.Add(productOrderDetail);
            }
            return productOrderDetails;
        }
    }
}
