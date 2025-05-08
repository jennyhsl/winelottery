using WineLottery.Models;

namespace WineLottery.Services;

public class TicketService : ITicketService
{
    readonly List<Ticket> _tickets = [];
    
    public TicketService()
    {
        // Simulate some tickets
        _tickets.AddRange([
            new Ticket { TicketId = 1, BuyerName = null, IsSold = false },
            new Ticket { TicketId = 2, BuyerName = "Alice", IsSold = true },
            new Ticket { TicketId = 3, BuyerName = null, IsSold = false }
        ]);
    }
    
    public List<Ticket> GetAllTickets() 
        => _tickets;

    public List<Ticket> GetAllAvailableTickets() 
        => _tickets.Where(s => s.IsSold == false).ToList();

    public Ticket? GetTicketById(int ticketId) 
        => _tickets.FirstOrDefault(t => t.TicketId == ticketId);

    public void CreateTicket(int ticketId)
    {
        if (_tickets.Any(t => t.TicketId == ticketId))
            throw new Exception($"Ticket with id {ticketId} already exists");
        
        var ticket = new Ticket
        {
            TicketId = ticketId,
            BuyerName = null,
            IsSold = false
        };
        
        _tickets.Add(ticket);
    }

    public void PurchaseTicket(int ticketId, string buyerName)
    {
        var ticket = GetTicketById(ticketId);
        
        if (ticket == null)
            throw new Exception($"Ticket with id {ticketId} not found.");
        if (ticket.IsSold)
            throw new Exception($"Ticket with id {ticketId} is already sold.");
        
        ticket.IsSold = true;
        ticket.BuyerName = buyerName;
    }
}