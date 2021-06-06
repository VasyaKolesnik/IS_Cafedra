using Core.BLL.Services;
using Core.DAL.Repository;
using ExampleProject.BLL.DTO.Users;
using ExampleProject.BLL.Request.Users;
using ExampleProject.DAL.Entities.Users;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExampleProject.App.Commands.User
{
    public class GetUsersCommand : IRequest<UsersListRequest>
    {

    }

    public class GetUsersCommandHandler : IRequestHandler<GetUsersCommand, UsersListRequest>
    {
        private readonly IService<Users, UsersDTO> _usersService;

        public GetUsersCommandHandler(IService<Users, UsersDTO> usersService)
        {
            _usersService = usersService;
        }

        public async Task<UsersListRequest> Handle(GetUsersCommand request, CancellationToken cancellationToken)
        {
            return await Task.Run(() =>
            {
                var userList = _usersService.Select(_ => _.Id > 0).ToList();
                var userRequest = new UsersListRequest
                {
                    UsersList = userList
                };
                return userRequest;
            }, cancellationToken);
        }
    }
}
