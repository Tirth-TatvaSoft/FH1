using FH1Repository.Implementation;
using FH1Repository.Interface;
using FH1Service.Implementation;
using FH1Service.Interface;

namespace FhWebApi.Extentions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddProjectServices(this IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IAuthRepository, AuthRepository>();
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        return services;
    }
}
