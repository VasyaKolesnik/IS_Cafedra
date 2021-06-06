using AutoMapper;
using Core.BLL.Services;
using Core.DAL.Repository;
using ExampleProject.BLL.DTO.Users;
using ExampleProject.DAL.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.BLL.Services
{
    public class UsersService : AbstractService<Users, UsersDTO>
    {
        public UsersService(IRepository<Users> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
