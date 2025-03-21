string bestPlayer = "";
int bestGoals = 0;
while(true)
{
 string name = Console.ReadLine();
if(name=="END")
    {
        break;
    }
int goals = int.Parse(Console.ReadLine());
    if(goals > bestGoals)
    {
        bestPlayer= name;
        bestGoals = goals;
    }
    if (goals >= 10)
    {
        break;
    }

}
Console.WriteLine($"{bestPlayer} is the best player!");
if (bestGoals >= 3)
{
    Console.WriteLine($"He has scored {bestGoals} goals and made a hat-trick !!!");
}
else
{
    Console.WriteLine($"He has scored {bestGoals} goals.");
}

