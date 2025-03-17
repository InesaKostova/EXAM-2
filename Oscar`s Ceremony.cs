int rent = int.Parse(Console.ReadLine());

double statues = rent-(rent*0.3);
double food = statues - (statues * 0.15);
double music = food / 2;
double finalSum =  rent +statues+food+music;

Console.WriteLine($"{finalSum:F2}");
