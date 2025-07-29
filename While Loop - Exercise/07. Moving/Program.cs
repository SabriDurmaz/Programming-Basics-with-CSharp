using System;

class Program
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());

        int freeSpace = width * length * height;
        int usedSpace = 0;

        while (true)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "done")
            {
                break;
            }

            int boxes = int.Parse(input);
            usedSpace += boxes;

            if (usedSpace > freeSpace)
            {
                Console.WriteLine($"No more free space! You need {usedSpace - freeSpace} Cubic meters more.");
                return;
            }
        }

        int remainingSpace = freeSpace - usedSpace;

        Console.WriteLine($"{remainingSpace} Cubic meters left.");
    }
}
