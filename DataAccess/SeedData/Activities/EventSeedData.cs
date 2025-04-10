﻿using Bogus;
using DataAccess.Entities.Models.Activities;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.Activities
{
    internal class EventSeedData
    {
        internal static List<Event> GetEvents(int count)
        {
            List<Event> events = new List<Event>();
            Faker faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                Event even = new Event
                {
                    Id = i + 1,
                    Guid = Guid.NewGuid().ToString(),
                    CreatedDate = RandomDatetime.GetDateTime(),
                    CreatedID = Guid.NewGuid().ToString(),
                    CreatedIPAddress = faker.Internet.IpAddress().ToString(),
                    Status = RandomEnum.GetRandomStatus(),
                    IsUpdated = faker.Random.Bool(0.2f),
                    EventName = faker.Lorem.Word(),
                    StartDate = RandomDatetime.GetDateTime(),
                    Description = faker.Random.Words(8),
                    RegionId = faker.Random.Int(1, 5),
                    EventCategory = RandomEnum.GetRandomEvent()
                };
                even.EndDate = even.StartDate.AddHours(faker.Random.Int(1, 5));
                events.Add(even);
            }
            return events;
        }
    }
}
