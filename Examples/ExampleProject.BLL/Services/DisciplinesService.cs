using AutoMapper;
using Core.BLL.Services;
using Core.DAL.Repository;
using ExampleProject.BLL.DTO.Disciplines;
using ExampleProject.DAL.Entities.Discipline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.BLL.Services
{
    public class DisciplinesService : AbstractService<Disciplines, DisciplineDTO>
    {
        public DisciplinesService(IRepository<Disciplines> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
