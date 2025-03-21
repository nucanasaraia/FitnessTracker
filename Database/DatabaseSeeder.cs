using FitnessTracker.Data;
using FitnessTracker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Database
{
    public static class DatabaseSeeder 
    {
        internal static void Seed(DataContext context)
        {
            if (!context.Users.Any()) 
            {
                var users = new[]
                {
                new User { Name = "Theo", Age = 40, Height = 1.85, Weight = 58.6, Email = "theojames@gmail.com", Password = "britishactor" },
                new User { Name = "Jone", Age = 25, Height = 1.75, Weight = 70, Email = "jone@example.com", Password = "password123" },
                new User { Name = "Alice", Age = 30, Height = 1.68, Weight = 60, Email = "alice@example.com", Password = "password123" },
                new User { Name = "Bob", Age = 22, Height = 1.80, Weight = 80, Email = "bob@example.com", Password = "password123" },
                new User { Name = "Emma", Age = 28, Height = 1.60, Weight = 55, Email = "emma@example.com", Password = "password123" },
                new User { Name = "Chris", Age = 35, Height = 1.85, Weight = 90, Email = "chris@example.com", Password = "password123" }
            };

                context.Users.AddRange(users);
                context.SaveChanges();
            }

            var userList = context.Users.ToList(); 

            if (!context.Workouts.Any())
            {
                var workouts = new[]
                {
                new Workout { UserID = userList[0].ID, WorkoutType = "Cardio", Duration = 30, CaloriesBurned = 300, Date = DateTime.Now.AddDays(-1) },
                new Workout { UserID = userList[1].ID, WorkoutType = "Strength Training", Duration = 45, CaloriesBurned = 400, Date = DateTime.Now.AddDays(-2) },
                new Workout { UserID = userList[2].ID, WorkoutType = "Yoga", Duration = 60, CaloriesBurned = 200, Date = DateTime.Now.AddDays(-3) },
                new Workout { UserID = userList[3].ID, WorkoutType = "Cardio", Duration = 25, CaloriesBurned = 250, Date = DateTime.Now.AddDays(-4) }
            };

                context.Workouts.AddRange(workouts);
                context.SaveChanges();
            }

            if (!context.Meals.Any())
            {
                var meals = new[]
                {
                new Meal { UserID = userList[0].ID, MealType = "Breakfast", Calories = 350, MealDate = DateTime.Now.AddDays(-1), Description = "Oatmeal with berries" },
                new Meal { UserID = userList[1].ID, MealType = "Lunch", Calories = 450, MealDate = DateTime.Now.AddDays(-2), Description = "Grilled chicken with vegetables" }
            };

                context.Meals.AddRange(meals);
                context.SaveChanges();
            }

            if (!context.Progress.Any())
            {
                var progressUpdates = new[]
                {
                new Progress { Date = DateTime.Now.AddDays(-10), Weight = 57.5, BodyFatPercentage = 18.5, MusclesMass = 42, BMI = 16.8, UserID = userList[0].ID },
                new Progress { Date = DateTime.Now.AddDays(-5), Weight = 56.8, BodyFatPercentage = 18.2, MusclesMass = 41.5, BMI = 16.5, UserID = userList[0].ID },
                new Progress { Date = DateTime.Now.AddDays(-7), Weight = 71, BodyFatPercentage = 16.8, MusclesMass = 45, BMI = 23.2, UserID = userList[1].ID }
            };

                context.Progress.AddRange(progressUpdates);
                context.SaveChanges();
            }

            Console.WriteLine("Database seeded successfully.");
        }

    }
}
