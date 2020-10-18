using Microsoft.EntityFrameworkCore.Migrations;

namespace coderush.Migrations
{
    public partial class InitialDb3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
