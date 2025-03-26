using System;

namespace DataAccess.SeedData.Randoms
{
    internal class RandomDatetime
    {
        private static readonly Random _random = new Random();
        /// <summary>
        ///Bu metod geçmiş bir zaman için rastgele bir veri üretmek için yazıldı.
        /// </summary>
        /// <returns></returns>
        internal static DateTime GetDateTime()
        {
            DateTime today = new DateTime
                (_random.Next(2000, 2022), _random.Next(1, 13), _random.Next(1, 28),
                _random.Next(1, 24), _random.Next(8, 60), _random.Next(2, 55));
            return today;
        }
        /// <summary>
        /// Bu metod geçmiş bir zaman için rastgele (ve anlamlı) doğum tarihi üretmek için yazıldı.
        /// </summary>
        /// <returns></returns>
        internal static DateTime GetBirthDateTime()
        {
            DateTime today = new DateTime
                (_random.Next(1950, 2007), _random.Next(1, 13), _random.Next(1, 28),
                _random.Next(1, 24), _random.Next(8, 60), _random.Next(2, 55));
            return today;
        }
        /// <summary>
        /// Bu metod geçmiş bir zaman için rastgele (işçiler için anlamlı) doğum tarihi üretmek için yazıldı.
        /// </summary>
        /// <returns></returns>
        internal static DateTime GetEmployeeBirthDateTime()
        {
            DateTime today = new DateTime
                (_random.Next(1960,1995), _random.Next(1, 13), _random.Next(1, 28),
                _random.Next(1, 24), _random.Next(8, 60), _random.Next(2, 55));
            return today;
        }
    }
}
