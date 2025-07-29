int degrees = int.Parse(Console.ReadLine());
string dayTime = Console.ReadLine();
string Outfit = "";
string Shoes = "";
if (degrees >= 10 && degrees <= 18)
{
    switch (dayTime)
    {
        case "Morning":
            Outfit = "Sweatshirt";
            Shoes = "Sneakers";
            break;
        case "Afternoon":
        case "Evening":
            Outfit = "Shirt";
            Shoes = "Moccasins";
            break;
    }
}
else if (degrees >= 19 && degrees <= 24)
{

    switch (dayTime)
    {
        case "Morning":
        case "Evening":
            Outfit = "Shirt";
            Shoes = "Moccasins";
            break;
        case "Afternoon":
            Outfit = "T-Shirt";
            Shoes = "Sandals";
            break;
    }
}
else if (degrees >= 25 && degrees <= 42)
{

    switch (dayTime)
    {
        case "Morning":
            Outfit = "T-Shirt";
            Shoes = "Sandals";
            break;
        case "Afternoon":
            Outfit = "Swim Suit";
            Shoes = "Barefoot";
            break;
        case "Evening":
            Outfit = "Shirt";
            Shoes = "Moccasins";
            break;
    }
}
Console.WriteLine($"It's {degrees} degrees, get your {Outfit} and {Shoes}.");