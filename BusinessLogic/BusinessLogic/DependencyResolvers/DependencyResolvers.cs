using BusinessLogic.Services.Abstracts.Activities;
using BusinessLogic.Services.Abstracts.ActivityS;
using BusinessLogic.Services.Abstracts.WebUsers;
using BusinessLogic.Services.Abstracts.WebUsers.Identity;
using BusinessLogic.Services.Abstracts.WebUserS;
using BusinessLogic.Services.Abstracts.WebUserS.Identity;
using BusinessLogic.Services.BaseGenericS;
using BusinessLogic.Services.CompanyS;
using DataAccess.Context;
using DataAccess.Entities.Models.WebUsers;
using DataAccess.Repositories;
using DataAccess.Repositories.ActivityR;
using DataAccess.Repositories.CompanyR;
using DataAccess.Repositories.EmployeeR;
using DataAccess.Repositories.OrderR;
using DataAccess.Repositories.RegionR;
using DataAccess.Repositories.TicketR;
using DataAccess.Repositories.VehicleR;
using DataAccess.Repositories.WebUserR;
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
            collection.AddScoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));
            collection.AddScoped<IActivityRepository, ActivityRepository>();
            collection.AddScoped<IWebUserAccountRepository, WebUserAccountRepository>();
            collection.AddScoped<IWebUserProfileRepository, WebUserProfileRepository>();
            collection.AddScoped(typeof(IGenericCompanyRepository<,>), typeof(GenericCompanyRepository<,>));
            collection.AddScoped<IPartnerCompanyRepository, PartnerCompanyRepository>();
            collection.AddScoped<ITransactionRepository, TransactionRepository>();
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
            collection.AddScoped<ITransactionService, TransactionService>();
            collection.AddScoped<IPartnerCompanyService, PartnerCompanyService>();
            collection.AddScoped<IActivityService, ActivityService>();
            collection.AddScoped<IWebUserProfileService, WebUserProfileService>();
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
