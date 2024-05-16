List<Movie> movies = new List<Movie>(); // Replace with data population logic
while (true)
{
    Console.WriteLine("Welcome to Cinema Booking System!");
    Console.WriteLine("1. List Movies");
    Console.WriteLine("2. Exit");
    int choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 1)
    {
        MovieService.ListMovies(movies);
        Movie selectedMovie = MovieService.SelectMovie(movies);
        if (selectedMovie != null)
        {
            int seatNumber = MovieService.SelectSeat(selectedMovie);
            if (seatNumber > 0)
            {
                Console.WriteLine("Enter your name:");
                string customerName = Console.ReadLine();
                MovieService.ConfirmBooking(selectedMovie, selectedMovie.Showtimes[0], seatNumber, customerName);
            }
        }
    }
    else if (choice == 2)
    {
        Console.WriteLine("Thank you for using the Cinema Booking System!");
        break;
    }
    else
    {
        Console.WriteLine("Invalid choice.");
    }
}