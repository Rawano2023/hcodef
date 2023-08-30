using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hcodef.Migrations
{
    public partial class AddTableTeacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Students_studentsID",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "studentsID",
                table: "Cards",
                newName: "StudentsId");

            migrationBuilder.RenameIndex(
                name: "IX_Cards_studentsID",
                table: "Cards",
                newName: "IX_Cards_StudentsId");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Students_StudentsId",
                table: "Cards",
                column: "StudentsId",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Students_StudentsId",
                table: "Cards");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.RenameColumn(
                name: "StudentsId",
                table: "Cards",
                newName: "studentsID");

            migrationBuilder.RenameIndex(
                name: "IX_Cards_StudentsId",
                table: "Cards",
                newName: "IX_Cards_studentsID");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Students_studentsID",
                table: "Cards",
                column: "studentsID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
