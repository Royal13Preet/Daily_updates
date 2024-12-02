using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Adding_migration.Migrations
{
    /// <inheritdoc />
    public partial class seed_method : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Name", "description" },
                values: new object[,]
                {
                    { 1, "Maths", "Mathematics1" },
                    { 2, "Scien", "Science" },
                    { 3, "SocialScience", "Social" },
                    { 4, "C#", "C#" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "email", "phone" },
                values: new object[] { 1, "john doe", "psre@gmail.com", 79658590 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "StudebtDoB", "StudentAge", "StudentGender", "StudentName", "StudentPhone", "courseId" },
                values: new object[] { 1, new DateTime(2002, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "male", "pss", 894634302, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
