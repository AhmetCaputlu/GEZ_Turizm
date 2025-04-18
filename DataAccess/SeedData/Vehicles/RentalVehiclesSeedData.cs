﻿using Bogus;
using DataAccess.Entities.Models.Vehicles;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.Vehicles
{
    internal class RentalVehiclesSeedData
    {
        internal static List<RentalVehicle> GetRentalVehicles(int count)
        {
            List<RentalVehicle> rentalVehicles = new List<RentalVehicle>();
            Faker faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                RentalVehicle rentalVehicle = new RentalVehicle
                {
                    Id = i + 1,
                    Guid = Guid.NewGuid().ToString(),
                    CreatedDate = RandomDatetime.GetDateTime(),
                    CreatedID = Guid.NewGuid().ToString(),
                    CreatedIPAddress = faker.Internet.IpAddress().ToString(),
                    Status = RandomEnum.GetRandomStatus(),
                    IsUpdated = faker.Random.Bool(0.2f),
                    VehicleType = RandomEnum.GetRandomVehicleType(),
                    LicensePlate =
                    faker.Random.Int(1, 82).ToString() + " " + faker.Random.Char('a', 'z')
                    + faker.Random.Char('a', 'z') + " " + faker.Random.Int(1, 10000),
                    Model = faker.Vehicle.Model(),
                    Kilometer = faker.Random.Int(6000, 1000000),
                    Age = faker.Random.Int(1, 15),
                    Capacity = (short)faker.Random.Int(2, 100),
                    DailyRentalFee = faker.Random.Int(5000, 25000),
                    StartDate = RandomDatetime.GetDateTime(),
                    RentalVehicleSupplierId = faker.Random.Int(1, 5),
                    ActivityId = faker.Random.Int(1, 5),
                    IsAvailable = faker.Random.Bool(0.2f)
                };
                rentalVehicle.ExpireDate = rentalVehicle.StartDate.AddDays(faker.Random.Int(1, 5));
                rentalVehicles.Add(rentalVehicle);
            }
            return rentalVehicles;
        }
    }
}
