using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquipmentManagement.Pages
{
    public class Tabs
    {
        public static class ACR_PumpOnGround_PM
        {
            public const string PageName = "Preventive Maintenance";
            public const string Path = "/ACR_PumpOnGround_PM/PreventiveMaintenance";
            public const string ControllerName = "ACR_PumpOnGround_PM";
            public const string ActionName = "PreventiveMaintenance";
        }

        public static class ACR_PumpOnGround_SR
        {
            public const string PageName = "Service Report";
            public const string Path = "/ACR_PumpOnGround_SR/ServiceReport";
            public const string ControllerName = "ACR_PumpOnGround_SR";
            public const string ActionName = "ServiceReport";
        }

        public static class ACR_ShihlinCtrl_PM
        {
            public const string PageName = "Preventive Maintenance";
            public const string Path = "/ACR_ShihlinCtrl_PM/PreventiveMaintenance";
            public const string ControllerName = "ACR_ShihlinCtrl_PM";
            public const string ActionName = "PreventiveMaintenance";
        }

        public static class ACR_ShihlinCtrl_SR
        {
            public const string PageName = "Service Report";
            public const string Path = "/ACR_ShihlinCtrl_SR/ServiceReport";
            public const string ControllerName = "ACR_ShihlinCtrl_SR";
            public const string ActionName = "ServiceReport";
        }
    }
}
