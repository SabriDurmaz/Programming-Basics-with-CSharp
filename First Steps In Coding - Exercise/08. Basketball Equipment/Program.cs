int yearsum = int.Parse(Console.ReadLine());

double basketballkets = yearsum - (yearsum * 0.40);
double basketballekip = basketballkets - (basketballkets * 0.20);
double basketballball = basketballekip * 0.25;
double basketballaksesoaries = basketballball * 0.2;
double totalsum = yearsum + basketballkets + basketballekip + basketballball + basketballaksesoaries;
Console.WriteLine(totalsum);