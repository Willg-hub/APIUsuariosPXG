using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIUsuarios.Migrations
{
    /// <inheritdoc />
    public partial class adicaocamponomeusuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NomeUsuario",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeUsuario",
                table: "AspNetUsers");
        }
    }
}
