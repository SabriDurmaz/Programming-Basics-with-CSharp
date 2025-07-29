string geofig = Console.ReadLine();
double S = 0;
if (geofig == "square")
{
    double sideA = double.Parse(Console.ReadLine());
    S = sideA * sideA;
}
else if (geofig == "rectangle")
{
    double sideA = double.Parse(Console.ReadLine());
    double sideB = double.Parse(Console.ReadLine());
    S = sideA * sideB;
}
else if (geofig == "circle")
{
    double radius = double.Parse(Console.ReadLine());
    S = Math.PI * Math.Pow(radius, 2);
}
else if (geofig == "triangle")
{
    double sideA = double.Parse(Console.ReadLine());
    double sideB = double.Parse(Console.ReadLine());
    S = sideA * sideB / 2;
}
Console.WriteLine($"{S:F3}");