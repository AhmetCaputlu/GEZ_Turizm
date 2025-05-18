using BusinessLogic.Services.Abstracts;
using BusinessLogic.Services.Abstracts.WebUsers.Identity;
using BusinessLogic.Services.Concretes;
using BusinessLogic.Services.Concretes.Identity;
using DataAccess.Context;
using DataAccess.Entities.Models.WebUsers;
using DataAccess.Repositories.Abstracts;
using DataAccess.Repositories.Abstracts.Activity;
using DataAccess.Repositories.Abstracts.Company;
using DataAccess.Repositories.Abstracts.Countryy;
using DataAccess.Repositories.Abstracts.Employee;
using DataAccess.Repositories.Abstracts.EmployeeR;
using DataAccess.Repositories.Abstracts.Order;
using DataAccess.Repositories.Abstracts.OrderDetail;
using DataAccess.Repositories.Abstracts.PassTicket;
using DataAccess.Repositories.Abstracts.Region;
using DataAccess.Repositories.Abstracts.Ticket;
using DataAccess.Repositories.Abstracts.Vehicle;
using DataAccess.Repositories.Abstracts.VehicleR;
using DataAccess.Repositories.Concretes;
using DataAccess.Repositories.Concretes.Activity;
using DataAccess.Repositories.Concretes.Company;
using DataAccess.Repositories.Concretes.Countryy;
using DataAccess.Repositories.Concretes.Employee;
using DataAccess.Repositories.Concretes.EmployeeR;
using DataAccess.Repositories.Concretes.Order;
using DataAccess.Repositories.Concretes.OrderDetail;
using DataAccess.Repositories.Concretes.PassTicket;
using DataAccess.Repositories.Concretes.Region;
using DataAccess.Repositories.Concretes.Ticket;
using DataAccess.Repositories.Concretes.Vehicle;
using DataAccess.Repositories.Concretes.VehicleR;
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
            collection.AddDbContext<GezTurizmContext>(options => options
            .UseLazyLoadingProxies()
            //.EnableSensitiveDataLogging()
            .UseSqlServer(Environment.GetEnvironmentVariable("Connection_String")));
            return collection;
        }
        /// <summary>
        /// DbContext nesnesinin Kimlik Servislerini kullanabilmesini sağlar
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static IServiceCollection AddIdentityServices(this IServiceCollection collection)
        {
            collection.AddIdentity<WebUserAccount, IdentityRole<int>>(x =>
            {
                //SignIn 
                x.SignIn.RequireConfirmedEmail = false;
                x.SignIn.RequireConfirmedPhoneNumber = false;
                //Password
                x.Password.RequireDigit = true;
                x.Password.RequireLowercase = true;
                x.Password.RequireUppercase = true;
                x.Password.RequireNonAlphanumeric = true;
                x.Password.RequiredLength = 8;           
                x.Password.RequiredUniqueChars = 2;
                //Email
                x.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<GezTurizmContext>()
            .AddRoleManager<RoleManager<IdentityRole<int>>>(); ;
            return collection;
        }
        /// <summary>
        /// Tüm Repository sınıflarını Scoped olarak DI Container'e ekler
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static IServiceCollection AddDALServices(this IServiceCollection collection)
        {
            collection.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            collection.AddScoped<IGenericActivityRepository, GenericActivityRepository>();
            collection.AddScoped(typeof(IGenericCompanyRepository<>), typeof(GenericCompanyRepository<>));
            collection.AddScoped<IPartnerCompanyRepository, PartnerCompanyRepository>();
            collection.AddScoped<ICountryRepository, CountryRepository>();
            collection.AddScoped(typeof(IGenericEmployeeRepository<>), typeof(GenericEmployeeRepository<>));
            collection.AddScoped<IEmployeeRepository, EmployeeRepository>();
            collection.AddScoped<IContractEmployeeRepository, ContractEmployeeRepository>();
            collection.AddScoped<IGenericOrderDetailRepository, GenericOrderDetailRepository>();
            collection.AddScoped<IGenericOrderRepository, GenericOrderRepository>();
            collection.AddScoped<IGenericPassTicketRepository, GenericPassTicketRepository>();
            collection.AddScoped<IGenericTicketRepository, GenericTicketRepository>();
            collection.AddScoped<IGenericRegionRepository, GenericRegionRepository>();
            collection.AddScoped(typeof(IGenericVehicleRepository<>), typeof(GenericVehicleRepository<>));
            collection.AddScoped<IVehicleRepository, VehicleRepository>();
            collection.AddScoped<IRentalVehicleRepository, RentalVehicleRepository>();

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
            collection.AddScoped<IUserService, IdentityService>();
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
