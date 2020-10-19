using Microsoft.EntityFrameworkCore.Migrations;

namespace coderush.Migrations
{
    public partial class InitialDB7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RDLab_BioSafetyCabinet",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(nullable: true),
                    LogTemperature = table.Column<string>(nullable: true),
                    LogStatus = table.Column<string>(nullable: true),
                    LogRemarks = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RDLab_BioSafetyCabinet", x => x.LogId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RDLab_BioSafetyCabinet");
        }
    }
}
