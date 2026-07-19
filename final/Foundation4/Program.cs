using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Running running1 = new Running("03 Nov 2022", 30, 3.0);
        Cycling cycling1 = new Cycling("04 Nov 2022", 45, 12.5);
        Swimming swimming1 = new Swimming("05 Nov 2022", 20, 40);

        List<Activity> activities = new List<Activity>();
        activities.Add(running1);
        activities.Add(cycling1);
        activities.Add(swimming1);

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}