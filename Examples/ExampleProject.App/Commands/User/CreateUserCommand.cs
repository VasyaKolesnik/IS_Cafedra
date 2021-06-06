using Core.BLL.Services;
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
    public class CreateUserCommand : UsersRequest, IRequest<UsersDTO>
    {
    }
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UsersDTO>
    {
        private readonly IService<Users, UsersDTO> _usersService;
        public CreateUserCommandHandler(IService<Users, UsersDTO> usersService)
        {
            _usersService = usersService;
        }
        public async Task<UsersDTO> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            return await Task.Run(() =>
            {
                var dto = new UsersDTO
                {
                    Name = request.Name,
                    LastName = request.LastName,
                    MiddleName = request.MiddleName,
                    FIO = request.Name + " " + request.LastName + " " + request.MiddleName,
                    DateBorn = request.DateBorn,
                    ExperienceInThisEducationalInstitution = request.ExperienceInThisEducationalInstitution,
                    MainPlaceOfWork = request.MainPlaceOfWork,
                    Position= request.Position,
                    Rank = request.Rank,
                    TeachingExperience = request.TeachingExperience,
                    TotalExperience = request.TotalExperience
                };
                _usersService.Create(dto);
                return dto;
            }, cancellationToken);
        }
    }
}
