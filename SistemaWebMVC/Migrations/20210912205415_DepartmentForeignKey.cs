using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaWebMVC.Migrations
{
    public partial class DepartmentForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainee_Department_DepartmentId",
                table: "Trainee");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Trainee",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainee_Department_DepartmentId",
                table: "Trainee",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainee_Department_DepartmentId",
                table: "Trainee");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Trainee",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Trainee_Department_DepartmentId",
                table: "Trainee",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
