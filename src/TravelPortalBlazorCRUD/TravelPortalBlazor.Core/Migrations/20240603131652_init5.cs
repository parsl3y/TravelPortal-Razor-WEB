using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelPortalBlazor.Core.Migrations
{
    /// <inheritdoc />
    public partial class init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "PlaceFamous");

            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "PlaceFamous",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlaceFamous_CityId",
                table: "PlaceFamous",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlaceFamous_City_CityId",
                table: "PlaceFamous",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlaceFamous_City_CityId",
                table: "PlaceFamous");

            migrationBuilder.DropIndex(
                name: "IX_PlaceFamous_CityId",
                table: "PlaceFamous");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "PlaceFamous");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "PlaceFamous",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
