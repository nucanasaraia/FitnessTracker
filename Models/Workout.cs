namespace FitnessTracker.Models;

internal class Workout
{
    public int WorkoutID { get; set; }
    public string WorkoutType { get; set; }
    public int Duration { get; set; }
    public double CaloriesBurned { get; set; }
    public DateTime Date { get; set; }


    public User User { get; set; }
    public int UserID { get; set; }
}
