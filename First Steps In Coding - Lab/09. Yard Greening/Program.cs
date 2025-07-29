double areaToLandscape = double.Parse(Console.ReadLine());

double pricePerSqMeter = 7.61;
double discountRate = 0.18;

double initialPrice = areaToLandscape * pricePerSqMeter;
double discount = initialPrice * discountRate;
double finalPrice = initialPrice - discount;

Console.WriteLine($"The final price is: {finalPrice:F2} lv.");
Console.WriteLine($"The discount is: {discount:F2} lv.");