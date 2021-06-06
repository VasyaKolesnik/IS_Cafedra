using ExampleProject.BLL.DTO.Disciplines;
using ExampleProject.DAL.Entities.Discipline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.BLL.Request.Discipline
{
    public class DisciplinesListRequest
    {
        public List<DisciplineDTO> DisciplinesList { get; set; }
    }
}
