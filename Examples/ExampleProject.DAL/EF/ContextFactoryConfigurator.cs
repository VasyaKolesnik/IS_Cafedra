using Core.DAL.Configuration;
using ExampleProject.DAL.Entities.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ExampleProject.DAL.EF
{
    public class ContextFactoryConfigurator : IContextFactoryConfigurator
    {
        public void ConfigureContextFactory(IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddDbContextFactory<ApplicationDbContext, ExsampleContextFactory>()
                .AddDbContext<ApplicationDbContext>(options => options.UseNpgsql("Host=127.0.0.1;Port=5432;Database=kazakhstan;Username=kazakhstan;Password=vGAHb9BS0oUTBW8gdIqw"))
                .AddIdentity<Users, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();
        }
    }
}