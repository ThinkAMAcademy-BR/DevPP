using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DevPP.Migrations
{
    public partial class Upgraded_With_Thinkers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastPresentationUrl",
                table: "AbpUsers",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MiniBio",
                table: "AbpUsers",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Site",
                table: "AbpUsers",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "AbpUsers",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhatsApp",
                table: "AbpUsers",
                maxLength: 30,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AppPresentation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(maxLength: 128, nullable: false),
                    Description = table.Column<string>(maxLength: 2048, nullable: false),
                    Slide = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Video = table.Column<string>(nullable: true),
                    isActive = table.Column<bool>(nullable: false),
                    SpeakerId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppPresentation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppPresentation_AbpUsers_SpeakerId",
                        column: x => x.SpeakerId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppStatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppStatus", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppPresentation_SpeakerId",
                table: "AppPresentation",
                column: "SpeakerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppPresentation");

            migrationBuilder.DropTable(
                name: "AppStatus");

            migrationBuilder.DropColumn(
                name: "LastPresentationUrl",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "MiniBio",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "Site",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "WhatsApp",
                table: "AbpUsers");
        }
    }
}
