﻿using ExampleProject.App.Commands.Account;
using ExampleProject.BLL.Request.Register;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ExampleProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : AbstractController
    {
        [HttpPost("Register")]
        public async Task<Unit> Get(RegisterRequest request)
        {
            return await Cmd.Send(new RegisterCommand { Email = request.Email, Password = request.Password, PasswordConfirm = request.PasswordConfirm });
        }
    }
}
