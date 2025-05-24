using BusinessLogic.Services.Abstracts;
using BusinessLogic.Services.Abstracts.WebUsers.Identity;
using BusinessLogic.Services.Concretes;
using BusinessLogic.Services.Concretes.WebUsers.Identity;
using DataAccess.Context;
using DataAccess.Entities.Models.WebUsers;
using DataAccess.Repositories.Abstracts;
using DataAccess.Repositories.Abstracts.Activity;
using DataAccess.Repositories.Abstracts.Company;
using DataAccess.Repositories.Abstracts.Employee;
using DataAccess.Repositories.Abstracts.EmployeeR;
using DataAccess.Repositories.Abstracts.Order;
using DataAccess.Repositories.Abstracts.OrderR;
using DataAccess.Repositories.Abstracts.Region;
using DataAccess.Repositories.Abstracts.RegionR;
using DataAccess.Repositories.Abstracts.Ticket;
using DataAccess.Repositories.Abstracts.TicketR;
using DataAccess.Repositories.Abstracts.Vehicle;
using DataAccess.Repositories.Abstracts.VehicleR;
using DataAccess.Repositories.Abstracts.WebUserR;
using DataAccess.Repositories.Concretes;
using DataAccess.Repositories.Concretes.Activity;
using DataAccess.Repositories.Concretes.Company;
using DataAccess.Repositories.Concretes.Employee;
using DataAccess.Repositories.Concretes.EmployeeR;
using DataAccess.Repositories.Concretes.Order;
using DataAccess.Repositories.Concretes.OrderR;
using DataAccess.Repositories.Concretes.Region;
using DataAccess.Repositories.Concretes.RegionR;
using DataAccess.Repositories.Concretes.Ticket;
using DataAccess.Repositories.Concretes.TicketR;
using DataAccess.Repositories.Concretes.Vehicle;
using DataAccess.Repositories.Concretes.VehicleR;
using DataAccess.Repositories.Concretes.WebUserR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

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
            collection.AddScoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));
            collection.AddScoped<IActivityRepository, ActivityRepository>();
            collection.AddScoped<IWebUserAccountRepository, WebUserAccountRepository>();
            collection.AddScoped<IWebUserProfileRepository, WebUserProfileRepository>();
            collection.AddScoped(typeof(IGenericCompanyRepository<,>), typeof(GenericCompanyRepository<,>));
            collection.AddScoped<IPartnerCompanyRepository, PartnerCompanyRepository>();
            collection.AddScoped<ICountryRepository, CountryRepository>();
            collection.AddScoped(typeof(IGenericEmployeeRepository<,>), typeof(GenericEmployeeRepository<,>));
            collection.AddScoped<IEmployeeRepository, EmployeeRepository>();
            collection.AddScoped<IContractEmployeeRepository, ContractEmployeeRepository>();
            collection.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            collection.AddScoped<IOrderRepository, OrderRepository>();
            collection.AddScoped<IPassTicketRepository, PassTicketRepository>();
            collection.AddScoped<ITicketRepository, TicketRepository>();
            collection.AddScoped<IRegionRepository, RegionRepository>();
            collection.AddScoped(typeof(IGenericVehicleRepository<,>), typeof(GenericVehicleRepository<,>));
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
            collection.AddScoped(typeof(IGenericService<,,,>), typeof(GenericService<,,,>));
            collection.AddScoped<IUserService, IdentityService>();
            collection.AddScoped<IRoleService, IdentityService>();
            collection.AddScoped<ISignInService, IdentityService>();
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
