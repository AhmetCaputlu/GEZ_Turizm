using DataAccess.Entities.Enums;

namespace DataAccess.SeedData.Randoms
{
    internal class RandomEnum
    {
        private static readonly Random _random = new Random();
        internal static Gender GetRandomGender()
        {
            Array values = Enum.GetValues(typeof(Gender));
            return (Gender)values.GetValue(_random.Next(values.Length));
        }
        internal static DataStatus GetRandomStatus()
        {
            Array values = Enum.GetValues(typeof(DataStatus));
            return (DataStatus)values.GetValue(_random.Next(values.Length));
        }
        internal static Continent GetRandomContinent()
        {
            Array values = Enum.GetValues(typeof(Continent));
            return (Continent)values.GetValue(_random.Next(values.Length));
        }
        internal static Department GetRandomDepartment()
        {
            Array values = Enum.GetValues(typeof(Department));
            return (Department)values.GetValue(_random.Next(values.Length));
        }
    }
}
