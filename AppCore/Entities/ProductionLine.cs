using AppCore.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TechProccessAccounting.Core.Entities
{
    // Класс для таблицы "Производственные линии"
    public class ProductionLine:BaseEntity
    {

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
