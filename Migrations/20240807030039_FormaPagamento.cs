using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Controle.Migrations
{
    /// <inheritdoc />
    public partial class FormaPagamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FormaPagamento",
                table: "Dayuse",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FormaPagamento",
                table: "Dayuse");
        }
    }
}
