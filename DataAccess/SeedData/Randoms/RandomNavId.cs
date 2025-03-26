namespace DataAccess.SeedData.Randoms
{
    internal class RandomNavId
    {
        private static readonly Random _random = new Random();
        
        internal static int GetNavIdMax10()
        {
            return _random.Next(1,11);
        }
        internal static int GetNavIdMax100()
        {
            return _random.Next(1, 101);
        }
    }
}
