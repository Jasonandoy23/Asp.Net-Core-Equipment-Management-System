using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EquipmentManagement.Models
{
    public class RoboticsLab_DellDeskComp
    {
        [Key]
        public int LogId { get; set; }
        public string LogDate { get; set; }
        public string LogTemperature { get; set; }
        public string LogStatus { get; set; }
        public string LogRemarks { get; set; }
    }
    public class RoboticsLab_MicroLabNIMBUS
    {
        [Key]
        public int LogId { get; set; }
        public string LogDate { get; set; }
        public string LogTemperature { get; set; }
        public string LogStatus { get; set; }
        public string LogRemarks { get; set; }
    }
    public class RoboticsLab_MicroLabSTAR
    {
        [Key]
        public int LogId { get; set; }
        public string LogDate { get; set; }
        public string LogTemperature { get; set; }
        public string LogStatus { get; set; }
        public string LogRemarks { get; set; }
    }
    public class RoboticsLab_Others
    {
        [Key]
        public int LogId { get; set; }
        public string LogDate { get; set; }
        public string LogTemperature { get; set; }
        public string LogStatus { get; set; }
        public string LogRemarks { get; set; }
    }
}
