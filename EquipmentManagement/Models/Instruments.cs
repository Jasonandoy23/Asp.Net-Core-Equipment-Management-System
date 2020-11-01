using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EquipmentManagement.Models
{
    public class Instruments
    {
        [Key]
        public int Instru_id { get; set; }
        [Required]
        public int Location_id { get; set; }
        public int Suppliers_id { get; set; }
        public int Sections_id { get; set; }
        public string Instru_partNo { get; set; }
        public string Instru_description { get; set; }
        public decimal Instru_qtyOnhand { get; set; }
        public int UnitOfMeasure_id { get; set; }
        public decimal Instru_serialNo { get; set; }
        public DateTimeOffset Instru_warrStartdate { get; set; }
        public DateTimeOffset Instru_warrEnddate { get; set; }
        public double Instru_averageCost { get; set; } = 0.0;
        public double Instru_assetValue { get; set; } = 0.0;
    }
}
