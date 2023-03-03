using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GymManagementApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class Pricing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    PricingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subscription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PricingDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.PricingId);
                });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "ContactDescription",
                value: "If you need any kind of information we are kindly pleased to help.");

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "PricingId", "Price", "PricingDescription", "Subscription" },
                values: new object[,]
                {
                    { 1, 3000, "Access to all group classes, VIP benefits, SPA access, 10 free sessions with a personal trainer", "One year" },
                    { 2, 2000, "Access to all group classes, VIP benefits, 6 free sessions with a personal trainer", "Six months" },
                    { 3, 1000, "20 hours access to all group class access per month, 3 free sessions with a personal trainer", "Three months" },
                    { 4, 5000, "15 hours access to all group class access", "One month" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "ContactDescription",
                value: "If you need any kind of information we are kindly pleased to help.</br>You can reach out at the following number");
        }
    }
}
