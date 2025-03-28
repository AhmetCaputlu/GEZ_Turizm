﻿using DataAccess.Entities.Enums;

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
        internal static DriverLicense GetRandomDriverLicense()
        {
            Array values = Enum.GetValues(typeof(DriverLicense));
            return (DriverLicense)values.GetValue(_random.Next(values.Length));
        }
        internal static Language GetRandomLanguage()
        {
            Array values = Enum.GetValues(typeof(Language));
            return (Language)values.GetValue(_random.Next(values.Length));
        }
        internal static VehicleType GetRandomVehicleType()
        {
            Array values = Enum.GetValues(typeof(VehicleType));
            return (VehicleType)values.GetValue(_random.Next(values.Length));
        }
        internal static TourCategory GetRandomTour()
        {
            Array values = Enum.GetValues(typeof(TourCategory));
            return (TourCategory)values.GetValue(_random.Next(values.Length));
        }
        internal static EventCategory GetRandomEvent()
        {
            Array values = Enum.GetValues(typeof(EventCategory));
            return (EventCategory)values.GetValue(_random.Next(values.Length));
        }
    }
}
