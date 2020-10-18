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





        public DbSet<coderush.Models.Condition> Condition { get; set; }

        public DbSet<coderush.Models.ConsumablesAndLabware> ConsumablesAndLabware { get; set; }

        public DbSet<coderush.Models.Currency> Currency { get; set; }

        public DbSet<coderush.Models.Instruments> Instruments { get; set; }

        public DbSet<coderush.Models.KitsAndReagents> KitsAndReagents { get; set; }

        public DbSet<coderush.Models.Location> Location { get; set; }

        public DbSet<coderush.Models.Status> Status { get; set; }

        public DbSet<coderush.Models.Sections> Sections { get; set; }

        public DbSet<coderush.Models.Storage> Storage { get; set; }

        public DbSet<coderush.Models.Suppliers> Suppliers { get; set; }

        public DbSet<coderush.Models.UnitOfMeasure> UnitOfMeasure { get; set; }

        public DbSet<coderush.Models.UserProfile> UserProfile { get; set; }

    }
}
