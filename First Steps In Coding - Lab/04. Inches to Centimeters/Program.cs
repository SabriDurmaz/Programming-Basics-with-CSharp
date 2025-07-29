double inches = double.Parse(Console.ReadLine());

double conversionFactor = 2.54;

double centimeters = inches * conversionFactor;

Console.WriteLine($"{centimeters:F2}");