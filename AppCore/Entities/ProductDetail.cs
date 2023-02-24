using AppCore.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TechProccessAccounting.Core.Entities
{
    // Класс для таблицы "Детали продукта"
    public class ProductDetail:BaseEntity
    {

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
