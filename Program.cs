using WineLottery.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ITicketService,TicketService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();
app.MapControllers();
app.Run();
