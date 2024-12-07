using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryBook.Migrations
{
    /// <inheritdoc />
    public partial class First_one : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "author",
                columns: table => new
                {
                    AuthorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_author", x => x.AuthorID);
                });

            migrationBuilder.CreateTable(
                name: "book",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookGenre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_book", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_book_author_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "author",
                        principalColumn: "AuthorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "author",
                columns: new[] { "AuthorID", "AuthorName" },
                values: new object[,]
                {
                    { 1, "Ravinder" },
                    { 2, "Mark Douglass" },
                    { 3, "Kuvempu" }
                });

            migrationBuilder.InsertData(
                table: "book",
                columns: new[] { "BookId", "AuthorID", "BookGenre", "BookTitle" },
                values: new object[,]
                {
                    { 10, 1, "Romantic", "Can Love Happen Twice" },
                    { 11, 3, "LifeStyle", "The house of Kanooru" },
                    { 12, 1, "Childhood", "Like it happend yesterday" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_book_AuthorID",
                table: "book",
                column: "AuthorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "book");

            migrationBuilder.DropTable(
                name: "author");
        }
    }
}
