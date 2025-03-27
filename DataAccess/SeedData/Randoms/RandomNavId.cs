namespace DataAccess.SeedData.Randoms
{
    internal class RandomNavId
    {
        private static readonly Random _random = new Random();
        
        internal static int GetNavIdMax5()
        {
            return _random.Next(1,6);
        }
        internal static int GetNavIdMax100()
        {
            return _random.Next(1, 101);
        }
    }
}
