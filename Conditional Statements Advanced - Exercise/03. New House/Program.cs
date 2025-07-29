string flower = Console.ReadLine();
int pcsflower = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());
double sum = 0;
switch (flower)
{
    case "Roses":
        sum = 5 * pcsflower;
        break;
    case "Dahlias":
        sum = 3.80 * pcsflower;
        break;
    case "Tulips":
        sum = 2.80 * pcsflower;
        break;
    case "Narcissus":
        sum = 3 * pcsflower;
        break;
    case "Gladiolus":
        sum = 2.50 * pcsflower;
        break;
}
if (flower == "Roses" && pcsflower > 80)
{
    sum *= 0.9;
}
if (flower == "Dahlias" && pcsflower > 90)
{
    sum *= 0.85;

}
if (flower == "Tulips" && pcsflower > 80)
{
    sum *= 0.85;

}
if (flower == "Narcissus" && pcsflower < 120)
{
    sum *= 1.15;

}
if (flower == "Gladiolus" && pcsflower < 80)
{
    sum *= 1.2;
}
double minus = sum - budget;
double plus = budget - sum;
if (budget >= sum)
{
    Console.WriteLine($"Hey, you have a great garden with {pcsflower} {flower} and {plus:F2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money, you need {minus:F2} leva more.");
}