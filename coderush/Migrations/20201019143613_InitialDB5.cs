using Microsoft.EntityFrameworkCore.Migrations;

namespace coderush.Migrations
{
    public partial class InitialDB5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ONTLibConstLab_DellDeskComp");

            migrationBuilder.DropTable(
                name: "ONTLibConstLab_MicroLabNGSSTAR");
        }
    }
}
