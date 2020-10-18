using Microsoft.EntityFrameworkCore.Migrations;

namespace coderush.Migrations
{
    public partial class InitialDb4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
