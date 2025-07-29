double depositsum = double.Parse(Console.ReadLine());
int depositTime = int.Parse(Console.ReadLine());
double yearproc = double.Parse(Console.ReadLine());

double lihva = depositsum * yearproc / 100;
double lihvafor1mounth = lihva / 12;

double sum = depositsum + depositTime * lihvafor1mounth;
Console.WriteLine(sum);