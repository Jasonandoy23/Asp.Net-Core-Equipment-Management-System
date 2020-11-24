using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EquipmentManagement.Models
{
    public class AutoClaveRooms
    {
        [Key]
        public int LogId { get; set; }
        public string LogDate { get; set; }
        public string LogTemperature { get; set; }
        public string LogStatus { get; set; }
        public string LogRemarks { get; set; }
    }
    public class ACR_PumpOnGround : AutoClaveRooms
    { }
    public class ACR_ShihlinCtrl : AutoClaveRooms
    { }
    public class ACR_SteamSterilizerMSTV : AutoClaveRooms
    { }
    /// 
    /// ACR_PumpOnGround FILE HANDLING PREVENTIVE MAINTENANCE
    ///
    public abstract class ACR_PumpOnGround_FileModelPM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FileType { get; set; }
        public string Extension { get; set; }
        public string Description { get; set; }
        public string UploadedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
    public class ACR_PumpOnGround_FileOnDatabaseModelPM : ACR_PumpOnGround_FileModelPM
    {
        public byte[] Data { get; set; }
    }
    public class ACR_PumpOnGround_FileUploadViewModelPM
    {
        public List<ACR_PumpOnGround_FileOnDatabaseModelPM> ACR_PumpOnGround_FilesOnDatabasePM { get; set; }
    }
    /// 
    /// ACR_PumpOnGround FILE HANDLING SERVICE REPORT
    ///
    public abstract class ACR_PumpOnGround_FileModelSR
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FileType { get; set; }
        public string Extension { get; set; }
        public string Description { get; set; }
        public string UploadedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
    public class ACR_PumpOnGround_FileOnDatabaseModelSR : ACR_PumpOnGround_FileModelSR
    {
        public byte[] Data { get; set; }
    }
    public class ACR_PumpOnGround_FileUploadViewModelSR
    {
        public List<ACR_PumpOnGround_FileOnDatabaseModelSR> ACR_PumpOnGround_FilesOnDatabaseSR { get; set; }
    }
    /// 
    /// ACR_ShihlinCtrl FILE HANDLING PREVENTIVE MAINTENANCE
    /// 
    public abstract class ACR_ShihlinCtrl_FileModelPM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FileType { get; set; }
        public string Extension { get; set; }
        public string Description { get; set; }
        public string UploadedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
    public class ACR_ShihlinCtrl_FileOnDatabaseModelPM : ACR_ShihlinCtrl_FileModelPM
    {
        public byte[] Data { get; set; }
    }
    public class ACR_ShihlinCtrl_FileOnFileSystemModelPM : ACR_ShihlinCtrl_FileModelPM
    {
        public string FilePath { get; set; }
    }
    public class ACR_ShihlinCtrl_FileUploadViewModelPM
    {
        public List<ACR_ShihlinCtrl_FileOnFileSystemModelPM> ACR_ShihlinCtrl_FilesOnFileSystemPM { get; set; }

        public List<ACR_ShihlinCtrl_FileOnDatabaseModelPM> ACR_ShihlinCtrl_FilesOnDatabasePM { get; set; }
    }
    /// 
    /// ACR_ShihlinCtrl FILE HANDLING SERVICE REPORT
    /// 
    public abstract class ACR_ShihlinCtrl_FileModelSR
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FileType { get; set; }
        public string Extension { get; set; }
        public string Description { get; set; }
        public string UploadedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
    public class ACR_ShihlinCtrl_FileOnDatabaseModelSR : ACR_ShihlinCtrl_FileModelSR
    {
        public byte[] Data { get; set; }
    }
    public class ACR_ShihlinCtrl_FileUploadViewModelSR
    {
        public List<ACR_ShihlinCtrl_FileOnDatabaseModelSR> ACR_ShihlinCtrl_FilesOnDatabaseSR { get; set; }
    }
    /// 
    /// ACR_SteamSterilizerMSTV FILE HANDLING PREVENTIVE MAINTENANCE
    /// 
    public abstract class ACR_SteamSterilizerMSTV_FileModelPM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FileType { get; set; }
        public string Extension { get; set; }
        public string Description { get; set; }
        public string UploadedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
    public class ACR_SteamSterilizerMSTV_FileOnDatabaseModelPM : ACR_SteamSterilizerMSTV_FileModelPM
    {
        public byte[] Data { get; set; }
    }
    public class ACR_SteamSterilizerMSTV_FileOnFileSystemModelPM : ACR_SteamSterilizerMSTV_FileModelPM
    {
        public string FilePath { get; set; }
    }
    public class ACR_SteamSterilizerMSTV_FileUploadViewModelPM
    {
        public List<ACR_SteamSterilizerMSTV_FileOnFileSystemModelPM> ACR_SteamSterilizerMSTV_FilesOnFileSystemPM { get; set; }

        public List<ACR_SteamSterilizerMSTV_FileOnDatabaseModelPM> ACR_SteamSterilizerMSTV_FilesOnDatabasePM { get; set; }
    }
    /// 
    /// ACR_SteamSterilizerMSTV FILE HANDLING SERVICE REPORT
    /// 
    public abstract class ACR_SteamSterilizerMSTV_FileModelSR
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FileType { get; set; }
        public string Extension { get; set; }
        public string Description { get; set; }
        public string UploadedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
    public class ACR_SteamSterilizerMSTV_FileOnDatabaseModelSR : ACR_SteamSterilizerMSTV_FileModelSR
    {
        public byte[] Data { get; set; }
    }
    public class ACR_SteamSterilizerMSTV_FileUploadViewModelSR
    {
        public List<ACR_SteamSterilizerMSTV_FileOnDatabaseModelSR> ACR_SteamSterilizerMSTV_FilesOnDatabaseSR { get; set; }
    }
}
