using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EquipmentManagement.Models
{
    public class Suppliers
    {
        [Key]
        public int Suppliers_id { get; set; }
        [Required]
        public string Suppliers_name { get; set; }
        public string Suppliers_description { get; set; }
    }
}
