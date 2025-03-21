namespace FitnessTracker.Models;

internal class Meal
{
    public int MealID { get; set; }
    public string MealType { get; set;}
    public int Calories { get; set; }
    public DateTime MealDate { get; set; }
    public string Description { get; set; }


    public User User { get; set; }
    public int UserID { get; set; }

}
