using System.ComponentModel.DataAnnotations;

namespace FitnessTracker.Models;

internal class Progress
{
    [Key]
    public int ProgressID { get; set; }
    public DateTime Date { get; set; }
    public double Weight { get; set; }
    public double BodyFatPercentage { get; set; }
    public double MusclesMass { get; set;}
    public double BMI {  get; set; }


    public User User { get; set; }
    public int UserID { get; set; }


}
