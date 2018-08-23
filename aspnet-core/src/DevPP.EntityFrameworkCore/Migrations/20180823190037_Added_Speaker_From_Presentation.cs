using Microsoft.EntityFrameworkCore.Migrations;

namespace DevPP.Migrations
{
    public partial class Added_Speaker_From_Presentation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "SpeakerId",
                table: "AppPresentation",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_AppPresentation_SpeakerId",
                table: "AppPresentation",
                column: "SpeakerId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppPresentation_AbpUsers_SpeakerId",
                table: "AppPresentation",
                column: "SpeakerId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppPresentation_AbpUsers_SpeakerId",
                table: "AppPresentation");

            migrationBuilder.DropIndex(
                name: "IX_AppPresentation_SpeakerId",
                table: "AppPresentation");

            migrationBuilder.DropColumn(
                name: "SpeakerId",
                table: "AppPresentation");
        }
    }
}
