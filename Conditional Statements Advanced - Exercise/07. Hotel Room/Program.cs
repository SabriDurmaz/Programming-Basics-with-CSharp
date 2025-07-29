string month = Console.ReadLine();
int nights = int.Parse(Console.ReadLine());
double priceS = 0;
double priceA = 0;
if (month == "May" || month == "October")
{
    priceS = 50 * nights;
    if (nights > 7 && nights <= 14)
    {
        priceS = priceS - priceS * 0.05;
    }
    else if (nights > 14)
    {
        priceS = priceS - priceS * 0.30;
    }
    priceA = 65 * nights;
    if (nights > 14)
    {
        priceA = priceA - priceA * 0.10;
    }
}
else if (month == "June" || month == "September")
{
    priceS = 75.20 * nights;
    if (nights > 14)
    {
        priceS = priceS - priceS * 0.20;
    }
    priceA = 68.70 * nights;
    if (nights > 14)
    {
        priceA = priceA - priceA * 0.10;
    }
}
else if (month == "July" || month == "August")
{
    priceS = 76 * nights;
    priceA = 77 * nights;
    if (nights > 14)
    {
        priceA = priceA - priceA * 0.10;
    }
}
Console.WriteLine($"Apartment: {priceA:f2} lv.");
Console.WriteLine($"Studio: {priceS:f2} lv.");