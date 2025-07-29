using System;

class Program
{
    static void Main()
    {
        int minNumber = int.MaxValue; 

        while (true)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "stop")
            {
                break;
            }

            int number;
            if (int.TryParse(input, out number))
            {
                if (number < minNumber)
                {
                    minNumber = number;
                }
            }
        }

        if (minNumber != int.MaxValue)
        {
            Console.WriteLine(minNumber);
        }
    }
}
