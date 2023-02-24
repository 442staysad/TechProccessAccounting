using AppCore.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TechProccessAccounting.Core.Entities
{
    // Класс для таблицы "Технологические операции"
    public class ProductionOperation:BaseEntity
    {

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public int Duration { get; set; }
    }
}
