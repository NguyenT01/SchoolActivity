using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.Interface;
using Services;
using Services.Interface;

namespace SchoolActivity.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            string? MachineName = Environment.MachineName;
            string? ConnectionString = configuration.GetConnectionString("Default");
            ConnectionString = ConnectionString!.Replace("??????", MachineName);

            services.AddDbContext<RepositoryContext>(opts =>
                    opts.UseSqlServer(ConnectionString));
        }
        public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddTransient<IRepositoryManager, RepositoryManager>();
        }
        public static void ConfigureServicePresentation(this IServiceCollection services)
        {
            services.AddTransient<IClassroomService, ClassroomService>();
        }
    }
}
