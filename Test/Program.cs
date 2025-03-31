using Bogus;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Faker faker = new Faker();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(faker.Phone.PhoneNumber());
            }
        }
    }
}