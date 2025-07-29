int dalzhina = int.Parse(Console.ReadLine());
int shirochina = int.Parse(Console.ReadLine());
int visochina = int.Parse(Console.ReadLine());
double procent = double.Parse(Console.ReadLine());

double obem = dalzhina * shirochina * visochina;
double obemvlt = obem * 0.001;
double zaetoprostranstvo = procent / 100;
double nujnilt = obemvlt * (1 - zaetoprostranstvo);
Console.WriteLine(nujnilt);