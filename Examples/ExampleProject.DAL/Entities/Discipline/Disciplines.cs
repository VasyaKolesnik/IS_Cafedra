using Core.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.DAL.Entities.Discipline
{
    public class Disciplines : AbstractEntity
    {
        /// <summary>
        /// Название дисциплины
        /// </summary>
        public string Name { get; set; }
    }
}
