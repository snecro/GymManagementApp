using GymManagementApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagementApp.Data
{
    public class GymContext : IdentityDbContext
    {
        public GymContext(DbContextOptions<GymContext> options)
            : base(options)
        {
        }

        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Pricing> Prices { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Trainer>().HasData(
            new Trainer
            {
                TrainerId = 1,
                TrainerName = "Liam Smith",
                TrainerPhoto = "LiamSmith.jpg",
                ImageMimeType = "image/jpeg",
                TrainerDescription = "I am a hard-working and driven individual who isn't afraid to face a challenge."
            },
            new Trainer
            {
                TrainerId = 2,
                TrainerName = "Patricia Anderson",
                TrainerPhoto = "PatriciaAnderson.jpg",
                ImageMimeType = "image/jpeg",
                TrainerDescription= "I'm passionate about my work and I know how to motivate people."
            },
            new Trainer
            {
                TrainerId = 3,
                TrainerName = "James Robert",
                TrainerPhoto = "JamesRobert.jpg",
                ImageMimeType = "image/jpeg",
                TrainerDescription= "I would describe myself as an open and honest person who doesn't believe in misleading other people and tries to be fair in everything I do."
            },
            new Trainer
            {
                TrainerId = 4,
                TrainerName = "Carmen Serban",
                TrainerPhoto = "CarmenSerban.jpg",
                ImageMimeType = "image/jpeg",
                TrainerDescription= "As a group fitness instructor, lead fun, energetic classes for diverse age groups and fitness levels."
            },
            new Trainer
            {
                TrainerId = 5,
                TrainerName = "Mateo Rossi",
                TrainerPhoto = "MateoRossi.jpg",
                ImageMimeType = "image/jpeg",
                TrainerDescription= "As a personal trainer, lead individualized workouts incorporating aerobic and anaerobic exercises."
            });

            modelBuilder.Entity<Workout>().HasData(
            new Workout
            {
                WorkoutId = 1,
                WorkoutName = "Yoga",
                WorkoutDescription = "Yoga is a mind and body practice. Various styles of yoga combine physical postures, breathing techniques, and meditation or relaxation. Yoga is an ancient practice that may have originated in India. It involves movement, meditation, and breathing techniques to promote mental and physical well-being.",
                WorkoutPhoto = "yoga.jpg",
                ImageMimeType = "image/jpeg",
                TrainerId = 4
            },
            new Workout
            {
                WorkoutId = 2,
                WorkoutName = "Pilates",
                WorkoutDescription = "Pilates is a form of exercise which concentrates on strengthening the body with an emphasis on core strength. This helps to improve general fitness and overall well-being. Similar to Yoga, Pilates concentrates on posture, balance and flexibility.",
                WorkoutPhoto = "pilates.jpg",
                ImageMimeType = "image/jpeg",
                TrainerId = 5
            },
            new Workout
            {
                WorkoutId = 3,
                WorkoutName = "Army Workout",
                WorkoutDescription = "Army workout training is a form of exercise intended to increase muscular strength and endurance.It involves exercising muscles using some form of resistance. This resistance could be weights, bands, or even your own bodyweight working against gravity.",
                WorkoutPhoto = "armyWorkout.jpg",
                ImageMimeType = "image/jpeg",
                TrainerId = 1
            },
            new Workout
            {
                WorkoutId = 4,
                WorkoutName = "Functional HIIT",
                WorkoutDescription = "High-intensity interval training (HIIT) allows participants to maintain high-intensity exercise for longer periods of time than during continuous exercise. This type of training has been shown to lead to greater improvements in aerobic fitness and body composition when compared to moderate steady-state workouts.",
                WorkoutPhoto = "functionalHiit.jpg",
                ImageMimeType = "image/jpeg",
                TrainerId = 3
            },
            new Workout
            {
                WorkoutId = 5,
                WorkoutName = "Kangoo Jumps",
                WorkoutDescription = "Kangoo Jumps is an easy, safe and effective cardio rebounding workout system consisting of specially designed boots. Together, the boots and fitness programs make working out so much fun, that you won't believe you are actually exercising!",
                WorkoutPhoto = "kangooJumps.jpg",
                ImageMimeType = "image/jpeg",
                TrainerId = 2
            }); ;

            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    ContactDescription = "If you need any kind of information we are kindly pleased to help.",
                    ContactPhoneNumber = 0766487433,
                    ContactEmail = "sweat@gmail.com",
                    Location = "Bucharest, Victoriei Street, Number 55."
                });

            modelBuilder.Entity<Reservation>().HasData(
               new Reservation
               {
                   ReservationId = 1,
                   ReservationWorkoutName = TrainingTypesEnum.Yoga,
                   ReservationDay = DayEnum.Monday,
                   Members = 1
               },
               new Reservation
               {
                   ReservationId = 2,
                   ReservationWorkoutName = TrainingTypesEnum.ArmyWorkout,
                   ReservationDay = DayEnum.Tuesday,
                   Members = 2
               });

            modelBuilder.Entity<Pricing>().HasData(
               new Pricing
               {
                   PricingId = 1,
                   Subscription = "One year",
                   PricingDescription = "Access to all group classes, VIP benefits, SPA access, 10 free sessions with a personal trainer",
                   Price = 3000
               },
               new Pricing
               {
                   PricingId = 2,
                   Subscription = "Six months",
                   PricingDescription = "Access to all group classes, VIP benefits, 6 free sessions with a personal trainer",
                   Price = 2000
               },
               new Pricing
               {
                   PricingId = 3,
                   Subscription = "Three months",
                   PricingDescription = "20 hours access to all group class access per month, 3 free sessions with a personal trainer",
                   Price = 1000
               },
                new Pricing
                {
                    PricingId = 4,
                    Subscription = "One month",
                    PricingDescription = "15 hours access to all group class access",
                    Price = 5000
                });
        }
    }
}