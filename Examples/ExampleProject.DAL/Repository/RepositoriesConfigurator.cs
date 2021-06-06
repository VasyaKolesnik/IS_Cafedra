using Core.DAL.Configuration;
using Core.DAL.Repository;
using ExampleProject.DAL.Entities;
using ExampleProject.DAL.Entities.Discipline;
using ExampleProject.DAL.Entities.Users;
using Microsoft.Extensions.DependencyInjection;

namespace ExampleProject.DAL.Repository
{
    public class RepositoriesConfigurator : IRepositoriesConfigurator
    {
        public void ConfigureRepositories(IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddSingleton<IRepository<ExampleEntity>, ExampleRepository>()
                .AddSingleton<IRepository<Users>, UsersRepository>()
                .AddSingleton<IRepository<Disciplines>, DisciplinesRepository>()
                ;
        }
    }
}