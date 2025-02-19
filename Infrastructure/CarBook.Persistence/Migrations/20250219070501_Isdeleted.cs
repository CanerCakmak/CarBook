using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Isdeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DeleteStatus",
                table: "Testimonials",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "DeleteStatus",
                table: "SocialMedias",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "DeleteStatus",
                table: "Services",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "DeleteStatus",
                table: "Pricings",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "DeleteStatus",
                table: "Locations",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "DeleteStatus",
                table: "Footers",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "DeleteStatus",
                table: "Features",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "DeleteStatus",
                table: "Contacts",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "DeleteStatus",
                table: "Cars",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "DeleteStatus",
                table: "CarPricings",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "DeleteStatus",
                table: "CarFeatures",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "DeleteStatus",
                table: "CarDescriptions",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "DeleteStatus",
                table: "Brands",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "DeleteStatus",
                table: "BlogCategories",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "DeleteStatus",
                table: "Banners",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "DeleteStatus",
                table: "Abouts",
                newName: "IsDeleted");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Testimonials",
                newName: "DeleteStatus");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "SocialMedias",
                newName: "DeleteStatus");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Services",
                newName: "DeleteStatus");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Pricings",
                newName: "DeleteStatus");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Locations",
                newName: "DeleteStatus");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Footers",
                newName: "DeleteStatus");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Features",
                newName: "DeleteStatus");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Contacts",
                newName: "DeleteStatus");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Cars",
                newName: "DeleteStatus");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "CarPricings",
                newName: "DeleteStatus");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "CarFeatures",
                newName: "DeleteStatus");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "CarDescriptions",
                newName: "DeleteStatus");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Brands",
                newName: "DeleteStatus");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "BlogCategories",
                newName: "DeleteStatus");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Banners",
                newName: "DeleteStatus");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Abouts",
                newName: "DeleteStatus");
        }
    }
}
