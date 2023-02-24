using AppCore.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TechProccessAccounting.Core.Entities
{
    // Класс для таблицы "Сотрудники"
    public class Employee:BaseEntity
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        public string Position { get; set; }
    }
}
