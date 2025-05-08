namespace WineLottery.Models;

public class Ticket
{
    public int TicketId { get; set; }
    public string? BuyerName { get; set; }
    public bool IsSold { get; set; }
    public int Price { get; set; } = 10;
}