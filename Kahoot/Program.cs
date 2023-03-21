using Microsoft.AspNetCore.SignalR.Client;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();


var connection = new HubConnectionBuilder()
    .WithUrl("https://example.com/quizhub")
    .Build();

await connection.StartAsync();

connection.Closed += async (error) =>
{
    // handle connection closed event
    await Task.Delay(new Random().Next(0,5) * 1000);
    await connection.StartAsync();
};

