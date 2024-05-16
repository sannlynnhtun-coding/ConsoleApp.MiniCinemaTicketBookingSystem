namespace ConsoleApp.MiniCinemaTicketBookingSystem.Models;

public class Booking
{
    public Movie Movie { get; set; }
    public DateTime Showtime { get; set; }
    public int SeatNumber { get; set; }
    public string CustomerName { get; set; }

    public Booking(Movie movie, DateTime showtime, int seatNumber, string customerName)
    {
        Movie = movie;
        Showtime = showtime;
        SeatNumber = seatNumber;
        CustomerName = customerName;
    }
}