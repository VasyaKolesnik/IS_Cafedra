using ExampleProject.BLL.Request.Register;
using ExampleProject.DAL.Entities.Users;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExampleProject.App.Commands.Account
{
    public class RegisterCommand : RegisterRequest, IRequest
    {
    }
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand>
    {
        private readonly UserManager<Users> _userManager;
        private readonly SignInManager<Users> _signInManager;
        public RegisterCommandHandler(UserManager<Users> userManager, SignInManager<Users> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<Unit> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            Users user = new Users { Email = request.Email, UserName = request.Email};
            // добавляем пользователя
            var result = await _userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                // установка куки
                await _signInManager.SignInAsync(user, false);
            }
            return Unit.Value;
        }
    }
}
