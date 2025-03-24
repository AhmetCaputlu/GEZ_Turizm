using DataAccess.Context;
using DataAccess.SeedData.WebUsers;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            GezTurizmContext gezTurizmContext = new GezTurizmContext();
            gezTurizmContext.Add(WebUserAccountSeedData.GetUserAccounts(1));
            gezTurizmContext.SaveChanges();

        }
    }
}