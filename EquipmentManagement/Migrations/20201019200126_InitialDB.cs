using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EquipmentManagement.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ACR_PumpOnGround",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACR_PumpOnGround", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "ACR_ShihlinCtrl",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACR_ShihlinCtrl", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "ACR_SteamSterilizerMSTV",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACR_SteamSterilizerMSTV", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BSLDNAExt_Centrifuge",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSLDNAExt_Centrifuge", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "BSLDNAExt_Centrifuge5424",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSLDNAExt_Centrifuge5424", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "BSLDNAExt_DellDeskComp",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSLDNAExt_DellDeskComp", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "BSLDNAExt_FLUOstarOmega",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSLDNAExt_FLUOstarOmega", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "BSLDNAExt_HaierDW_40L508DeepFreezer",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSLDNAExt_HaierDW_40L508DeepFreezer", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "BSLDNAExt_HaierHYC",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSLDNAExt_HaierHYC", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "BSLDNAExt_HeatSealer",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSLDNAExt_HeatSealer", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "BSLDNAExt_KingFisherFlex",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSLDNAExt_KingFisherFlex", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "BSLDNAExt_LPVortexMixer",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSLDNAExt_LPVortexMixer", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "BSLDNAExt_MicroLabNIMBUS4",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSLDNAExt_MicroLabNIMBUS4", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "BSLDNAExt_NanoDropOne",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSLDNAExt_NanoDropOne", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "BSLDNAExt_NanoPhotometer",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSLDNAExt_NanoPhotometer", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "BSLDNAExt_PerkinElmerChemagic360",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSLDNAExt_PerkinElmerChemagic360", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "BSLDNAExt_PerkinElmerJanusG3",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSLDNAExt_PerkinElmerJanusG3", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "BSLDNAExt_QIAsymphonySP",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSLDNAExt_QIAsymphonySP", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "BSLDNAExt_Qubit4Fluorometer",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSLDNAExt_Qubit4Fluorometer", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "BSLSamMgmt_BioSafetyCabinet",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSLSamMgmt_BioSafetyCabinet", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "BSLSamMgmt_BradyPrinteri5100",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSLSamMgmt_BradyPrinteri5100", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "BSLSamMgmt_CenceCentrifugeCL5R",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSLSamMgmt_CenceCentrifugeCL5R", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "BSLSamMgmt_Centrifuge",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSLSamMgmt_Centrifuge", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "BSLSamMgmt_Centrifuge5702",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSLSamMgmt_Centrifuge5702", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "BSLSamMgmt_DellDeskComp",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSLSamMgmt_DellDeskComp", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "BSLSamMgmt_ESCOClassIITypeA2",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSLSamMgmt_ESCOClassIITypeA2", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "BSLSamMgmt_LPVortexMixer",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSLSamMgmt_LPVortexMixer", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "BSLSamMgmt_MicroLabSTARlet",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSLSamMgmt_MicroLabSTARlet", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "BSLSamMgmt_MultitubeVortexer",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSLSamMgmt_MultitubeVortexer", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "BSLSamMgmt_Refrigerator",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSLSamMgmt_Refrigerator", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "BSLSamMgmt_STPlusSeriesCentrifuge",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSLSamMgmt_STPlusSeriesCentrifuge", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "BSLSamMgmt_TheromoMixer",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSLSamMgmt_TheromoMixer", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "CP1_DellDeskComp",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CP1_DellDeskComp", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "CP1_ThermoFisher80",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CP1_ThermoFisher80", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "ILLUMINALibConst_Others",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ILLUMINALibConst_Others", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "ILLUMINASeqLab_NovaSeq6000",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ILLUMINASeqLab_NovaSeq6000", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "ILLUMINASeqLab_Others",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ILLUMINASeqLab_Others", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "Lab1_DellDeskComp",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lab1_DellDeskComp", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "Lab1_Others",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lab1_Others", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "Lab2_DellDeskComp",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lab2_DellDeskComp", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "Lab2_Others",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lab2_Others", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "Lab3_DellDeskComp",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lab3_DellDeskComp", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "Lab3_Others",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lab3_Others", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "Lab4_DellDeskComp",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lab4_DellDeskComp", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "Lab4_Others",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lab4_Others", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "MGILibConstLab_Centrifuge5810R",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MGILibConstLab_Centrifuge5810R", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "MGILibConstLab_Fridge",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MGILibConstLab_Fridge", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "MGILibConstLab_HaierHYC6102c8c",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MGILibConstLab_HaierHYC6102c8c", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "MGILibConstLab_MGISP100",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MGILibConstLab_MGISP100", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "MGILibConstLab_MGISP960",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MGILibConstLab_MGISP960", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "MGILibConstLab_Others",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MGILibConstLab_Others", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "MGILibConstLab_PureWaterSystem",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MGILibConstLab_PureWaterSystem", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "MGILibConstLab_TapeStation4200",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MGILibConstLab_TapeStation4200", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "MGILibConstLab_ThermalCycler",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MGILibConstLab_ThermalCycler", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "MGILibConstLab_Vortexer",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MGILibConstLab_Vortexer", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "MGISeqLab_Cabinet",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MGISeqLab_Cabinet", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "MGISeqLab_Freezer",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MGISeqLab_Freezer", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "MGISeqLab_G400",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MGISeqLab_G400", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "MGISeqLab_PlateCentrifuge",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MGISeqLab_PlateCentrifuge", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "MGISeqLab_PureWaterSystem",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MGISeqLab_PureWaterSystem", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "MGISeqLab_Refrigerator",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MGISeqLab_Refrigerator", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "MGISeqLab_T10BiochemicalPlatformPart",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MGISeqLab_T10BiochemicalPlatformPart", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "MGISeqLab_T10Loader",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MGISeqLab_T10Loader", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "MGISeqLab_T10OpticalPlatformPart",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MGISeqLab_T10OpticalPlatformPart", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "MGISeqLab_T7",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MGISeqLab_T7", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "MGISeqLab_T7Loader",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MGISeqLab_T7Loader", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "MGISeqLab_Ztron",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MGISeqLab_Ztron", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "ONTLibConstLab_DellDeskComp",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ONTLibConstLab_DellDeskComp", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "ONTLibConstLab_MicroLabNGSSTAR",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ONTLibConstLab_MicroLabNGSSTAR", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "ONTSeqLab_Centrifuge5424",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ONTSeqLab_Centrifuge5424", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "ONTSeqLab_Centrifuge5810R",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ONTSeqLab_Centrifuge5810R", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "ONTSeqLab_DellDeskComp",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ONTSeqLab_DellDeskComp", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "ONTSeqLab_HPLaserMFP137fnw",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ONTSeqLab_HPLaserMFP137fnw", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "ONTSeqLab_IndDehumidifierClimatePlus",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ONTSeqLab_IndDehumidifierClimatePlus", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "ONTSeqLab_PharmRef1",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ONTSeqLab_PharmRef1", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "ONTSeqLab_PharmRef2",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ONTSeqLab_PharmRef2", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "ONTSeqLab_PromethIONDataAcqTower",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ONTSeqLab_PromethIONDataAcqTower", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "ONTSeqLab_PromethIONSeqUnit",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ONTSeqLab_PromethIONSeqUnit", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "ONTSeqLab_ThermofisherSciFridge",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ONTSeqLab_ThermofisherSciFridge", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "RDLab_BioSafetyCabinet",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RDLab_BioSafetyCabinet", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "RDLab_Centrifuge5424R",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RDLab_Centrifuge5424R", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "RDLab_CompactDrybathS",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RDLab_CompactDrybathS", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "RDLab_DellDeskComp",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RDLab_DellDeskComp", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "RDLab_ESCOClassIITypeA2BioSafetyCabinet",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RDLab_ESCOClassIITypeA2BioSafetyCabinet", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "RDLab_FastPrep966010500",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RDLab_FastPrep966010500", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "RDLab_GelDocE7Imager",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RDLab_GelDocE7Imager", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "RDLab_HaierDW40L508DeepFreezer40c20c",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RDLab_HaierDW40L508DeepFreezer40c20c", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "RDLab_HaierHYC6102c8c",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RDLab_HaierHYC6102c8c", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "RDLab_HeatStri",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RDLab_HeatStri", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "RDLab_HulaMixer",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RDLab_HulaMixer", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "RDLab_LPVortexMixer",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RDLab_LPVortexMixer", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "RDLab_MasterCycler",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RDLab_MasterCycler", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "RDLab_MettlerToledoNEWClassicMF",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RDLab_MettlerToledoNEWClassicMF", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "RDLab_MicrowaveOven",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RDLab_MicrowaveOven", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "RDLab_MiniSpin",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RDLab_MiniSpin", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "RDLab_NanodropOne",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RDLab_NanodropOne", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "RDLab_PowerPacBasic",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RDLab_PowerPacBasic", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "RDLab_PrecisionGP10WaterBath",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RDLab_PrecisionGP10WaterBath", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "RDLab_Qubit4Fluorometer",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RDLab_Qubit4Fluorometer", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "RDLab_SWP01",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RDLab_SWP01", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "RDLab_ThermalCycler",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RDLab_ThermalCycler", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "RDLab_ThermoScientificMyspin12",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RDLab_ThermoScientificMyspin12", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "RDLab_ThermoScientificMyspin6",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RDLab_ThermoScientificMyspin6", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "RoboticsLab_DellDeskComp",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoboticsLab_DellDeskComp", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "RoboticsLab_MicroLabNIMBUS",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoboticsLab_MicroLabNIMBUS", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "RoboticsLab_MicroLabSTAR",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoboticsLab_MicroLabSTAR", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "RoboticsLab_Others",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoboticsLab_Others", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "UserProfile",
                columns: table => new
                {
                    UserProfileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    ConfirmPassword = table.Column<string>(nullable: true),
                    OldPassword = table.Column<string>(nullable: true),
                    ProfilePicture = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfile", x => x.UserProfileId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ACR_PumpOnGround");

            migrationBuilder.DropTable(
                name: "ACR_ShihlinCtrl");

            migrationBuilder.DropTable(
                name: "ACR_SteamSterilizerMSTV");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BSLDNAExt_Centrifuge");

            migrationBuilder.DropTable(
                name: "BSLDNAExt_Centrifuge5424");

            migrationBuilder.DropTable(
                name: "BSLDNAExt_DellDeskComp");

            migrationBuilder.DropTable(
                name: "BSLDNAExt_FLUOstarOmega");

            migrationBuilder.DropTable(
                name: "BSLDNAExt_HaierDW_40L508DeepFreezer");

            migrationBuilder.DropTable(
                name: "BSLDNAExt_HaierHYC");

            migrationBuilder.DropTable(
                name: "BSLDNAExt_HeatSealer");

            migrationBuilder.DropTable(
                name: "BSLDNAExt_KingFisherFlex");

            migrationBuilder.DropTable(
                name: "BSLDNAExt_LPVortexMixer");

            migrationBuilder.DropTable(
                name: "BSLDNAExt_MicroLabNIMBUS4");

            migrationBuilder.DropTable(
                name: "BSLDNAExt_NanoDropOne");

            migrationBuilder.DropTable(
                name: "BSLDNAExt_NanoPhotometer");

            migrationBuilder.DropTable(
                name: "BSLDNAExt_PerkinElmerChemagic360");

            migrationBuilder.DropTable(
                name: "BSLDNAExt_PerkinElmerJanusG3");

            migrationBuilder.DropTable(
                name: "BSLDNAExt_QIAsymphonySP");

            migrationBuilder.DropTable(
                name: "BSLDNAExt_Qubit4Fluorometer");

            migrationBuilder.DropTable(
                name: "BSLSamMgmt_BioSafetyCabinet");

            migrationBuilder.DropTable(
                name: "BSLSamMgmt_BradyPrinteri5100");

            migrationBuilder.DropTable(
                name: "BSLSamMgmt_CenceCentrifugeCL5R");

            migrationBuilder.DropTable(
                name: "BSLSamMgmt_Centrifuge");

            migrationBuilder.DropTable(
                name: "BSLSamMgmt_Centrifuge5702");

            migrationBuilder.DropTable(
                name: "BSLSamMgmt_DellDeskComp");

            migrationBuilder.DropTable(
                name: "BSLSamMgmt_ESCOClassIITypeA2");

            migrationBuilder.DropTable(
                name: "BSLSamMgmt_LPVortexMixer");

            migrationBuilder.DropTable(
                name: "BSLSamMgmt_MicroLabSTARlet");

            migrationBuilder.DropTable(
                name: "BSLSamMgmt_MultitubeVortexer");

            migrationBuilder.DropTable(
                name: "BSLSamMgmt_Refrigerator");

            migrationBuilder.DropTable(
                name: "BSLSamMgmt_STPlusSeriesCentrifuge");

            migrationBuilder.DropTable(
                name: "BSLSamMgmt_TheromoMixer");

            migrationBuilder.DropTable(
                name: "CP1_DellDeskComp");

            migrationBuilder.DropTable(
                name: "CP1_ThermoFisher80");

            migrationBuilder.DropTable(
                name: "ILLUMINALibConst_Others");

            migrationBuilder.DropTable(
                name: "ILLUMINASeqLab_NovaSeq6000");

            migrationBuilder.DropTable(
                name: "ILLUMINASeqLab_Others");

            migrationBuilder.DropTable(
                name: "Lab1_DellDeskComp");

            migrationBuilder.DropTable(
                name: "Lab1_Others");

            migrationBuilder.DropTable(
                name: "Lab2_DellDeskComp");

            migrationBuilder.DropTable(
                name: "Lab2_Others");

            migrationBuilder.DropTable(
                name: "Lab3_DellDeskComp");

            migrationBuilder.DropTable(
                name: "Lab3_Others");

            migrationBuilder.DropTable(
                name: "Lab4_DellDeskComp");

            migrationBuilder.DropTable(
                name: "Lab4_Others");

            migrationBuilder.DropTable(
                name: "MGILibConstLab_Centrifuge5810R");

            migrationBuilder.DropTable(
                name: "MGILibConstLab_Fridge");

            migrationBuilder.DropTable(
                name: "MGILibConstLab_HaierHYC6102c8c");

            migrationBuilder.DropTable(
                name: "MGILibConstLab_MGISP100");

            migrationBuilder.DropTable(
                name: "MGILibConstLab_MGISP960");

            migrationBuilder.DropTable(
                name: "MGILibConstLab_Others");

            migrationBuilder.DropTable(
                name: "MGILibConstLab_PureWaterSystem");

            migrationBuilder.DropTable(
                name: "MGILibConstLab_TapeStation4200");

            migrationBuilder.DropTable(
                name: "MGILibConstLab_ThermalCycler");

            migrationBuilder.DropTable(
                name: "MGILibConstLab_Vortexer");

            migrationBuilder.DropTable(
                name: "MGISeqLab_Cabinet");

            migrationBuilder.DropTable(
                name: "MGISeqLab_Freezer");

            migrationBuilder.DropTable(
                name: "MGISeqLab_G400");

            migrationBuilder.DropTable(
                name: "MGISeqLab_PlateCentrifuge");

            migrationBuilder.DropTable(
                name: "MGISeqLab_PureWaterSystem");

            migrationBuilder.DropTable(
                name: "MGISeqLab_Refrigerator");

            migrationBuilder.DropTable(
                name: "MGISeqLab_T10BiochemicalPlatformPart");

            migrationBuilder.DropTable(
                name: "MGISeqLab_T10Loader");

            migrationBuilder.DropTable(
                name: "MGISeqLab_T10OpticalPlatformPart");

            migrationBuilder.DropTable(
                name: "MGISeqLab_T7");

            migrationBuilder.DropTable(
                name: "MGISeqLab_T7Loader");

            migrationBuilder.DropTable(
                name: "MGISeqLab_Ztron");

            migrationBuilder.DropTable(
                name: "ONTLibConstLab_DellDeskComp");

            migrationBuilder.DropTable(
                name: "ONTLibConstLab_MicroLabNGSSTAR");

            migrationBuilder.DropTable(
                name: "ONTSeqLab_Centrifuge5424");

            migrationBuilder.DropTable(
                name: "ONTSeqLab_Centrifuge5810R");

            migrationBuilder.DropTable(
                name: "ONTSeqLab_DellDeskComp");

            migrationBuilder.DropTable(
                name: "ONTSeqLab_HPLaserMFP137fnw");

            migrationBuilder.DropTable(
                name: "ONTSeqLab_IndDehumidifierClimatePlus");

            migrationBuilder.DropTable(
                name: "ONTSeqLab_PharmRef1");

            migrationBuilder.DropTable(
                name: "ONTSeqLab_PharmRef2");

            migrationBuilder.DropTable(
                name: "ONTSeqLab_PromethIONDataAcqTower");

            migrationBuilder.DropTable(
                name: "ONTSeqLab_PromethIONSeqUnit");

            migrationBuilder.DropTable(
                name: "ONTSeqLab_ThermofisherSciFridge");

            migrationBuilder.DropTable(
                name: "RDLab_BioSafetyCabinet");

            migrationBuilder.DropTable(
                name: "RDLab_Centrifuge5424R");

            migrationBuilder.DropTable(
                name: "RDLab_CompactDrybathS");

            migrationBuilder.DropTable(
                name: "RDLab_DellDeskComp");

            migrationBuilder.DropTable(
                name: "RDLab_ESCOClassIITypeA2BioSafetyCabinet");

            migrationBuilder.DropTable(
                name: "RDLab_FastPrep966010500");

            migrationBuilder.DropTable(
                name: "RDLab_GelDocE7Imager");

            migrationBuilder.DropTable(
                name: "RDLab_HaierDW40L508DeepFreezer40c20c");

            migrationBuilder.DropTable(
                name: "RDLab_HaierHYC6102c8c");

            migrationBuilder.DropTable(
                name: "RDLab_HeatStri");

            migrationBuilder.DropTable(
                name: "RDLab_HulaMixer");

            migrationBuilder.DropTable(
                name: "RDLab_LPVortexMixer");

            migrationBuilder.DropTable(
                name: "RDLab_MasterCycler");

            migrationBuilder.DropTable(
                name: "RDLab_MettlerToledoNEWClassicMF");

            migrationBuilder.DropTable(
                name: "RDLab_MicrowaveOven");

            migrationBuilder.DropTable(
                name: "RDLab_MiniSpin");

            migrationBuilder.DropTable(
                name: "RDLab_NanodropOne");

            migrationBuilder.DropTable(
                name: "RDLab_PowerPacBasic");

            migrationBuilder.DropTable(
                name: "RDLab_PrecisionGP10WaterBath");

            migrationBuilder.DropTable(
                name: "RDLab_Qubit4Fluorometer");

            migrationBuilder.DropTable(
                name: "RDLab_SWP01");

            migrationBuilder.DropTable(
                name: "RDLab_ThermalCycler");

            migrationBuilder.DropTable(
                name: "RDLab_ThermoScientificMyspin12");

            migrationBuilder.DropTable(
                name: "RDLab_ThermoScientificMyspin6");

            migrationBuilder.DropTable(
                name: "RoboticsLab_DellDeskComp");

            migrationBuilder.DropTable(
                name: "RoboticsLab_MicroLabNIMBUS");

            migrationBuilder.DropTable(
                name: "RoboticsLab_MicroLabSTAR");

            migrationBuilder.DropTable(
                name: "RoboticsLab_Others");

            migrationBuilder.DropTable(
                name: "UserProfile");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
