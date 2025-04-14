using System.Diagnostics;
using Bogus;
using Bogus.DataSets;
using DataAccess.Context;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Activities;
using DataAccess.Entities.Models.Employees;
using DataAccess.Entities.Models.Regions;
using DataAccess.Entities.Models.Vehicles;
using DataAccess.Repositories.Concretes.Vehicle;

namespace CA_TestMethods
{
    class Program
    {
        static async Task Main(string[] args)
        {
            #region IRepository Test
            //GezTurizmContext gezTurizmContext = new GezTurizmContext();
            //Repository<WebUserAccount> webUserRepo = new Repository<WebUserAccount>(new GezTurizmContext());
            //Repository<Product> pro = new Repository<Product>(new GezTurizmContext());
            //Faker faker = new Faker();
            //var stopwatch = new Stopwatch();


            //stopwatch.Start();
            //var all = webUserRepo.GetAllEntities();
            //var all = webUserRepo.GetAllActives();
            //var all = webUserRepo.GetAllPassives();
            //var all = webUserRepo.GetAllUnknowns();
            //foreach (var y in all)
            //{
            //    Console.WriteLine(y.Id + "\n" + y.Email + "\n" + y.UserName);
            //}
            //stopwatch.Stop();
            //Console.WriteLine();
            //Console.WriteLine(stopwatch.ElapsedMilliseconds);


            //var actives = webUserRepo.GetAllActives();
            //foreach (var y in actives)
            //{
            //    Console.WriteLine(y.Id + "\n" + y.Email + "\n" + y.UserName);
            //}

            //var passives = webUserRepo.GetAllPassives();
            //foreach (var y in passives)
            //{
            //    Console.WriteLine(y.Id + "\n" + y.Email + "\n" + y.UserName);
            //}

            //var unknowns = webUserRepo.GetAllUnknowns();
            //foreach (var y in unknowns)
            //{
            //    Console.WriteLine(y.Id + "\n" + y.Email + "\n" + y.UserName);
            //}

            //var updated = webUserRepo.GetAllUpdated();
            //foreach (var y in updated)
            //{
            //    Console.WriteLine(y.Id + "\n" + y.Email + "\n" + y.UserName);
            //}

            //var updated = webUserRepo.GetAllNotUpdated();
            //foreach (var y in updated)
            //{
            //    Console.WriteLine(y.Id + " " + y.Email + " " + y.UserName+ "\n");
            //}

            //var updated =await webUserRepo.GetByIdAsync(2);
            //Console.WriteLine(updated.Id+" "+updated.UserName+" "+updated.Email);


            //var x = pro.GetEntitiesBetweenId(15, 55);
            //foreach (var entity in x)
            //{
            //    Console.WriteLine(entity.Id+" "+entity.ProductName);
            //}
            //var updated = webUserRepo.GetEntitiesByCreatedDate(new DateTime(2006, 01, 17));
            //foreach (var y in updated)
            //{
            //    Console.WriteLine(y.Id + " " + y.Email + " " + y.UserName + "\n");
            //}

            //var updated = webUserRepo.GetEntitiesByUpdatedDate(new DateTime(2006, 01, 17));
            //foreach (var y in updated)
            //{
            //    Console.WriteLine(y.Id + " " + y.Email + " " + y.UserName + "\n");
            //}

            //var updated = 
            //    webUserRepo.GetEntitiesBetweenCreatedDates(new DateTime(2006, 01, 17), new DateTime(2015, 01, 17));
            //foreach (var y in updated)
            //{
            //    Console.WriteLine(y.Id + " " + y.Email + " " + y.UserName + "\n");
            //}

            //var updated =
            //    webUserRepo.GetEntitiesBetweenUpdatedDates(new DateTime(2006, 01, 17), new DateTime(2015, 01, 17));
            //foreach (var y in updated)
            //{
            //    Console.WriteLine(y.Id + " " + y.Email + " " + y.UserName + "\n");
            //}



            //miliseconds.Start();
            //List<WebUserAccount> webUserAccounts = new List<WebUserAccount>();
            //for (int i = 0; i < 20; i++)
            //{
            //WebUserAccount webUserAccount = new WebUserAccount
            //{
            //    Guid = Guid.NewGuid().ToString(),
            //    CreatedDate = RandomDatetime.GetDateTime(),//Başlangıç verilerimiz rastgele olsun
            //    CreatedID = Guid.NewGuid().ToString(),
            //    CreatedIPAddress = faker.Internet.IpAddress().ToString(),
            //    Status = RandomEnum.GetRandomStatus(),
            //    IsUpdated = faker.Random.Bool(0.2f),
            //    UserName = faker.Name.FirstName() + faker.Random.Int(1, 1500),
            //    PasswordHash = BCrypt.Net.BCrypt.HashPassword(faker.Lorem.Word()),
            //    Email = faker.Internet.Email(),
            //    PhoneNumber = faker.Phone.PhoneNumber("05#########"),
            //    CountryId = RandomNavId.GetNavIdMax5(),
            //    LockoutEnabled = false,
            //    LockoutEnd = DateTime.Now.AddDays(7)
            //};
            //await webUserRepo.CreateAsync(webUserAccount);

            //    webUserAccount.NormalizedUserName = webUserAccount.UserName.ToUpper();
            //    webUserAccount.NormalizedEmail = webUserAccount.Email.ToUpper();
            //    webUserAccounts.Add(webUserAccount);
            //}
            //await webUserRepo.CreateBulkAsync(webUserAccounts);
            //await webUserRepo.CreateRangeAsync(webUserAccounts);
            //miliseconds.Stop();
            //decimal netSecond = saveChanges.ElapsedMilliseconds / 1000;
            //Console.WriteLine(netSecond);
            //Console.WriteLine(miliseconds.ElapsedMilliseconds);
            //%10 falan farkediyor çok da tınn..

            //stopwatch.Start();
            //Product product = new Product
            //{
            //    Id = 1,
            //    Guid = Guid.NewGuid().ToString(),
            //    CreatedDate = RandomDatetime.GetDateTime(),
            //    CreatedID = Guid.NewGuid().ToString(),
            //    CreatedIPAddress = faker.Internet.IpAddress().ToString(),
            //    Status = RandomEnum.GetRandomStatus(),
            //    IsUpdated = faker.Random.Bool(0.2f),
            //    ProductName = faker.Lorem.Word() + faker.Lorem.Word() + faker.Lorem.Word(),
            //    Description = string.Join(" ", faker.Lorem.Words(6)),
            //    UnitPrice = faker.Random.Float(min: 100f, max: 1200f),
            //    UnitsInStock = faker.Random.Byte(10, 180),
            //    ProductSupplierId = RandomNavId.GetNavIdMax5(),
            //    CategoryId = RandomNavId.GetNavIdMax5(),
            //};
            //await pro.Update(product);
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.ElapsedMilliseconds);

