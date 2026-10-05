using System;

public enum ActivityLevel
{
    Low,
    Medium,
    High
}

public class Bunny
{
    public string Name { get; set; } = "";
    public bool LikesCarrots { get; set; }
    public bool LikesHumans { get; set; }
    public ActivityLevel Activity { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Likes carrots: " + LikesCarrots);
        Console.WriteLine("Likes humans: " + LikesHumans);
        Console.WriteLine("Activity level: " + Activity);
        Console.WriteLine();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Bunny bunny1 = new Bunny
        {
            Name = "Coco",
            LikesCarrots = true,
            LikesHumans = true,
            Activity = ActivityLevel.Medium
        };

        Bunny bunny2 = new Bunny
        {
            Name = "Max",
            LikesCarrots = true,
            LikesHumans = false,
            Activity = ActivityLevel.High
        };

        bunny1.PrintInfo();
        bunny2.PrintInfo();

        if (bunny2.Activity == ActivityLevel.High)
        {
            Console.WriteLine(bunny2.Name + " has a high activity level.");
        }
    }
}