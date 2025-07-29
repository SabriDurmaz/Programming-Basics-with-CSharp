double brhim = double.Parse(Console.ReadLine());
double brmar = double.Parse(Console.ReadLine());
double ltprep = double.Parse(Console.ReadLine());
double discount = double.Parse(Console.ReadLine());

brhim = brhim * 5.80;
brmar = brmar * 7.20;
ltprep = ltprep * 1.20;
double price = brhim + brmar + ltprep;
double pricewithdiscount = price - (price * discount / 100);
Console.WriteLine(pricewithdiscount);