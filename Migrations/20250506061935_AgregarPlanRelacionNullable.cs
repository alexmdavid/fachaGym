using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fachaGym.Migrations
{
    /// <inheritdoc />
    public partial class AgregarPlanRelacionNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Planes_Plan_Id",
                table: "Usuarios");

            migrationBuilder.AlterColumn<int>(
                name: "Plan_Id",
                table: "Usuarios",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "IdPlan",
                table: "Usuarios",
                type: "integer",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Planes_Plan_Id",
                table: "Usuarios",
                column: "Plan_Id",
                principalTable: "Planes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Planes_Plan_Id",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "IdPlan",
                table: "Usuarios");

            migrationBuilder.AlterColumn<int>(
                name: "Plan_Id",
                table: "Usuarios",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Planes_Plan_Id",
                table: "Usuarios",
                column: "Plan_Id",
                principalTable: "Planes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
