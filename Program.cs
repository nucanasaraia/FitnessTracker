using System;
using FitnessTracker.Data;
using Microsoft.EntityFrameworkCore;
using FitnessTracker.FluentValidation;
using FitnessTracker.Database;
using FitnessTracker.Models;

class Program
{
    static void Main()
    {
        using (DataContext context = new DataContext())
        {
            DatabaseSeeder.Seed(context);

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your height (in cm):");
            double height = Convert.ToDouble(Console.ReadLine()) / 100; 

            Console.WriteLine("Enter your weight (in kg):");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your email:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();
            var newUser = new User
            {
                Name = name,
                Age = age,
                Height = height,
                Weight = weight,
                Email = email,
                Password = password
            };

            var validator = new UserValidator();
            var validationResult = validator.Validate(newUser);

            if (validationResult.IsValid)
            {
                context.Users.Add(newUser);
                context.SaveChanges();
                Console.WriteLine("User added successfully!");

                var addedUser = context.Users.OrderByDescending(u => u.ID).FirstOrDefault();
                if (addedUser != null)
                {
                    Console.WriteLine($"User {addedUser.Name} added with ID: {addedUser.ID}");
                }
            }
            else
            {
                Console.WriteLine("User validation failed. Please correct the following errors:");
                foreach (var error in validationResult.Errors)
                {
                    Console.WriteLine($"- {error.ErrorMessage}");
                }
            }
        }

        Console.ReadLine(); 
    }
}