            //stopwatch.Start();
            //List<Product> products = new List<Product>();
            //for (int i = 0; i < 50; i++)
            //{
            //    Product product = new Product
            //    {
            //        Id = i,
            //        Guid = Guid.NewGuid().ToString(),
            //        CreatedDate = RandomDatetime.GetDateTime(),
            //        CreatedID = Guid.NewGuid().ToString(),
            //        CreatedIPAddress = faker.Internet.IpAddress().ToString(),
            //        Status = RandomEnum.GetRandomStatus(),
            //        IsUpdated = faker.Random.Bool(0.2f),
            //        ProductName = faker.Lorem.Word() + faker.Lorem.Word() + faker.Lorem.Word(),
            //        Description = string.Join(" ", faker.Lorem.Words(6)),
            //        UnitPrice = faker.Random.Float(min: 100f, max: 1200f),
            //        UnitsInStock = faker.Random.Byte(10, 180),
            //        ProductSupplierId = RandomNavId.GetNavIdMax5(),
            //        CategoryId = RandomNavId.GetNavIdMax5(),
            //    };
            //    products.Add(product);
            //}
            ////await pro.UpdateRangeAsync(products);
            //await pro.UpdateRangeAsync(products);
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.ElapsedMilliseconds);

            //stopwatch.Start();
            //var x = pro.GetAllUnknowns();
            //await pro.DestroyRangeSelectAsync(500, 604);
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.ElapsedMilliseconds); 
            #endregion
            #region ICompanyRepositoryTest
            //GezTurizmContext gezTurizmContext = new GezTurizmContext();
            //CompanyRepository<ProductSupplier> productSupplierRepo =
            //    new CompanyRepository<ProductSupplier>(new GezTurizmContext());
            //Stopwatch stopwatch = new Stopwatch();
            //Faker faker = new Faker();

            ////stopwatch.Start();
            ////List<ProductSupplier> products = new List<ProductSupplier>();
            ////for (int i = 0; i < 50; i++)
            ////{
            ////    ProductSupplier supplier = new ProductSupplier
            ////    {
            ////        Guid = Guid.NewGuid().ToString(),
            ////        CreatedDate = RandomDatetime.GetDateTime(),
            ////        CreatedID = Guid.NewGuid().ToString(),
            ////        CreatedIPAddress = faker.Internet.IpAddress().ToString(),
            ////        Status = RandomEnum.GetRandomStatus(),
            ////        IsUpdated = faker.Random.Bool(0.2f),
            ////        CompanyName = faker.Company.CompanyName() + " " + faker.Company.CompanySuffix(),
            ////        ContactName = faker.Name.FullName(),
            ////        ContactTitle = faker.Name.JobTitle(),
            ////        Email = faker.Internet.Email(),
            ////        PhoneNumber = faker.Phone.PhoneNumber("021########"),
            ////        Address = faker.Address.FullAddress(),
            ////    };
            ////    products.Add(supplier);
            ////}
            ////await productSupplierRepo.CreateRangeAsync(products);
            ////stopwatch.Stop();
            ////Console.WriteLine(stopwatch.ElapsedMilliseconds);

            ////var x = productSupplierRepo.SearchByCompanyName("ah");
            ////foreach (var item in x)
            ////{
            ////    Console.WriteLine(item.CompanyName+" "+item.Guid);
            ////}

            //stopwatch.Start();
            //var x =  
            #endregion
            GezTurizmContext gezTurizmContext = new GezTurizmContext();
            GenericVehicleRepository<RentalVehicle> test = new GenericVehicleRepository<RentalVehicle>(new GezTurizmContext());
            Stopwatch stopwatch = new Stopwatch();
            Faker faker = new Faker();

            var x = test.GetVehicleByVehicleType(VehicleType.Minibus);
            foreach (var item in x)
            {
                Console.WriteLine(item.Model);
            }




            Console.Read();
        }
    }
}
