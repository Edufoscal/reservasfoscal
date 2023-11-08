using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace reservasedufoscal.Migrations
{
    /// <inheritdoc />
    public partial class added_tables_reservatios_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_tipoUsuarios_tipoUsuarioId",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "tipoUsuarioId",
                table: "Usuarios",
                newName: "TipoUsuarioid");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_tipoUsuarioId",
                table: "Usuarios",
                newName: "IX_Usuarios_TipoUsuarioid");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_tipoUsuarios_TipoUsuarioid",
                table: "Usuarios",
                column: "TipoUsuarioid",
                principalTable: "tipoUsuarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_tipoUsuarios_TipoUsuarioid",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "TipoUsuarioid",
                table: "Usuarios",
                newName: "tipoUsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_TipoUsuarioid",
                table: "Usuarios",
                newName: "IX_Usuarios_tipoUsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_tipoUsuarios_tipoUsuarioId",
                table: "Usuarios",
                column: "tipoUsuarioId",
                principalTable: "tipoUsuarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
