double naylon = double.Parse(Console.ReadLine());
double boq = double.Parse(Console.ReadLine());
double razreditel = double.Parse(Console.ReadLine());
double chasovetrud = double.Parse(Console.ReadLine());

naylon += 2;
double kvonaylon = naylon * 1.50;
boq = boq * 1.1;
double kvoboq = boq * 14.50;
double kvorazreditel = razreditel * 5.0;
double matsum = kvonaylon + kvoboq + kvorazreditel + 0.40;
double maystor = (matsum * 30 / 100) * chasovetrud;
double endsum = matsum + maystor;
Console.WriteLine(endsum);
