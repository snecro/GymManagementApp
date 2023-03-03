using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymManagementApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkoutTrainerId",
                table: "Workouts");

            migrationBuilder.AddColumn<int>(
                name: "TrainerId",
                table: "Workouts",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "WorkoutId",
                keyValue: 1,
                column: "TrainerId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "WorkoutId",
                keyValue: 2,
                column: "TrainerId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "WorkoutId",
                keyValue: 3,
                column: "TrainerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "WorkoutId",
                keyValue: 4,
                column: "TrainerId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "WorkoutId",
                keyValue: 5,
                column: "TrainerId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_TrainerId",
                table: "Workouts",
                column: "TrainerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_Trainers_TrainerId",
                table: "Workouts",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "TrainerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_Trainers_TrainerId",
                table: "Workouts");

            migrationBuilder.DropIndex(
                name: "IX_Workouts_TrainerId",
                table: "Workouts");

            migrationBuilder.DropColumn(
                name: "TrainerId",
                table: "Workouts");

            migrationBuilder.AddColumn<int>(
                name: "WorkoutTrainerId",
                table: "Workouts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "WorkoutId",
                keyValue: 1,
                column: "WorkoutTrainerId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "WorkoutId",
                keyValue: 2,
                column: "WorkoutTrainerId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "WorkoutId",
                keyValue: 3,
                column: "WorkoutTrainerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "WorkoutId",
                keyValue: 4,
                column: "WorkoutTrainerId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "WorkoutId",
                keyValue: 5,
                column: "WorkoutTrainerId",
                value: 2);
        }
    }
}
