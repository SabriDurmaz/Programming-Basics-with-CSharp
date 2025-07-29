int brstr = int.Parse(Console.ReadLine());
int strzah = int.Parse(Console.ReadLine());
int brday = int.Parse(Console.ReadLine());

int vreme = brstr / strzah;
int needtime = vreme / brday;
Console.WriteLine(needtime);