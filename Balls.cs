int n = int.Parse(Console.ReadLine());
double totalPoints = 0;
int countRedBalls = 0;
int countOrangeBalls = 0;
int countYellowBalls = 0;
int countWhiteBalls = 0;
int countOtherColors = 0;
int countBlackBalls=0;


for (int i=1;i<=n;i++)
{
    string color = Console.ReadLine();

    if (color == "red")
    {
        countRedBalls++;
        totalPoints += 5;
    }
    else if (color == "orange")
    {
        countOrangeBalls++;
        totalPoints += 10;
    }
    else if (color == "yellow")
    {
        countYellowBalls++;
        totalPoints += 15;
    }
    else if (color == "white")
    {
        countWhiteBalls++;
        totalPoints += 20;
    }
    else if (color == "black")
    {
        countBlackBalls++;
        totalPoints=totalPoints/2;
        
    }
    else if(color!="red"&& color!="orange"&&color!="yellow" && color!="white" && color!="black") 
    {
        countOtherColors++;
        totalPoints = totalPoints;
    }

}
Console.WriteLine($"Total points: {Math.Floor(totalPoints)}");
Console.WriteLine($"Red balls: {countRedBalls}");
Console.WriteLine($"Orange balls: {countOrangeBalls}");
Console.WriteLine($"Yellow balls: {countYellowBalls}");
Console.WriteLine($"White balls: {countWhiteBalls}");
Console.WriteLine($"Other colors picked: {countOtherColors}");
Console.WriteLine($"Divides from black balls: {countBlackBalls}");
