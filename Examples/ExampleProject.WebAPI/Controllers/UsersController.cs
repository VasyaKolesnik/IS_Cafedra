using ExampleProject.App.Commands;
using ExampleProject.App.Commands.User;
using ExampleProject.BLL.DTO.Users;
using ExampleProject.BLL.Request.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleProject.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : AbstractController
    {
        private readonly ILogger<UsersController> _logger;
        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetUsers")]
        public async Task<UsersListRequest> Get()
        {
            var entity = await Cmd.Send(new GetUsersCommand());
            return entity;
        }

        [HttpPost("CreateUser")]
        public async Task<UsersDTO> Create(CreateUserCommand command)
        {
            var entity = await Cmd.Send(command);
            return entity;
        }
    }
}
