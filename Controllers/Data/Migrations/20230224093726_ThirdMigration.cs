using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymManagementApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class ThirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPhoneNumber = table.Column<int>(type: "int", nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "ContactDescription", "ContactEmail", "ContactPhoneNumber", "Location" },
                values: new object[] { 1, "If you need any kind of information we are kindly pleased to help.</br>You can reach out at the following number", "sweat@gmail.com", 766487433, "Bucharest, Victoriei Street, Number 55." });

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "WorkoutId",
                keyValue: 1,
                column: "WorkoutPhoto",
                value: "yoga.jpg");

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "WorkoutId",
                keyValue: 2,
                column: "WorkoutPhoto",
                value: "pilates.jpg");

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "WorkoutId",
                keyValue: 3,
                column: "WorkoutPhoto",
                value: "armyWorkout.jpg");

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "WorkoutId",
                keyValue: 4,
                column: "WorkoutPhoto",
                value: "functionalHiit.jpg");

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "WorkoutId",
                keyValue: 5,
                column: "WorkoutPhoto",
                value: "kangooJumps.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "WorkoutId",
                keyValue: 1,
                column: "WorkoutPhoto",
                value: "");

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "WorkoutId",
                keyValue: 2,
                column: "WorkoutPhoto",
                value: "");

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "WorkoutId",
                keyValue: 3,
                column: "WorkoutPhoto",
                value: "");

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "WorkoutId",
                keyValue: 4,
                column: "WorkoutPhoto",
                value: "");

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "WorkoutId",
                keyValue: 5,
                column: "WorkoutPhoto",
                value: "");
        }
    }
}
