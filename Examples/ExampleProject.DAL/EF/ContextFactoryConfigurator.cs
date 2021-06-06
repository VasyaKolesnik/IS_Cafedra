using Core.DAL.Configuration;
using ExampleProject.DAL.Entities.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace ExampleProject.DAL.EF
{
    public class ContextFactoryConfigurator : IContextFactoryConfigurator
    {
        public void ConfigureContextFactory(IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContextFactory<ApplicationDbContext, ExsampleContextFactory>()
                .AddIdentity<Users, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();
        }
    }
}