using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyApp.Data.Migrations
{
    public partial class UpdateSurvey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Surveys",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Surveys");
        }
    }
}
