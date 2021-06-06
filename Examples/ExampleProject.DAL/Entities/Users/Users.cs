using Core.DAL.Entities;
using ExampleProject.DAL.Entities.Discipline;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExampleProject.DAL.Entities.Users
{
    public class Users : AbstractEntity
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string MiddleName { get; set; }
        /// <summary>
        /// ФИО
        /// </summary>
        public string FIO { get; set; }
        /// <summary>
        /// Должность
        /// </summary>
        public string Position { get; set; }
        /// <summary>
        /// Звание
        /// </summary>
        public string Rank { get; set; }
        /// <summary>
        /// Общий стаж
        /// </summary>
        public int TotalExperience { get; set; }
        /// <summary>
        /// Педагогический стаж
        /// </summary>
        public int TeachingExperience { get; set; }
        /// <summary>
        /// Стаж в данном учебном заведении
        /// </summary>
        public int ExperienceInThisEducationalInstitution { get; set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateBorn { get; set; }
        /// <summary>
        /// Основное место работы
        /// </summary>
        public string MainPlaceOfWork { get; set; }
    }
}
