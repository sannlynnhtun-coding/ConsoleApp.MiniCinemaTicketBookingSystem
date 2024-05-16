namespace ConsoleApp.MiniCinemaTicketBookingSystem.Models;

public class Movie
{
    public string Title { get; set; }
    public string Description { get; set; }
    public List<DateTime> Showtimes { get; set; }
    public int Seats { get; set; }
    public int AvailableSeats { get; set; }

    public Movie(string title, string description, List<DateTime> showtimes, int seats)
    {
        Title = title;
        Description = description;
        Showtimes = showtimes;
        Seats = seats;
        AvailableSeats = seats;
    }
}