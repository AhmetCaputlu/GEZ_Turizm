using Bogus;
using DataAccess.Context;
using DataAccess.Entities.Models.Orders;
using DataAccess.Entities.Models.WebUsers;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.Orders
{
    internal class ProductOrderSeedData
    {
        internal static List<ProductOrder> GetProductOrders(int count)
        {
            List<ProductOrder> productOrders = new List<ProductOrder>();
            Faker faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                ProductOrder productOrder = new ProductOrder
                {
                    Id = i + 1,
                    Guid = Guid.NewGuid().ToString(),
                    CreatedDate = RandomDatetime.GetDateTime(),
                    CreatedID = Guid.NewGuid().ToString(),
                    CreatedIPAddress = faker.Internet.IpAddress().ToString(),
                    Status = RandomEnum.GetRandomStatus(),
                    Note = faker.Random.Words(4),
                    WebUserEmail = faker.Internet.Email(),
                    WebUserAccountId = RandomNavId.GetNavIdMax5(),
                    EmployeeId = RandomNavId.GetNavIdMax5()
                };
                productOrders.Add(productOrder);
            }
            return productOrders;
        }
    }
}
