using BusinessLogic.Services.Abstracts;
using BusinessLogic.Services.Concretes;
using DataAccess.Context;
using DataAccess.Entities.Models.Activities;
using DataAccess.Entities.Models.WebUsers;
using DataAccess.Repositories.Abstracts;
using DataAccess.Repositories.Abstracts.Activity;
using DataAccess.Repositories.Abstracts.Company;
using DataAccess.Repositories.Abstracts.Employee;
using DataAccess.Repositories.Abstracts.Order;
using DataAccess.Repositories.Abstracts.OrderDetail;
using DataAccess.Repositories.Abstracts.PassTicket;
using DataAccess.Repositories.Abstracts.Region;
using DataAccess.Repositories.Abstracts.Ticket;
using DataAccess.Repositories.Abstracts.Vehicle;
using DataAccess.Repositories.Concretes;
using DataAccess.Repositories.Concretes.Activity;
using DataAccess.Repositories.Concretes.Company;
using DataAccess.Repositories.Concretes.Employee;
using DataAccess.Repositories.Concretes.Order;
using DataAccess.Repositories.Concretes.OrderDetail;
using DataAccess.Repositories.Concretes.PassTicket;
using DataAccess.Repositories.Concretes.Region;
using DataAccess.Repositories.Concretes.Ticket;
using DataAccess.Repositories.Concretes.Vehicle;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
            collection.AddIdentity<WebUserAccount, IdentityRole<int>>().AddEntityFrameworkStores<GezTurizmContext>();
            return collection;
            //Benim WebUserAccount ve IdentityRole sınıflarımın verilerini GezTurizmContext üzerinden EF Core kullanarak veritabanında tut.
        }
        /// <summary>
        /// Tüm Repository sınıflarını Scoped olarak DI Container'e ekler
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static IServiceCollection AddDALServices(this IServiceCollection collection)
        {
            collection.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            collection.AddScoped(typeof(IGenericActivityRepository<>), typeof(GenericActivityRepository<>));
            collection.AddScoped<ITourRepository, TourRepository>();
            collection.AddScoped<IEventRepository, EventRepository>();
            collection.AddScoped(typeof(IGenericCompanyRepository<>), typeof(GenericCompanyRepository<>));
            collection.AddScoped(typeof(IGenericEmployeeRepository<>), typeof(GenericEmployeeRepository<>));
            collection.AddScoped(typeof(IGenericOrderDetailRepository<>), typeof(GenericOrderDetailRepository<>));
            collection.AddScoped(typeof(IGenericOrderRepository<>), typeof(GenericOrderRepository<>));
            collection.AddScoped(typeof(IGenericPassTicketRepository<>), typeof(GenericPassTicketRepository<>));
            collection.AddScoped(typeof(IGenericTicketRepository<>), typeof(GenericTicketRepository<>));
            collection.AddScoped(typeof(IGenericRegionRepository<>), typeof(GenericRegionRepository<>));
            collection.AddScoped(typeof(IGenericVehicleRepository<>), typeof(GenericVehicleRepository<>));

            return collection;
        }
        /// <summary>
        /// Generic Service yapılarını Scoped olarak DI Container'e ekler
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static IServiceCollection AddBLLServices(this IServiceCollection collection)
        {
            collection.AddScoped(typeof(IService<,,>), typeof(Service<,,>));

            return collection;
        }
        /// <summary>
        /// Tüm mapper hizmetlerini eklemek için kullanın.
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static IServiceCollection AddMapperServices(this IServiceCollection collection)
        {            
            collection.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            return collection;
        }

    }
}
