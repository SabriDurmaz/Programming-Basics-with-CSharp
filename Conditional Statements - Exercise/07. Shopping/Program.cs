double budget = double.Parse(Console.ReadLine());
int videoCardsCount = int.Parse(Console.ReadLine());
int cpusCount = int.Parse(Console.ReadLine());
int ramCount = int.Parse(Console.ReadLine());
double videoCardsSum = videoCardsCount * 250;
double cpuPrice = videoCardsSum * 0.35;
double ramPrice = videoCardsSum * 0.1;
double totalSum = videoCardsSum + cpuPrice * cpusCount + ramPrice * ramCount;
if (videoCardsCount > cpusCount)
{
    totalSum *= 0.85;
}
if (totalSum <= budget)
{
    double moneyLeft = budget - totalSum;
    Console.WriteLine($"You have {moneyLeft:f2} leva left!");
}
else
{
    double moneyNeeded = totalSum - budget;
    Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva more!");
}