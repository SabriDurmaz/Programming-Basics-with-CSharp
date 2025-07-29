string[] fruits = { "banana", "apple", "kiwi", "cherry", "lemon", "grapes" };
string[] vegetables = { "tomato", "cucumber", "pepper", "carrot" };

string product = Console.ReadLine().Trim().ToLower();

if (Array.Exists(fruits, element => element == product))
{
    Console.WriteLine("fruit");
}
else if (Array.Exists(vegetables, element => element == product))
{
    Console.WriteLine("vegetable");
}
else
{
    Console.WriteLine("unknown");
}
