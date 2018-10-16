using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DevPP.Migrations
{
    public partial class Added_Columns_DevPP_From_User : Migration
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
