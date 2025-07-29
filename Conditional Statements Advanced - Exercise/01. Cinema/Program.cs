string Projection = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());
double ticketPrice = 0;
int totalSeat = rows * columns;
switch (Projection)
{
    case "Premiere": ticketPrice = 12.00; break;
    case "Normal": ticketPrice = 7.50; break;
    case "Discount": ticketPrice = 5.00; break;
}
double totalSum = ticketPrice * totalSeat;
Console.WriteLine($"{totalSum:f2} leva");