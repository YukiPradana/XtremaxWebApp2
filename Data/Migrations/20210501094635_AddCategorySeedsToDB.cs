using Microsoft.EntityFrameworkCore.Migrations;

namespace XtremaxWebApp2.Data.Migrations
{
    public partial class AddCategorySeedsToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Into Categories(Name) Values ('Food')");
            migrationBuilder.Sql("Insert Into Categories(Name) Values ('Sport')");
            migrationBuilder.Sql("Insert Into Categories(Name) Values ('Travel')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
