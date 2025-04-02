namespace DataAccess.SeedData.Randoms
{
    internal class RandomNavId
    {
        private static readonly Random _random = new Random();
        
        /// <summary>
        /// Bogus ile random integer değer üretmeyi keşfetmeden önce oluşturmuştum.
        /// </summary>
        /// <returns></returns>
        internal static int GetNavIdMax5()
        {
            return _random.Next(1,6);
        }
    }
}
