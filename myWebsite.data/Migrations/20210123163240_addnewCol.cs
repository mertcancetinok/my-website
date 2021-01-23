using Microsoft.EntityFrameworkCore.Migrations;

namespace myWebsite.data.Migrations
{
    public partial class addnewCol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LongDescription",
                table: "UserDetails",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LongDescription",
                table: "UserDetails");
        }
    }
}
