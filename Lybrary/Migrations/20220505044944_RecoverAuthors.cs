using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lybrary.Migrations
{
    public partial class RecoverAuthors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Artists_ArticalId",
                table: "Authors");

            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Books_BookId",
                table: "Authors");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Authors_AuthorId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_AuthorId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Authors_ArticalId",
                table: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Authors_BookId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ArticalId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Authors");

            migrationBuilder.CreateTable(
                name: "ArticalAuthor",
                columns: table => new
                {
                    ArticalsId = table.Column<int>(type: "INTEGER", nullable: false),
                    AuthorsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticalAuthor", x => new { x.ArticalsId, x.AuthorsId });
                    table.ForeignKey(
                        name: "FK_ArticalAuthor_Artists_ArticalsId",
                        column: x => x.ArticalsId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticalAuthor_Authors_AuthorsId",
                        column: x => x.AuthorsId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuthorBook",
                columns: table => new
                {
                    AuthrosId = table.Column<int>(type: "INTEGER", nullable: false),
                    BooksId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorBook", x => new { x.AuthrosId, x.BooksId });
                    table.ForeignKey(
                        name: "FK_AuthorBook_Authors_AuthrosId",
                        column: x => x.AuthrosId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorBook_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticalAuthor_AuthorsId",
                table: "ArticalAuthor",
                column: "AuthorsId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBook_BooksId",
                table: "AuthorBook",
                column: "BooksId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticalAuthor");

            migrationBuilder.DropTable(
                name: "AuthorBook");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArticalId",
                table: "Authors",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Authors",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_AuthorId",
                table: "Items",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_ArticalId",
                table: "Authors",
                column: "ArticalId");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_BookId",
                table: "Authors",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Artists_ArticalId",
                table: "Authors",
                column: "ArticalId",
                principalTable: "Artists",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Books_BookId",
                table: "Authors",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Authors_AuthorId",
                table: "Items",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id");
        }
    }
}
