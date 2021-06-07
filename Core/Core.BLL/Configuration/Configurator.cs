using Core.BLL.Extensions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Core.BLL.Configuration
{
    public static class Configurator
    {
        public static ServiceProvider ServiceProvider { get; set; }
        private static IServiceCollection ServiceCollection { get; set; }

        public static void Init(IServiceCollection serviceCollection)
        {
            ServiceCollection = serviceCollection;

            ConfigureDepencies(ServiceCollection);

            ServiceProvider = ServiceCollection.BuildServiceProvider();
        }

        private static void ConfigureDepencies(IServiceCollection serviceCollection)
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(_ => !_.IsDynamic).ToList();

            serviceCollection
                .AddRepositories(assemblies)
                .AddServices(assemblies)
                .AddDbContextFactories(assemblies)
                .AddAutoMapperConfigs(assemblies)
                .AddMediatR(assemblies.ToArray())
                .AddLogging()
                ;
        }
    }
}