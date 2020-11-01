using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EquipmentManagement.Models
{
    public class Sections
    {
        [Key]
        public int Sections_id { get; set; }
        [Required]
        public string Sections_name { get; set; }
        public string Sections_description { get; set; }
    }
}
