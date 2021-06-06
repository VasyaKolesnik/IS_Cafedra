using Core.BLL.Services;
using ExampleProject.BLL.DTO.Disciplines;
using ExampleProject.BLL.Request.Discipline;
using ExampleProject.DAL.Entities.Discipline;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExampleProject.App.Commands.Discipline
{
    public class CreateDisciplineCommand : DisciplinesRequest, IRequest<DisciplineDTO>
    {
    }
    public class CreateDisciplineCommandHandler : IRequestHandler<CreateDisciplineCommand, DisciplineDTO>
    {
        private readonly IService<Disciplines, DisciplineDTO> _disciplinesService;
        public CreateDisciplineCommandHandler(IService<Disciplines, DisciplineDTO> disciplinesService)
        {
            _disciplinesService = disciplinesService;
        }
        public async Task<DisciplineDTO> Handle(CreateDisciplineCommand request, CancellationToken cancellationToken)
        {
            return await Task.Run(() =>
            {
                var dto = new DisciplineDTO
                {
                    Name = request.Name,                    
                };
                _disciplinesService.Create(dto);
                return dto;
            }, cancellationToken);
        }
    }
}
