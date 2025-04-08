using System.Reflection;
using DataAccess.Context;
using DataAccess.Entities.Models.WebUsers;
using DataAccess.Repositories.Abstracts;
using DataAccess.Repositories.Concretes;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLogic.DependencyResolvers
{
    public static class DependencyResolvers
    {
        /// <summary>
        /// Bu servis ile DbContext nesnesini ara katmanda servis olarak kullanabilirsin.
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static IServiceCollection AddDbContext(this IServiceCollection collection)
        {
            collection.AddDbContext<GezTurizmContext>(options => options.UseSqlServer(Environment.GetEnvironmentVariable("Connection_String")));
            return collection;
        }
        /// <summary>
        /// DbContext nesnesinin Kimlik Servislerini kullanabilmesini sağlar
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static IServiceCollection AddIdentityServices(this IServiceCollection collection)
        {
            collection.AddIdentity<WebUserAccount, IdentityRole>().AddEntityFrameworkStores<GezTurizmContext>();
            return collection;
            //Benim WebUserAccount ve IdentityRole sınıflarımın verilerini GezTurizmContext üzerinden EF Core kullanarak veritabanında tut.
        }
        /// <summary>
        /// Generic Servis yapılarını Scoped olarak DI Container'e ekler
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static IServiceCollection AddScoped(this IServiceCollection collection)
        {
            collection.AddScoped(typeof(IActivityRepository<>), typeof(ActivityRepository<>));
            collection.AddScoped(typeof(ICompanyRepository<>), typeof(CompanyRepository<>));
            collection.AddScoped(typeof(IEmployeeRepository<>), typeof(EmployeeRepository<>));
            collection.AddScoped(typeof(IOrderDetailRepository<>), typeof(OrderDetailRepository<>));
            collection.AddScoped(typeof(IOrderRepository<>), typeof(OrderRepository<>));
            collection.AddScoped(typeof(IPassTicketRepository<>), typeof(PassTicketRepository<>));
            collection.AddScoped(typeof(ITicketRepository<>), typeof(TicketRepository<>));
            collection.AddScoped(typeof(IRegionRepository<>), typeof(RegionRepository<>));
            collection.AddScoped(typeof(IVehicleRepository<>), typeof(VehicleRepository<>));

            return collection;
        }
    }
}
