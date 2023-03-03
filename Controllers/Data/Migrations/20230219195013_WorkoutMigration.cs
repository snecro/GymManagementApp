using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GymManagementApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class WorkoutMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    WorkoutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkoutName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    WorkoutPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkoutDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoFile = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ImageMimeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkoutTrainerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.WorkoutId);
                });

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 3,
                column: "TrainerPhoto",
                value: "JamesRobert.jpg");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 4,
                column: "TrainerPhoto",
                value: "CarmenSerban.jpg");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 5,
                column: "TrainerPhoto",
                value: "MateoRossi.jpg");

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "WorkoutId", "ImageMimeType", "PhotoFile", "WorkoutDescription", "WorkoutName", "WorkoutPhoto", "WorkoutTrainerId" },
                values: new object[,]
                {
                    { 1, "image/jpeg", null, "Yoga is a mind and body practice. Various styles of yoga combine physical postures, breathing techniques, and meditation or relaxation. Yoga is an ancient practice that may have originated in India. It involves movement, meditation, and breathing techniques to promote mental and physical well-being.", "Yoga", "", 4 },
                    { 2, "image/jpeg", null, "Pilates is a form of exercise which concentrates on strengthening the body with an emphasis on core strength. This helps to improve general fitness and overall well-being. Similar to Yoga, Pilates concentrates on posture, balance and flexibility.", "Pilates", "", 5 },
                    { 3, "image/jpeg", null, "Army workout training is a form of exercise intended to increase muscular strength and endurance.It involves exercising muscles using some form of resistance. This resistance could be weights, bands, or even your own bodyweight working against gravity.", "Army Workout", "", 1 },
                    { 4, "image/jpeg", null, "High-intensity interval training (HIIT) allows participants to maintain high-intensity exercise for longer periods of time than during continuous exercise. This type of training has been shown to lead to greater improvements in aerobic fitness and body composition when compared to moderate steady-state workouts.", "Functional HIIT", "", 3 },
                    { 5, "image/jpeg", null, "Kangoo Jumps is an easy, safe and effective cardio rebounding workout system consisting of specially designed boots. Together, the boots and fitness programs make working out so much fun, that you won't believe you are actually exercising!", "Kangoo Jumps", "", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Workouts");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 3,
                column: "TrainerPhoto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 4,
                column: "TrainerPhoto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 5,
                column: "TrainerPhoto",
                value: null);
        }
    }
}
