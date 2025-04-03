namespace DataAccess.SeedData.Randoms
{
    public class RandomNavId
    {
        private static readonly Random _random = new Random();
        
        /// <summary>
        /// Bogus ile random integer değer üretmeyi keşfetmeden önce oluşturmuştum.
        /// </summary>
        /// <returns></returns>
        public static int GetNavIdMax5()
        {
            return _random.Next(1,6);
        }
    }
}
