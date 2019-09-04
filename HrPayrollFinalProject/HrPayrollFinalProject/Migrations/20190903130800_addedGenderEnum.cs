using Microsoft.EntityFrameworkCore.Migrations;

namespace HrPayrollFinalProject.Migrations
{
    public partial class addedGenderEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "employees",
                nullable: false,
                oldClrType: typeof(bool));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Gender",
                table: "employees",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
