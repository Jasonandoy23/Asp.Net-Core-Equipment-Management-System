using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace coderush.Models
{
    public class ONTSeqLab_Centrifuge5424
    {
        [Key]
        public int LogId { get; set; }
        public string LogDate { get; set; }
        public string LogTemperature { get; set; }
        public string LogStatus { get; set; }
        public string LogRemarks { get; set; }
    }
    public class ONTSeqLab_Centrifuge5810R : ONTSeqLab_Centrifuge5424
    { }
    public class ONTSeqLab_DellDeskComp : ONTSeqLab_Centrifuge5424
    { }
    public class ONTSeqLab_HPLaserMFP137fnw : ONTSeqLab_Centrifuge5424
    { }
    public class ONTSeqLab_IndDehumidifierClimatePlus : ONTSeqLab_Centrifuge5424
    { }
    public class ONTSeqLab_PharmRef1 : ONTSeqLab_Centrifuge5424
    { }
    public class ONTSeqLab_PharmRef2 : ONTSeqLab_Centrifuge5424
    { }
    public class ONTSeqLab_PromethIONDataAcqTower : ONTSeqLab_Centrifuge5424
    { }
    public class ONTSeqLab_PromethIONSeqUnit : ONTSeqLab_Centrifuge5424
    { }
    public class ONTSeqLab_ThermofisherSciFridge : ONTSeqLab_Centrifuge5424
    { }







}
