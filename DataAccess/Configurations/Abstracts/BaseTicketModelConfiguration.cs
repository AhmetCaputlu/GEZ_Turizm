using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Abstracts
{
    internal class BaseTicketModelConfiguration<T>:BaseModelConfiguration<T> where T : BaseTicketModel
    {
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.SeatNumber).IsRequired(true).HasMaxLength(4);//C34,B12 örneğin
            builder.Property(x => x.DepartureDate).IsRequired(true);
            builder.Property(x => x.ArrivalDate).IsRequired(true);
            builder.Property(x => x.DepartureAdress).HasMaxLength(150).IsRequired(true);
            builder.Property(x => x.TicketName).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.DestinationAdress).HasMaxLength(150).IsRequired(true);
            builder.Property(x => x.Price).IsRequired(true).HasColumnType("decimal(6,2)");
            builder.Property(x => x.DiscountRate).IsRequired(false);
            builder.Property(x => x.NetCost).IsRequired(false).HasColumnType("decimal(10,2)");
            builder.Property(x => x.Currency).IsRequired(true).HasConversion(x=>x.ToString(),x=>(Currency)Enum.Parse(typeof(Currency), x));
            builder.Property(x => x.PaymentStatus).IsRequired(true).HasConversion(x=>x.ToString(),x=>(PaymentStatus)Enum.Parse(typeof(Currency), x));
            
            //Mapping

        }
    }
}
