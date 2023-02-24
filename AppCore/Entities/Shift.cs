using AppCore.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TechProccessAccounting.Core.Entities
{

    // Класс Смены
    public class Shift:BaseEntity
    {
        [ForeignKey("Employee")]
        public int EmployeeID { get; set; } // Внешний ключ
        [Required]
        public DateTime Date { get; set; } // Обязательное поле
        [Required]
        public DateTime StartTime { get; set; } // Обязательное поле
        [Required]
        public DateTime EndTime { get; set; } // Обязательное поле

        public Employee Employee { get; set; } // Навигационное свойство
    }


}
