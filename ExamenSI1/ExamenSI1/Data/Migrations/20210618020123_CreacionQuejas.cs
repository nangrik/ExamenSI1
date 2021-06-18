using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamenSI1.Data.Migrations
{
    public partial class CreacionQuejas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quejas",
                columns: table => new
                {
                    QuejaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quejafecha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuejaNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuejaIdentidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuejaCc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuejaNumero = table.Column<int>(type: "int", nullable: false),
                    QuejaDependencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuejaCargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuejaEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuejaQueja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuejaRelacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuejaPrueba = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quejas", x => x.QuejaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quejas");
        }
    }
}
