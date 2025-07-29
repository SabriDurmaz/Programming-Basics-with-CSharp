using System;

class Program
{
    static void Main()
    {
        int tournaments = int.Parse(Console.ReadLine());
        int initialPoints = int.Parse(Console.ReadLine());

        int totalPoints = initialPoints;
        int pointsFromTournaments = 0;
        int wonTournaments = 0;

        for (int i = 0; i < tournaments; i++)
        {
            string stage = Console.ReadLine();

            if (stage == "W")
            {
                totalPoints += 2000;
                pointsFromTournaments += 2000;
                wonTournaments++;
            }
            else if (stage == "F")
            {
                totalPoints += 1200;
                pointsFromTournaments += 1200;
            }
            else if (stage == "SF")
            {
                totalPoints += 720;
                pointsFromTournaments += 720;
            }
        }

        int averagePoints = pointsFromTournaments / tournaments;
        double winPercentage = (double)wonTournaments / tournaments * 100;

        Console.WriteLine($"Final points: {totalPoints}");
        Console.WriteLine($"Average points: {averagePoints}");
        Console.WriteLine($"{winPercentage:F2}%");
    }
}
