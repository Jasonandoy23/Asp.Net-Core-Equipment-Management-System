using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EquipmentManagement.Models
{
    public class ConsumablesAndLabware
    {
        [Key]
        public int CL_id { get; set; }
        [Required]
        public string CL_name { get; set; }
        public int Location_id { get; set; }
        public int Storage_id { get; set; }
        public string CL_layerCompartment { get; set; }
        public string CL_storageTemp { get; set; }
        public int Condition_id { get; set; }
        public DateTimeOffset CL_expiryDate { get; set; }
        public string CL_partNo { get; set; }
        public int Status_id { get; set; }
        public DateTimeOffset CL_statusDate { get; set; }
        public decimal CL_qtyOnhand { get; set; }
        public int UnitOfMeasure_id { get; set; }

    }
}
