using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace coderush.Models
{
    public class Condition
    {
        [Key]
        public int Condition_id { get; set; }
        [Required]
        public string Condition_name { get; set; }
        public string Condition_description { get; set; }
    }
}
