using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2rtytryrt.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dils",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dils", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Haqqimizdas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Context = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    Aderss = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Telefon1 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Telefon2 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haqqimizdas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Muellifs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MuellifId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muellifs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Muellifs_Muellifs_MuellifId",
                        column: x => x.MuellifId,
                        principalTable: "Muellifs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Newss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverImage = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    OxumaSayi = table.Column<int>(type: "int", nullable: false),
                    Like = table.Column<int>(type: "int", nullable: false),
                    UnLike = table.Column<int>(type: "int", nullable: false),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reklams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Context = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PressTelefon = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PressMail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BarnerMail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BarnerMobilePhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BarnerElaqePhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reklams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settingss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Haqqimizda = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settingss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sosials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    icon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Link = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sosials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryToNewss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewsId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryToNewss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryToNewss_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryToNewss_Newss_NewsId",
                        column: x => x.NewsId,
                        principalTable: "Newss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NewsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Newss_NewsId",
                        column: x => x.NewsId,
                        principalTable: "Newss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MuellifToNewss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewsId = table.Column<int>(type: "int", nullable: false),
                    MuellifId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuellifToNewss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MuellifToNewss_Muellifs_MuellifId",
                        column: x => x.MuellifId,
                        principalTable: "Muellifs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MuellifToNewss_Newss_NewsId",
                        column: x => x.NewsId,
                        principalTable: "Newss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryToNewss_CategoryId",
                table: "CategoryToNewss",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryToNewss_NewsId",
                table: "CategoryToNewss",
                column: "NewsId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_NewsId",
                table: "Images",
                column: "NewsId");

            migrationBuilder.CreateIndex(
                name: "IX_Muellifs_MuellifId",
                table: "Muellifs",
                column: "MuellifId");

            migrationBuilder.CreateIndex(
                name: "IX_MuellifToNewss_MuellifId",
                table: "MuellifToNewss",
                column: "MuellifId");

            migrationBuilder.CreateIndex(
                name: "IX_MuellifToNewss_NewsId",
                table: "MuellifToNewss",
                column: "NewsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryToNewss");

            migrationBuilder.DropTable(
                name: "Dils");

            migrationBuilder.DropTable(
                name: "Haqqimizdas");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "MuellifToNewss");

            migrationBuilder.DropTable(
                name: "Reklams");

            migrationBuilder.DropTable(
                name: "Settingss");

            migrationBuilder.DropTable(
                name: "Sosials");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Muellifs");

            migrationBuilder.DropTable(
                name: "Newss");
        }
    }
}
