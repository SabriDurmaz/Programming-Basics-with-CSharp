int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fishers = int.Parse(Console.ReadLine());
double sum = 0;
switch (season)
{
    case "Spring":
        sum = 3000;
        break;
    case "Summer":
        sum = 4200;
        break;
    case "Autumn":
        sum = 4200;
        break;
    case "Winter":
        sum = 2600;
        break;
}
if (fishers <= 6)
{
    sum *= 0.9;
}
else if (fishers >= 7 && fishers <= 11)
{
    sum *= 0.85;
}
else if (fishers >= 12)
{
    sum *= 0.75;
}
if (fishers % 2 == 0 && season != "Autumn")
{
    sum *= 0.95;
}

if (budget >= sum)
{
    double plus = budget - sum;
    Console.WriteLine($"Yes! You have {plus:F2} leva left.");
}
else
{
    double minus = sum - budget;
    Console.WriteLine($"Not enough money! You need {minus:F2} leva.");
}