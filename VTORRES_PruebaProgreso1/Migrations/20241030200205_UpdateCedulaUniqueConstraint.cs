using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VTORRES_PruebaProgreso1.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCedulaUniqueConstraint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Cedula",
                table: "Torres",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Torres_Cedula",
                table: "Torres",
                column: "Cedula",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Torres_Cedula",
                table: "Torres");

            migrationBuilder.AlterColumn<int>(
                name: "Cedula",
                table: "Torres",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
