int countMovies = int.Parse(Console.ReadLine());
double max = 1.00;
double min = 10.00;
string highestRatedMovie = "";
string lowestRatedMovie = "";
double totalReating = 0;

for (int currentMovie = 1; currentMovie <= countMovies; currentMovie++)
{ string name = Console.ReadLine();
    double ratings = double.Parse(Console.ReadLine());
    
    
    if (ratings >max)
    {
        max = ratings;
        highestRatedMovie = name;
    }
    if(ratings<min)
    {
        min = ratings;
        lowestRatedMovie = name;
    }
    totalReating += ratings;
}
double average = totalReating / countMovies;


Console.WriteLine($"{highestRatedMovie} is with highest rating: {max:f1}");
Console.WriteLine($"{lowestRatedMovie} is with lowest rating: {min:F1}");
Console.WriteLine($"Average rating: {average:F1}");