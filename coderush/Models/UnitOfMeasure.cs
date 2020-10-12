using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace coderush.Models
{
    public class UnitOfMeasure
    {       
        [Key]
        public int UnitOfMeasure_id { get; set; }
        public string UnitOfMeasure_name { get; set; }
        public string UnitOfMeasure_description { get; set; }
    }
}
