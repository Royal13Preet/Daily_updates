using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Adding_migration.Migrations
{
    /// <inheritdoc />
    public partial class added_relation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "courseId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_courseId",
                table: "Students",
                column: "courseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_courseId",
                table: "Students",
                column: "courseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_courseId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_courseId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "courseId",
                table: "Students");
        }
    }
}
