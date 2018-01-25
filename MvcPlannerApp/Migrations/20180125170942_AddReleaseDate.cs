using Microsoft.EntityFrameworkCore.Migrations;


namespace MvcPlannerApp.Migrations
{
    public partial class AddReleaseDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Plans",
                newName: "ReleaseDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "Plans",
                newName: "StartDate");
        }
    }
}
