using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolApi.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    School = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[,]
                {
                    { "f83013ce-dcf4-4166-859c-15a5989a61fe", "Tom", "Day", "Physics" },
                    { "e64f7478-0528-44e9-98d9-70f39a139fb7", "Ann", "Fox", "Geology" },
                    { "21bb2bce-173c-44c3-9585-11946ceb1d6f", "Art", "Ash", "Nursing" },
                    { "d3e4e52b-83a7-4f61-893e-86844529cc8d", "Mia", "Hay", "Science" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
