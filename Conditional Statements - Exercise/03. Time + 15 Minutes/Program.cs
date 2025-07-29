int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

int addMins = 15;
int totalMinutes = minutes + addMins;
int newHours = hours + totalMinutes / 60;
int newMinutes = totalMinutes % 60;

newHours = newHours % 24;

string formattedTime = $"{newHours}:{newMinutes:D2}";
Console.WriteLine(formattedTime);