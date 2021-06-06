using ExampleProject.BLL.DTO.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.BLL.Request.Users
{
    public class UsersListRequest
    {
        public List<UsersDTO> UsersList { get; set; }
    }
}
