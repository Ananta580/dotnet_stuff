using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace A2.Migrations
{
    /// <inheritdoc />
    public partial class ProductAddition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4175a3f9-bdb8-4172-b9ba-4962db42a941");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9705809a-8093-47d4-a7b2-fda718f7705c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fbae318-ffd3-465a-894a-99e93778d639");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ShortDescription = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    IsFeatured = table.Column<bool>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "59b427df-6d15-4ab1-a1dc-c69d3a420999", null, "User", "USER" },
                    { "85e46a27-7d0e-486a-9fe4-13505deec557", null, "Editor", "EDITOR" },
                    { "9d65cd90-c690-473c-8884-f32b8f341525", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "IsFeatured", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "Experience superior sound quality with Anker's noise-cancelling wireless headphones, designed for long-lasting comfort and perfect for on-the-go music lovers.", "images/a.jpg", true, "Anker Headphone", 49.99m, "High-quality wireless headphone with noise cancellation" },
                    { 2, "Capture and print photos instantly with the Insta Camera, featuring retro design and easy-to-use functionality, ideal for events and outings.", "images/b.jpg", true, "Insta Camera", 29.99m, "Instant camera for capturing memories" },
                    { 3, "Stay connected and monitor your health metrics with the latest Apple Watch, featuring advanced sensors and a sleek design for everyday wear.", "images/c.jpg", true, "Apple Watch", 59.99m, "Smartwatch with health tracking features" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59b427df-6d15-4ab1-a1dc-c69d3a420999");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85e46a27-7d0e-486a-9fe4-13505deec557");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d65cd90-c690-473c-8884-f32b8f341525");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4175a3f9-bdb8-4172-b9ba-4962db42a941", null, "User", "USER" },
                    { "9705809a-8093-47d4-a7b2-fda718f7705c", null, "Admin", "ADMIN" },
                    { "9fbae318-ffd3-465a-894a-99e93778d639", null, "Editor", "EDITOR" }
                });
        }
    }
}
