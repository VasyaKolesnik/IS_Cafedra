using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.BLL.DTO.Users
{
    public class UsersDTO
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string FIO { get; set; }
        public string Position { get; set; }
        public string Rank { get; set; }
        public int TotalExperience { get; set; }
        public int TeachingExperience { get; set; }
        public int ExperienceInThisEducationalInstitution { get; set; }
        public DateTime DateBorn { get; set; }
        public string MainPlaceOfWork { get; set; }
    }
}
