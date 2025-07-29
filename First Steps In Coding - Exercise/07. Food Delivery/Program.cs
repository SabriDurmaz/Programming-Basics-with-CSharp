int brpilmen = int.Parse(Console.ReadLine());
int brmensrib = int.Parse(Console.ReadLine());
int brvegmen = int.Parse(Console.ReadLine());

double sumpilmen = brpilmen * 10.35;
double summensrib = brmensrib * 12.40;
double sumvegmen = brvegmen * 8.15;
double suma = sumpilmen + summensrib + sumvegmen;
double desert = suma * 0.20;
double dostavka = +2.50;
double obshtasum = suma + desert + dostavka;
Console.WriteLine(obshtasum);