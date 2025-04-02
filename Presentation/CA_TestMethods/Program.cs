using DataAccess.Context;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.Products;
using DataAccess.Entities.Models.WebUsers;
using DataAccess.Repositories.Concretes;

namespace CA_TestMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            GezTurizmContext gezTurizmContext = new GezTurizmContext();
            Repository<WebUserAccount> webUserRepo = new Repository<WebUserAccount>(new GezTurizmContext());

            //var all = webUserRepo.GetAllEntities();
            //foreach (var y in all)
            //{
            //    Console.WriteLine(y.Id + "\n" + y.Email + "\n" + y.UserName);
            //}

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









            Console.Read();
        }
    }
}
