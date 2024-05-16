public static class MovieService
{
    public static void ListMovies(List<Movie> movies)
    {
        Console.WriteLine("Available Movies:");
        int counter = 1;
        foreach (Movie movie in movies)
        {
            Console.WriteLine($"{counter}. {movie.Title}");
            counter++;
        }
    }

    public static Movie SelectMovie(List<Movie> movies)
    {
        Console.WriteLine("Enter movie number to see details (or 0 to exit):");
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice > 0 && choice <= movies.Count)
        {
            return movies[choice - 1];
        }
        else
        {
            return null;
        }
    }

    public static int SelectSeat(Movie movie)
    {
        Console.WriteLine($"Available Seats for {movie.Title} ({movie.Showtimes[0]}):");
        for (int i = 1; i <= movie.Seats; i++)
        {
            if (i <= movie.AvailableSeats)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine($"{i} (Unavailable)");
            }
        }
        Console.WriteLine("Enter seat number:");
        int seat = Convert.ToInt32(Console.ReadLine());
        if (seat > 0 && seat <= movie.Seats && seat <= movie.AvailableSeats)
        {
            return seat;
        }
        else
        {
            Console.WriteLine("Invalid seat selection.");
            return 0;
        }
    }
    
    public static void ConfirmBooking(Movie movie, DateTime showtime, int seat, string customerName)
    {
        Console.WriteLine($"Booking Confirmation:");
        Console.WriteLine($"Movie: {movie.Title}");
        Console.WriteLine($"Showtime: {showtime}");
        Console.WriteLine($"Seat Number: {seat}");
        Console.WriteLine($"Customer Name: {customerName}");
        Console.WriteLine("Confirm booking (y/n)?");
        char confirm = Convert.ToChar(Console.ReadLine());
        if (confirm == 'y' || confirm == 'Y')
        {
            movie.AvailableSeats--; // Update available seats after confirmation
            Console.WriteLine("Booking successful!");
        }
        else
        {
            Console.WriteLine("Booking cancelled.");
        }
    }
}