using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hcodef.Migrations
{
    public partial class AddTablestudentsubjectAndRelationShip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "studentsubject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentId = table.Column<int>(type: "int", nullable: false),
                    subjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentsubject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_studentsubject_Students_studentId",
                        column: x => x.studentId,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_studentsubject_Subjects_subjectId",
                        column: x => x.subjectId,
                        principalTable: "Subjects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_studentsubject_studentId",
                table: "studentsubject",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_studentsubject_subjectId",
                table: "studentsubject",
                column: "subjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "studentsubject");
        }
    }
}
