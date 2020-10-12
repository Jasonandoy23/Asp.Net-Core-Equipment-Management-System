using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace coderush.Models
{
    public class Storage
    {
        [Key]
        public int Storage_id { get; set; }
        [Required]
        public string Storage_name { get; set; }
        public string Storage_description { get; set; }
    }
}
