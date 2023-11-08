using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace reservasedufoscal.Migrations
{
    /// <inheritdoc />
    public partial class added_reservas_5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "celular",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "rolid",
                table: "tipoUsuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "status",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_status", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "reserva",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuarioid = table.Column<int>(type: "int", nullable: false),
                    fechainicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechafin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    observacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    espacioid = table.Column<int>(type: "int", nullable: false),
                    npersonas = table.Column<int>(type: "int", nullable: false),
                    statusid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reserva", x => x.id);
                    table.ForeignKey(
                        name: "FK_reserva_Usuarios_usuarioid",
                        column: x => x.usuarioid,
                        principalTable: "Usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reserva_espacios_espacioid",
                        column: x => x.espacioid,
                        principalTable: "espacios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reserva_status_statusid",
                        column: x => x.statusid,
                        principalTable: "status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tipoUsuarios_rolid",
                table: "tipoUsuarios",
                column: "rolid");

            migrationBuilder.CreateIndex(
                name: "IX_reserva_espacioid",
                table: "reserva",
                column: "espacioid");

            migrationBuilder.CreateIndex(
                name: "IX_reserva_statusid",
                table: "reserva",
                column: "statusid");

            migrationBuilder.CreateIndex(
                name: "IX_reserva_usuarioid",
                table: "reserva",
                column: "usuarioid");

            migrationBuilder.AddForeignKey(
                name: "FK_tipoUsuarios_roles_rolid",
                table: "tipoUsuarios",
                column: "rolid",
                principalTable: "roles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tipoUsuarios_roles_rolid",
                table: "tipoUsuarios");

            migrationBuilder.DropTable(
                name: "reserva");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "status");

            migrationBuilder.DropIndex(
                name: "IX_tipoUsuarios_rolid",
                table: "tipoUsuarios");

            migrationBuilder.DropColumn(
                name: "celular",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "rolid",
                table: "tipoUsuarios");
        }
    }
}
