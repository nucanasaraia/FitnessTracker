namespace FitnessTracker.Models;

internal class User
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    
    public List<Workout> Workouts { get; set; }
    public List<Meal> Meals { get; set; }
    public List<Progress> Progress { get; set; }
    public List<Goal> Goals { get; set; }

}
