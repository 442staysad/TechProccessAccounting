using AppCore.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TechProccessAccounting.Core.Entities
{

    // Класс Журнал производства продукции
    public class ProductionLog:BaseEntity
    {
        [ForeignKey("ProductAssembly")]
        public int ProductAssemblyID { get; set; } // Внешний ключ
        [Required]
        public int Quantity { get; set; } // Обязательное поле
        [Required]
        public DateTime Date { get; set; } // Обязательное поле

        [ForeignKey("Employee")]
        public int EmployeeID { get; set; } // Внешний ключ

        public ProductAssembly ProductAssembly { get; set; } // Навигационное свойство
        public Employee Employee { get; set; } // Навигационное свойство
    }
}
