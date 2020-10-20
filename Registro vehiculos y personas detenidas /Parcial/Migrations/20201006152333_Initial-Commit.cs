using Microsoft.EntityFrameworkCore.Migrations;

namespace Parcial.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonaVe",
                columns: table => new
                {
                    IdPersona = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdReporteVehiculo2 = table.Column<int>(nullable: false),
                    NombrePersona = table.Column<string>(nullable: true),
                    ApellidoPersona = table.Column<string>(nullable: true),
                    CedulaPersona = table.Column<string>(nullable: true),
                    LugarPersonaAtrapada = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaVe", x => x.IdPersona);
                });

            migrationBuilder.CreateTable(
                name: "ReportesVe",
                columns: table => new
                {
                    IdReporteVehiculo = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PlacaVehiculo = table.Column<string>(nullable: true),
                    MarcaVehiculo = table.Column<string>(nullable: true),
                    ModeloVehiculo = table.Column<string>(nullable: true),
                    ColorVehiculo = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportesVe", x => x.IdReporteVehiculo);
                });

            migrationBuilder.InsertData(
                table: "PersonaVe",
                columns: new[] { "IdPersona", "ApellidoPersona", "CedulaPersona", "IdReporteVehiculo2", "LugarPersonaAtrapada", "NombrePersona" },
                values: new object[] { 1, null, null, 0, null, null });

            migrationBuilder.InsertData(
                table: "ReportesVe",
                columns: new[] { "IdReporteVehiculo", "ColorVehiculo", "Descripcion", "MarcaVehiculo", "ModeloVehiculo", "PlacaVehiculo" },
                values: new object[] { 1, null, null, null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonaVe");

            migrationBuilder.DropTable(
                name: "ReportesVe");
        }
    }
}
