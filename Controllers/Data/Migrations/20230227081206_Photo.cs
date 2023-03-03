using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymManagementApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class Photo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                column: "Members",
                value: 1);

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationId", "Members", "ReservationHour", "ReservationWorkoutName" },
                values: new object[] { 2, 2, "18", 3 });

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 1,
                column: "TrainerDescription",
                value: "I am a hard-working and driven individual who isn't afraid to face a challenge.");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 2,
                column: "TrainerDescription",
                value: "I'm passionate about my work and I know how to motivate people.");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 3,
                column: "TrainerDescription",
                value: "I would describe myself as an open and honest person who doesn't believe in misleading other people and tries to be fair in everything I do.");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 4,
                column: "TrainerDescription",
                value: "As a group fitness instructor, lead fun, energetic classes for diverse age groups and fitness levels.");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 5,
                column: "TrainerDescription",
                value: "As a personal trainer, lead individualized workouts incorporating aerobic and anaerobic exercises.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                column: "Members",
                value: 0);

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
    }
}
