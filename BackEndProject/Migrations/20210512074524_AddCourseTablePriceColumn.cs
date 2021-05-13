using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndProject.Migrations
{
    public partial class AddCourseTablePriceColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseFee",
                table: "DetailCourses");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "DetailCourses",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "DetailCourses");

            migrationBuilder.AddColumn<string>(
                name: "CourseFee",
                table: "DetailCourses",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
