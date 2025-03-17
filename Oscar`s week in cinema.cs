string film = Console.ReadLine();
string typeHall = Console.ReadLine();
int tickets = int.Parse(Console.ReadLine());
double priceForOneTicket = 0;

if (film == "A Star Is Born")
{if(typeHall =="normal")
    {
        priceForOneTicket = 7.50;
    }
else if(typeHall =="luxury")
    {
        priceForOneTicket = 10.50;
    }
else if(typeHall=="ultra luxury")
    {
        priceForOneTicket = 13.50;
    }

}
else if(film == "Bohemian Rhapsody")
{
    if(typeHall == "normal")
    {
        priceForOneTicket = 7.35;
    }
else if (typeHall == "luxury")
    {
        priceForOneTicket = 9.45;
    }
    else if (typeHall == "ultra luxury")
    {
        priceForOneTicket = 12.75;
    }

}
else if(film== "Green Book")
{
    if(typeHall == "normal")
    {
        priceForOneTicket = 8.15;
    }
else if (typeHall == "luxury")
    {
        priceForOneTicket = 10.25;
    }
    else if (typeHall == "ultra luxury")
    {
        priceForOneTicket = 13.25;
    }

}
else if(film== "The Favourite")
{
    if(typeHall == "normal")
    {
        priceForOneTicket = 8.75;
    }
else if (typeHall == "luxury")
    {
        priceForOneTicket = 11.55;
    }
    else if (typeHall == "ultra luxury")
    {
        priceForOneTicket = 13.95;
    }

}
double sum = tickets * priceForOneTicket;
Console.WriteLine($"{film} -> {sum:F2} lv.");