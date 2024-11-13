using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MechSoft.Migrations
{
    /// <inheritdoc />
    public partial class addValoresServicos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ServicosRealizados",
                table: "Atendimentos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "ValorTotal",
                table: "Atendimentos",
                type: "real",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServicosRealizados",
                table: "Atendimentos");

            migrationBuilder.DropColumn(
                name: "ValorTotal",
                table: "Atendimentos");
        }
    }
}
