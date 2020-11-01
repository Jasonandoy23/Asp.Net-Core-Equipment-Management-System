using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EquipmentManagement.Models
{
    public class KitsAndReagents
    {
        [Key]
        public int KR_id { get; set; }
        [Required]
        public int Location_id { get; set; }
        public int Suppliers_id { get; set; }
        public int Sections_id { get; set; }
        public string KR_partNo { get; set; }
        public string KR_description { get; set; }
        public decimal KR_qtyOnhand { get; set; }
        public int UnitOfMeasure_id { get; set; }
        public DateTimeOffset KR_expiryDate { get; set; }
        public double KR_averageCost { get; set; } = 0.0;
        public double KR_assetValue { get; set; } = 0.0;

    }
}
