using Core.BLL.Configuration;
using Core.BLL.Services;
using ExampleProject.BLL.DTO;
using ExampleProject.BLL.DTO.Disciplines;
using ExampleProject.BLL.DTO.Users;
using ExampleProject.DAL.Entities;
using ExampleProject.DAL.Entities.Discipline;
using ExampleProject.DAL.Entities.Users;
using Microsoft.Extensions.DependencyInjection;

namespace ExampleProject.BLL.Services
{
    public class ServicesConfigurator : IServicesConfigurator
    {
        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddSingleton<IService<ExampleEntity, ExampleEntityDto>, ExampleService>()
                .AddSingleton<IService<Users, UsersDTO>, UsersService>()
                .AddSingleton<IService<Disciplines, DisciplineDTO>, DisciplinesService>()
                ;
        }
    }
}