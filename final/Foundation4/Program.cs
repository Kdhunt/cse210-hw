using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Creating instances of each activity type
        Activity runningActivity = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        Activity cyclingActivity = new Cycling(new DateTime(2022, 11, 4), 45, 15.0);
        Activity swimmingActivity = new Swimming(new DateTime(2022, 11, 5), 20, 10);

        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        // Displaying summary for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}