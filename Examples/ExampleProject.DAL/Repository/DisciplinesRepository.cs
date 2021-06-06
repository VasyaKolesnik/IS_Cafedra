using Core.DAL.Repository;
using ExampleProject.DAL.EF;
using ExampleProject.DAL.Entities.Discipline;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.DAL.Repository
{
    public class DisciplinesRepository: AbstractRepository<Disciplines>
    {
        public DisciplinesRepository(IDbContextFactory<ApplicationDbContext> context) : base(context)
        { }
    }
}
