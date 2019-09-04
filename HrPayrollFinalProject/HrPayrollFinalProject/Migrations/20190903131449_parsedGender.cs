using Microsoft.EntityFrameworkCore.Migrations;

namespace HrPayrollFinalProject.Migrations
{
    public partial class parsedGender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "employees",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "employees",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
