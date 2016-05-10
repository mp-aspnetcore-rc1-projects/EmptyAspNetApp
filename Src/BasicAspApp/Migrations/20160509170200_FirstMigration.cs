using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace BasicAspApp.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComputerLanguage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:Serial", true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerLanguage", x => x.Id);
                });
            migrationBuilder.CreateTable(
                name: "Snippet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:Serial", true),
                    ComputerLanguageId = table.Column<int>(nullable: false),
                    Content = table.Column<string>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    UpateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Snippet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Snippet_ComputerLanguage_ComputerLanguageId",
                        column: x => x.ComputerLanguageId,
                        principalTable: "ComputerLanguage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Snippet");
            migrationBuilder.DropTable("ComputerLanguage");
        }
    }
}
