using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymManagementApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class Reservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TrainerName",
                table: "Trainers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrainerDescription",
                table: "Trainers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationWorkoutName = table.Column<int>(type: "int", nullable: false),
                    ReservationHour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Members = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationId);
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationId", "Members", "ReservationHour", "ReservationWorkoutName" },
                values: new object[] { 1, 0, "17", 0 });

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 1,
                column: "TrainerDescription",
                value: "I am a hard-working and driven individual who isn't afraid to face a challenge");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 2,
                column: "TrainerDescription",
                value: "I'm passionate about my work and I know how to motivate people");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 3,
                column: "TrainerDescription",
                value: "I would describe myself as an open and honest person who doesn't believe in misleading other people and tries to be fair in everything I do");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 4,
                column: "TrainerDescription",
                value: "As a group fitness instructor, lead fun, energetic classes for diverse age groups and fitness levels");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 5,
                column: "TrainerDescription",
                value: "As a personal trainer, lead individualized workouts incorporating aerobic and anaerobic exercises");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropColumn(
                name: "TrainerDescription",
                table: "Trainers");

            migrationBuilder.AlterColumn<string>(
                name: "TrainerName",
                table: "Trainers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
