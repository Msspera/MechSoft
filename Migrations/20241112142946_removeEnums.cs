using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MechSoft.Migrations
{
    /// <inheritdoc />
    public partial class removeEnums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Atendimento",
                table: "Atendimento");

            migrationBuilder.RenameTable(
                name: "Atendimento",
                newName: "Atendimentos");

            migrationBuilder.AlterColumn<string>(
                name: "Etapa",
                table: "Atendimentos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Categoria",
                table: "Atendimentos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Atendimentos",
                table: "Atendimentos",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Atendimentos",
                table: "Atendimentos");

            migrationBuilder.RenameTable(
                name: "Atendimentos",
                newName: "Atendimento");

            migrationBuilder.AlterColumn<int>(
                name: "Etapa",
                table: "Atendimento",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Categoria",
                table: "Atendimento",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Atendimento",
                table: "Atendimento",
                column: "Id");
        }
    }
}
