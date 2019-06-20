using Microsoft.EntityFrameworkCore.Migrations;

namespace FunctionStudentsAPI.Migrations
{
    public partial class m1 : Migration
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
                    { "695fef8f-6702-4a9c-a1f4-f49c798462c5", "Jane", "Smith", "Medicine" },
                    { "b5e2814c-a56b-4bfc-a7cc-a1676763e43c", "John", "Fisher", "Engineering" },
                    { "e80785c9-7a07-41a1-a932-c8c9a03e405a", "Pamela", "Baker", "Food Science" },
                    { "215bcf8e-fd72-486d-842e-bb754c1d2ea5", "Peter", "Taylor", "Mining" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
