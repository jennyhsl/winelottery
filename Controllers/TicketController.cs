using Microsoft.AspNetCore.Mvc;
using WineLottery.Dtos;
using WineLottery.Services;

namespace WineLottery.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TicketController : Controller
{
    readonly ITicketService _ticketService;
    
    public TicketController(ITicketService ticketService)
    {
        _ticketService = ticketService;
    }
    
    [HttpGet]
    public IActionResult GetAllTickets()
    {
        var tickets = _ticketService.GetAllTickets();
        return Ok(tickets);
    }
    
    [HttpGet("available")]
    public IActionResult GetAllAvailableTickets()
    {
        var tickets = _ticketService.GetAllAvailableTickets();
        return Ok(tickets);
    }
    
    // her burde id'en inkremeres automatisk, men for enkelthetens skyld blir det en parameter
    [HttpPost("create")]
    public IActionResult CreateTicket(int ticketId)
    {
        try
        {
            _ticketService.CreateTicket(ticketId);
            return Ok($"Ticket {ticketId} successfully created");
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    
    /// <summary>
    /// Purchase a wine lottery ticket.
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    [HttpPost("purchase")]
    public IActionResult PurchaseTicket([FromBody] PurchaseTicketDto ticket)
    {
        if (ticket == null)
            return BadRequest("Ticket cannot be null");

        try
        {
            _ticketService.PurchaseTicket(ticket.TicketId, ticket.BuyerName);
            return Ok($"Ticket {ticket.TicketId} successfully purchased by {ticket.BuyerName}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest(e.Message);
        }
    }
}