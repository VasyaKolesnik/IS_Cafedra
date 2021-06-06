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
    public class UsersService : IService<Users, UsersDTO>
    {
        public UsersService(IRepository<Users> repository, IMapper mapper) 
        {
        }

        public IEnumerable<UsersDTO> Select(Func<Users, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<UsersDTO> Create(UsersDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<UsersDTO> Update(UsersDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
