using ExampleProject.App.Commands.Discipline;
using ExampleProject.BLL.DTO.Disciplines;
using ExampleProject.BLL.Request.Discipline;
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
    public class DisciplineController : AbstractController
    {
        private readonly ILogger<DisciplineController> _logger;
        public DisciplineController(ILogger<DisciplineController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetDisciplines")]
        public async Task<DisciplinesListRequest> Get()
        {
            var entity = await Cmd.Send(new GetDisciplinesCommand());
            return entity;
        }

        [HttpPost("CreateDiscipline")]
        public async Task<DisciplineDTO> Create(CreateDisciplineCommand command)
        {
            var entity = await Cmd.Send(command);
            return entity;
        }
    }
}
