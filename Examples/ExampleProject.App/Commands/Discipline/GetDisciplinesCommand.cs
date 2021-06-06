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
    public class GetDisciplinesCommand : IRequest<DisciplinesListRequest>
    {

    }

    public class GetDisciplinesCommandHandler : IRequestHandler<GetDisciplinesCommand, DisciplinesListRequest>
    {
        private readonly IService<Disciplines, DisciplineDTO> _disciplinesService;
        public GetDisciplinesCommandHandler(IService<Disciplines, DisciplineDTO> disciplinesService)
        {
            _disciplinesService = disciplinesService;
        }
        public async Task<DisciplinesListRequest> Handle(GetDisciplinesCommand request, CancellationToken cancellationToken)
        {
            return await Task.Run(() =>
            {
                var disciplineList = _disciplinesService.Select(_ => _.Id > 0).ToList();
                var disciplineRequest = new DisciplinesListRequest
                {
                    DisciplinesList = disciplineList
                };
                return disciplineRequest;
            }, cancellationToken);
        }
    }
}
