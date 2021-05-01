using Microsoft.EntityFrameworkCore.Migrations;

namespace XtremaxWebApp2.Data.Migrations
{
    public partial class AddStatusSeedsToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Into Status(Name) Values ('Open')");
            migrationBuilder.Sql("Insert Into Status(Name) Values ('In Progress')");
            migrationBuilder.Sql("Insert Into Status(Name) Values ('Done')");
            migrationBuilder.Sql("Insert Into Status(Name) Values ('Closed')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
