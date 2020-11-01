using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EquipmentManagement.Models
{
    public class Status
    {
        [Key]
        public int Status_id { get; set; }
        [Required]
        public string Status_name { get; set; }
        public string Status_description { get; set; }
    }
}
