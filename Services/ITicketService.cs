using WineLottery.Models;

namespace WineLottery.Services;

public interface ITicketService
{
    public List<Ticket> GetAllTickets();
    public List<Ticket> GetAllAvailableTickets();
    public Ticket? GetTicketById(int ticketId);
    public void CreateTicket(int ticketId);
    public void PurchaseTicket(int ticketId, string buyerName);
}