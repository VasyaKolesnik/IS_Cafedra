using AutoMapper;
using ExampleProject.BLL.DTO;
using ExampleProject.BLL.DTO.Users;
using ExampleProject.DAL.Entities;
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
        }
    }
}