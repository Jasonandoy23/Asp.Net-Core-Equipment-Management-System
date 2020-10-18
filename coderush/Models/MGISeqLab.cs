using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace coderush.Models
{
    public class MGISeqLab_Cabinet
    {
        [Key]
        public int LogId { get; set; }
        public string LogDate { get; set; }
        public string LogTemperature { get; set; }
        public string LogStatus { get; set; }
        public string LogRemarks { get; set; }
    }
    public class MGISeqLab_Freezer
    {
        [Key]
        public int LogId { get; set; }
        public string LogDate { get; set; }
        public string LogTemperature { get; set; }
        public string LogStatus { get; set; }
        public string LogRemarks { get; set; }
    }
    public class MGISeqLab_G400
    {
        [Key]
        public int LogId { get; set; }
        public string LogDate { get; set; }
        public string LogTemperature { get; set; }
        public string LogStatus { get; set; }
        public string LogRemarks { get; set; }
    }
    public class MGISeqLab_PlateCentrifuge
    {
        [Key]
        public int LogId { get; set; }
        public string LogDate { get; set; }
        public string LogTemperature { get; set; }
        public string LogStatus { get; set; }
        public string LogRemarks { get; set; }
    }
    public class MGISeqLab_PureWaterSystem
    {
        [Key]
        public int LogId { get; set; }
        public string LogDate { get; set; }
        public string LogTemperature { get; set; }
        public string LogStatus { get; set; }
        public string LogRemarks { get; set; }
    }
    public class MGISeqLab_Refrigerator
    {
        [Key]
        public int LogId { get; set; }
        public string LogDate { get; set; }
        public string LogTemperature { get; set; }
        public string LogStatus { get; set; }
        public string LogRemarks { get; set; }
    }
    public class MGISeqLab_T10BiochemicalPlatformPart
    {
        [Key]
        public int LogId { get; set; }
        public string LogDate { get; set; }
        public string LogTemperature { get; set; }
        public string LogStatus { get; set; }
        public string LogRemarks { get; set; }
    }
    public class MGISeqLab_T10Loader
    {
        [Key]
        public int LogId { get; set; }
        public string LogDate { get; set; }
        public string LogTemperature { get; set; }
        public string LogStatus { get; set; }
        public string LogRemarks { get; set; }
    }
    public class MGISeqLab_T10OpticalPlatformPart
    {
        [Key]
        public int LogId { get; set; }
        public string LogDate { get; set; }
        public string LogTemperature { get; set; }
        public string LogStatus { get; set; }
        public string LogRemarks { get; set; }
    }
    public class MGISeqLab_T7
    {
        [Key]
        public int LogId { get; set; }
        public string LogDate { get; set; }
        public string LogTemperature { get; set; }
        public string LogStatus { get; set; }
        public string LogRemarks { get; set; }
    }
    public class MGISeqLab_T7Loader
    {
        [Key]
        public int LogId { get; set; }
        public string LogDate { get; set; }
        public string LogTemperature { get; set; }
        public string LogStatus { get; set; }
        public string LogRemarks { get; set; }
    }
    public class MGISeqLab_Ztron
    {
        [Key]
        public int LogId { get; set; }
        public string LogDate { get; set; }
        public string LogTemperature { get; set; }
        public string LogStatus { get; set; }
        public string LogRemarks { get; set; }
    }
}
