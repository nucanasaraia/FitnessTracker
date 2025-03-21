namespace FitnessTracker.Models;

internal class Goal
{
    public int GoalID { get; set; }
    public string GoalType { get; set;}
    public double TargetValue { get; set;}
    public DateTime TargetDate { get; set; }


    public List<User> Users { get; set; } = new List<User>();
}
