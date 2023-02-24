using AppCore.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TechProccessAccounting.Core.Entities
{
    // Таблица "Сырье и материалы"
    public class Material:BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        [StringLength(20)]
        public string Unit { get; set; }
    }
}
