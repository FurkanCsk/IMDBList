using IMDB_List;

// Create a list to hold Film objects
List<Film> filmlist = new List<Film>();

// Loop to continuously add films until the user decides to exit
while (true)
{ 
    // Prompt the user to enter the film name or press 'q' to quit
    Console.WriteLine("Enter the film name for add to the list. Press 'q' to exit the loop.");
    string name = Console.ReadLine();

    // Exit the loop if the user inputs 'q'
    if(name.ToLower() == "q")
    {
        break;
    }

    // Call method to get valid IMDB rating from the user
    double imdbPoint = GetImdbPoint();

    // Add the new film to the list
    filmlist.Add(new Film(name, imdbPoint));
}

// Display all movies in the list
Console.WriteLine("\n**** Movies int the list : ****\n");

foreach(var film in filmlist)
{
    Console.WriteLine($"Film name : {film.FilmName}, IMDB Rating : {film.ImdbPoint}\n");
}

// Display movies with IMDB ratings between 4 and 9
Console.WriteLine("\n**** Movies with IMDB ratings between 4 and 9 : ****\n");
foreach (var film in filmlist)
{
    if(film.ImdbPoint >= 4 && film.ImdbPoint <= 9)
    {
        Console.WriteLine($"Film name : {film.FilmName}, IMDB Point : {film.ImdbPoint}");
    }
}

// Display movies starting with the letter 'A'
Console.WriteLine("\n**** Movies starting with the letter 'A' : ****\n");
foreach (var film in filmlist)
{
    if(film.FilmName.Substring(0,1) == "a" || film.FilmName.Substring(0, 1) == "A" )
    {
        Console.WriteLine($"Film name : {film.FilmName}, IMDB Point : {film.ImdbPoint}");
    }
}

// Method to get a valid IMDB rating from the user
double GetImdbPoint()
{
    double imdbPoint = 0;

    while (true)
    {
        // Prompt the user to enter a valid IMDb rating
        Console.WriteLine("Enter the film's IMDB rating.Between 0 and 10 : ");

        // Check if the input is a valid double within the specified range
        if (double.TryParse(Console.ReadLine(), out imdbPoint) && imdbPoint >= 0 && imdbPoint <= 10)
        {
            break;
        }
        else
        {
            // Inform the user about the invalid input
            Console.WriteLine("Invalid input. Please enter a valid IMDb point between 0 and 10.");
        }
    }
    return imdbPoint;
}