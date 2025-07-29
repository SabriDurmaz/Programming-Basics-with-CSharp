int dogFoodPackages = int.Parse(Console.ReadLine());

int catFoodPackages = int.Parse(Console.ReadLine());

double dogFoodPrice = 2.5;
double catFoodPrice = 4.0;

double totalCost = (dogFoodPackages * dogFoodPrice) + (catFoodPackages * catFoodPrice);

Console.WriteLine($"{totalCost} lv.");