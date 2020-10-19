using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace coderush.Models
{
    public class ONTLibConstLab_MicroLabNGSSTAR
    {
        [Key]
        public int LogId { get; set; }
        public string LogDate { get; set; }
        public string LogTemperature { get; set; }
        public string LogStatus { get; set; }
        public string LogRemarks { get; set; }
    }
    public class ONTLibConstLab_DellDeskComp
    {
        [Key]
        public int LogId { get; set; }
        public string LogDate { get; set; }
        public string LogTemperature { get; set; }
        public string LogStatus { get; set; }
        public string LogRemarks { get; set; }
    }
}
