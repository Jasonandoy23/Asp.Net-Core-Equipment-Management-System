using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EquipmentManagement.Models
{
    public class Location
    {
        [Key]
        public int Location_id { get; set; }
        [Required]
        public string Location_name { get; set; }
        public string Location_description { get; set; }
    }
}
