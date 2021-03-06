using AutoMapper;
using ExampleProject.BLL.DTO;
using ExampleProject.BLL.DTO.Disciplines;
using ExampleProject.BLL.DTO.Users;
using ExampleProject.DAL.Entities;
using ExampleProject.DAL.Entities.Discipline;
using ExampleProject.DAL.Entities.Users;

namespace ExampleProject.BLL
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ExampleEntity, ExampleEntityDto>();
            CreateMap<ExampleEntityDto, ExampleEntity>();
            CreateMap<Users, UsersDTO>();
            CreateMap<UsersDTO, Users> ();
            CreateMap<Disciplines, DisciplineDTO>();
            CreateMap<DisciplineDTO, Disciplines>();
        }
    }
}