string city = Console.ReadLine().Trim().ToLower();
if (!double.TryParse(Console.ReadLine(), out double sales) || sales < 0)
{
    Console.WriteLine("error");
    return;
}

double commission = 0;
bool isValid = true;

switch (city)
{
    case "sofia":
        if (sales <= 500) commission = sales * 0.05;
        else if (sales <= 1000) commission = sales * 0.07;
        else if (sales <= 10000) commission = sales * 0.08;
        else commission = sales * 0.12;
        break;
    case "varna":
        if (sales <= 500) commission = sales * 0.045;
        else if (sales <= 1000) commission = sales * 0.075;
        else if (sales <= 10000) commission = sales * 0.10;
        else commission = sales * 0.13;
        break;
    case "plovdiv":
        if (sales <= 500) commission = sales * 0.055;
        else if (sales <= 1000) commission = sales * 0.08;
        else if (sales <= 10000) commission = sales * 0.12;
        else commission = sales * 0.145;
        break;
    default:
        isValid = false;
        break;
}

if (isValid)
{
    Console.WriteLine($"{commission:F2}");
}
else
{
    Console.WriteLine("error");
}
