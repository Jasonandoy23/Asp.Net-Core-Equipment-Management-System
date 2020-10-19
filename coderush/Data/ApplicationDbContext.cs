using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using coderush.Models;

namespace coderush.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<coderush.Models.ApplicationUser> ApplicationUser { get; set; }

        public DbSet<coderush.Models.ACR_PumpOnGround> ACR_PumpOnGround { get; set; }
        public DbSet<coderush.Models.ACR_ShihlinCtrl> ACR_ShihlinCtrl { get; set; }        
        public DbSet<coderush.Models.ACR_SteamSterilizerMSTV> ACR_SteamSterilizerMSTV { get; set; }

        public DbSet<coderush.Models.BSLDNAExt_Centrifuge> BSLDNAExt_Centrifuge { get; set; }
        public DbSet<coderush.Models.BSLDNAExt_Centrifuge5424> BSLDNAExt_Centrifuge5424 { get; set; }
        public DbSet<coderush.Models.BSLDNAExt_DellDeskComp> BSLDNAExt_DellDeskComp { get; set; }
        public DbSet<coderush.Models.BSLDNAExt_FLUOstarOmega> BSLDNAExt_FLUOstarOmega { get; set; }
        public DbSet<coderush.Models.BSLDNAExt_HaierDW_40L508DeepFreezer> BSLDNAExt_HaierDW_40L508DeepFreezer { get; set; }
        public DbSet<coderush.Models.BSLDNAExt_HaierHYC> BSLDNAExt_HaierHYC { get; set; }
        public DbSet<coderush.Models.BSLDNAExt_HeatSealer> BSLDNAExt_HeatSealer { get; set; }
        public DbSet<coderush.Models.BSLDNAExt_KingFisherFlex> BSLDNAExt_KingFisherFlex { get; set; }
        public DbSet<coderush.Models.BSLDNAExt_LPVortexMixer> BSLDNAExt_LPVortexMixer { get; set; }
        public DbSet<coderush.Models.BSLDNAExt_MicroLabNIMBUS4> BSLDNAExt_MicroLabNIMBUS4 { get; set; }
        public DbSet<coderush.Models.BSLDNAExt_NanoDropOne> BSLDNAExt_NanoDropOne { get; set; }
        public DbSet<coderush.Models.BSLDNAExt_NanoPhotometer> BSLDNAExt_NanoPhotometer { get; set; }
        public DbSet<coderush.Models.BSLDNAExt_PerkinElmerChemagic360> BSLDNAExt_PerkinElmerChemagic360 { get; set; }
        public DbSet<coderush.Models.BSLDNAExt_PerkinElmerJanusG3> BSLDNAExt_PerkinElmerJanusG3 { get; set; }
        public DbSet<coderush.Models.BSLDNAExt_QIAsymphonySP> BSLDNAExt_QIAsymphonySP { get; set; }
        public DbSet<coderush.Models.BSLDNAExt_Qubit4Fluorometer> BSLDNAExt_Qubit4Fluorometer { get; set; }

        public DbSet<coderush.Models.BSLSamMgmt_BioSafetyCabinet> BSLSamMgmt_BioSafetyCabinet { get; set; }
        public DbSet<coderush.Models.BSLSamMgmt_BradyPrinteri5100> BSLSamMgmt_BradyPrinteri5100 { get; set; }
        public DbSet<coderush.Models.BSLSamMgmt_CenceCentrifugeCL5R> BSLSamMgmt_CenceCentrifugeCL5R { get; set; }
        public DbSet<coderush.Models.BSLSamMgmt_Centrifuge> BSLSamMgmt_Centrifuge { get; set; }
        public DbSet<coderush.Models.BSLSamMgmt_Centrifuge5702> BSLSamMgmt_Centrifuge5702 { get; set; }
        public DbSet<coderush.Models.BSLSamMgmt_DellDeskComp> BSLSamMgmt_DellDeskComp { get; set; }
        public DbSet<coderush.Models.BSLSamMgmt_ESCOClassIITypeA2> BSLSamMgmt_ESCOClassIITypeA2 { get; set; }
        public DbSet<coderush.Models.BSLSamMgmt_LPVortexMixer> BSLSamMgmt_LPVortexMixer { get; set; }
        public DbSet<coderush.Models.BSLSamMgmt_MicroLabSTARlet> BSLSamMgmt_MicroLabSTARlet { get; set; }
        public DbSet<coderush.Models.BSLSamMgmt_MultitubeVortexer> BSLSamMgmt_MultitubeVortexer { get; set; }
        public DbSet<coderush.Models.BSLSamMgmt_Refrigerator> BSLSamMgmt_Refrigerator { get; set; }
        public DbSet<coderush.Models.BSLSamMgmt_STPlusSeriesCentrifuge> BSLSamMgmt_STPlusSeriesCentrifuge { get; set; }
        public DbSet<coderush.Models.BSLSamMgmt_TheromoMixer> BSLSamMgmt_TheromoMixer { get; set; }

        public DbSet<coderush.Models.CP1_DellDeskComp> CP1_DellDeskComp { get; set; }
        public DbSet<coderush.Models.CP1_ThermoFisher80> CP1_ThermoFisher80 { get; set; }

        public DbSet<coderush.Models.ILLUMINALibConst_Others> ILLUMINALibConst_Others { get; set; }

        public DbSet<coderush.Models.ILLUMINASeqLab_NovaSeq6000> ILLUMINASeqLab_NovaSeq6000 { get; set; }
        public DbSet<coderush.Models.ILLUMINASeqLab_Others> ILLUMINASeqLab_Others { get; set; }

        public DbSet<coderush.Models.Lab1_DellDeskComp> Lab1_DellDeskComp { get; set; }
        public DbSet<coderush.Models.Lab1_Others> Lab1_Others { get; set; }
        public DbSet<coderush.Models.Lab2_DellDeskComp> Lab2_DellDeskComp { get; set; }
        public DbSet<coderush.Models.Lab2_Others> Lab2_Others { get; set; }
        public DbSet<coderush.Models.Lab3_DellDeskComp> Lab3_DellDeskComp { get; set; }
        public DbSet<coderush.Models.Lab3_Others> Lab3_Others { get; set; }
        public DbSet<coderush.Models.Lab4_DellDeskComp> Lab4_DellDeskComp { get; set; }
        public DbSet<coderush.Models.Lab4_Others> Lab4_Others { get; set; }

        public DbSet<coderush.Models.MGILibConstLab_TapeStation4200> MGILibConstLab_TapeStation4200 { get; set; }
        public DbSet<coderush.Models.MGILibConstLab_Centrifuge5810R> MGILibConstLab_Centrifuge5810R { get; set; }
        public DbSet<coderush.Models.MGILibConstLab_Fridge> MGILibConstLab_Fridge { get; set; }
        public DbSet<coderush.Models.MGILibConstLab_HaierHYC6102c8c> MGILibConstLab_HaierHYC6102c8c { get; set; }
        public DbSet<coderush.Models.MGILibConstLab_MGISP100> MGILibConstLab_MGISP100 { get; set; }
        public DbSet<coderush.Models.MGILibConstLab_MGISP960> MGILibConstLab_MGISP960 { get; set; }
        public DbSet<coderush.Models.MGILibConstLab_Others> MGILibConstLab_Others { get; set; }
        public DbSet<coderush.Models.MGILibConstLab_PureWaterSystem> MGILibConstLab_PureWaterSystem { get; set; }
        public DbSet<coderush.Models.MGILibConstLab_ThermalCycler> MGILibConstLab_ThermalCycler { get; set; }
        public DbSet<coderush.Models.MGILibConstLab_Vortexer> MGILibConstLab_Vortexer { get; set; }

        public DbSet<coderush.Models.MGISeqLab_Cabinet> MGISeqLab_Cabinet { get; set; }
        public DbSet<coderush.Models.MGISeqLab_Freezer> MGISeqLab_Freezer { get; set; }
        public DbSet<coderush.Models.MGISeqLab_G400> MGISeqLab_G400 { get; set; }
        public DbSet<coderush.Models.MGISeqLab_PlateCentrifuge> MGISeqLab_PlateCentrifuge { get; set; }
        public DbSet<coderush.Models.MGISeqLab_PureWaterSystem> MGISeqLab_PureWaterSystem { get; set; }
        public DbSet<coderush.Models.MGISeqLab_Refrigerator> MGISeqLab_Refrigerator { get; set; }
        public DbSet<coderush.Models.MGISeqLab_T10BiochemicalPlatformPart> MGISeqLab_T10BiochemicalPlatformPart { get; set; }
        public DbSet<coderush.Models.MGISeqLab_T10Loader> MGISeqLab_T10Loader { get; set; }
        public DbSet<coderush.Models.MGISeqLab_T10OpticalPlatformPart> MGISeqLab_T10OpticalPlatformPart { get; set; }
        public DbSet<coderush.Models.MGISeqLab_T7> MGISeqLab_T7 { get; set; }
        public DbSet<coderush.Models.MGISeqLab_T7Loader> MGISeqLab_T7Loader { get; set; }
        public DbSet<coderush.Models.MGISeqLab_Ztron> MGISeqLab_Ztron { get; set; }

        public DbSet<coderush.Models.ONTLibConstLab_MicroLabNGSSTAR> ONTLibConstLab_MicroLabNGSSTAR { get; set; }
        public DbSet<coderush.Models.ONTLibConstLab_DellDeskComp> ONTLibConstLab_DellDeskComp { get; set; }

        public DbSet<coderush.Models.ONTSeqLab_Centrifuge5424> ONTSeqLab_Centrifuge5424 { get; set; }
        public DbSet<coderush.Models.ONTSeqLab_Centrifuge5810R> ONTSeqLab_Centrifuge5810R { get; set; }
        public DbSet<coderush.Models.ONTSeqLab_DellDeskComp> ONTSeqLab_DellDeskComp { get; set; }
        public DbSet<coderush.Models.ONTSeqLab_HPLaserMFP137fnw> ONTSeqLab_HPLaserMFP137fnw { get; set; }
        public DbSet<coderush.Models.ONTSeqLab_IndDehumidifierClimatePlus> ONTSeqLab_IndDehumidifierClimatePlus { get; set; }
        public DbSet<coderush.Models.ONTSeqLab_PharmRef1> ONTSeqLab_PharmRef1 { get; set; }
        public DbSet<coderush.Models.ONTSeqLab_PharmRef2> ONTSeqLab_PharmRef2 { get; set; }
        public DbSet<coderush.Models.ONTSeqLab_PromethIONDataAcqTower> ONTSeqLab_PromethIONDataAcqTower { get; set; }
        public DbSet<coderush.Models.ONTSeqLab_PromethIONSeqUnit> ONTSeqLab_PromethIONSeqUnit { get; set; }
        public DbSet<coderush.Models.ONTSeqLab_ThermofisherSciFridge> ONTSeqLab_ThermofisherSciFridge { get; set; }

        public DbSet<coderush.Models.RDLab_BioSafetyCabinet> RDLab_BioSafetyCabinet { get; set; }
        public DbSet<coderush.Models.RDLab_Centrifuge5424R> RDLab_Centrifuge5424R { get; set; }
        public DbSet<coderush.Models.RDLab_CompactDrybathS> RDLab_CompactDrybathS { get; set; }
        public DbSet<coderush.Models.RDLab_DellDeskComp> RDLab_DellDeskComp { get; set; }
        public DbSet<coderush.Models.RDLab_ESCOClassIITypeA2BioSafetyCabinet> RDLab_ESCOClassIITypeA2BioSafetyCabinet { get; set; }
        public DbSet<coderush.Models.RDLab_FastPrep966010500> RDLab_FastPrep966010500 { get; set; }
        public DbSet<coderush.Models.RDLab_GelDocE7Imager> RDLab_GelDocE7Imager { get; set; }
        public DbSet<coderush.Models.RDLab_HaierDW40L508DeepFreezer40c20c> RDLab_HaierDW40L508DeepFreezer40c20c { get; set; }
        public DbSet<coderush.Models.RDLab_HaierHYC6102c8c> RDLab_HaierHYC6102c8c { get; set; }
        public DbSet<coderush.Models.RDLab_HeatStri> RDLab_HeatStri { get; set; }
        public DbSet<coderush.Models.RDLab_HulaMixer> RDLab_HulaMixer { get; set; }
        public DbSet<coderush.Models.RDLab_LPVortexMixer> RDLab_LPVortexMixer { get; set; }
        public DbSet<coderush.Models.RDLab_MasterCycler> RDLab_MasterCycler { get; set; }
        public DbSet<coderush.Models.RDLab_MettlerToledoNEWClassicMF> RDLab_MettlerToledoNEWClassicMF { get; set; }
        public DbSet<coderush.Models.RDLab_MicrowaveOven> RDLab_MicrowaveOven { get; set; }
        public DbSet<coderush.Models.RDLab_MiniSpin> RDLab_MiniSpin { get; set; }
        public DbSet<coderush.Models.RDLab_NanodropOne> RDLab_NanodropOne { get; set; }
        public DbSet<coderush.Models.RDLab_PowerPacBasic> RDLab_PowerPacBasic { get; set; }
        public DbSet<coderush.Models.RDLab_PrecisionGP10WaterBath> RDLab_PrecisionGP10WaterBath { get; set; }
        public DbSet<coderush.Models.RDLab_Qubit4Fluorometer> RDLab_Qubit4Fluorometer { get; set; }
        public DbSet<coderush.Models.RDLab_SWP01> RDLab_SWP01 { get; set; }
        public DbSet<coderush.Models.RDLab_ThermalCycler> RDLab_ThermalCycler { get; set; }
        public DbSet<coderush.Models.RDLab_ThermoScientificMyspin6> RDLab_ThermoScientificMyspin6 { get; set; }
        public DbSet<coderush.Models.RDLab_ThermoScientificMyspin12> RDLab_ThermoScientificMyspin12 { get; set; }

        public DbSet<coderush.Models.RoboticsLab_DellDeskComp> RoboticsLab_DellDeskComp { get; set; }
        public DbSet<coderush.Models.RoboticsLab_MicroLabNIMBUS> RoboticsLab_MicroLabNIMBUS { get; set; }
        public DbSet<coderush.Models.RoboticsLab_MicroLabSTAR> RoboticsLab_MicroLabSTAR { get; set; }
        public DbSet<coderush.Models.RoboticsLab_Others> RoboticsLab_Others { get; set; }

        public DbSet<coderush.Models.UserProfile> UserProfile { get; set; }

    }
}
