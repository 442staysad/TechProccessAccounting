using AppCore.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TechProccessAccounting.Core.Entities
{
    // Класс для таблицы "Журнал производственных операций"
    public class ProductionOperationLog:BaseEntity
    {

        [ForeignKey("ProductDetail"), Column(Order = 0)]
        public int ProductDetailID { get; set; }

        [ForeignKey("ProductAssembly"), Column(Order = 1)]
        public int ProductAssemblyID { get; set; }

        [ForeignKey("ProductionOperation")]
        public int ProductionOperationID { get; set; }

        [ForeignKey("ProductionLine")]
        public int ProductionLineID { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        public decimal ProductQuantity { get; set; }

        public int ProductQuality { get; set; }

        public virtual ProductDetail ProductDetail { get; set; }

        public virtual ProductAssembly ProductAssembly { get; set; }

        public virtual ProductionOperation ProductionOperation { get; set; }

        public virtual ProductionLine ProductionLine { get; set; }
    }
}
