﻿using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Activities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Activities
{
    internal class TourConfiguration:BaseActivityModelConfiguration<Tour>
    {
        public override void Configure(EntityTypeBuilder<Tour> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.TourCategory).IsRequired(true).HasConversion(x => x.ToString(), x => (TourCategory)Enum.Parse(typeof(TourCategory), x)).HasMaxLength(50);
            //Mapping
            //TourTicket
            builder.HasMany(x => x.TourTickets).WithOne(x => x.Tour).HasForeignKey(x => x.TourId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.ServiceRegion).WithMany(x => x.Tours).HasForeignKey(x => x.RegionId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
