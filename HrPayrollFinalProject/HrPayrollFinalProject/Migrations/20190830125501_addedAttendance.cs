using Microsoft.EntityFrameworkCore.Migrations;

namespace HrPayrollFinalProject.Migrations
{
    public partial class addedAttendance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Attendance",
                table: "Continuities",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Attendance",
                table: "Continuities");
        }
    }
}
