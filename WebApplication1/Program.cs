
using DigitalWalletAPI; 

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSingleton<MathService>();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();

// Ендпоінт: GET /users
app.MapGet("/users", () =>
{
    return Results.Ok(new[] { "User A", "User B" });
});

// Ендпоінт: POST /users
app.MapPost("/users", (User userRequest) =>
{
    return Results.Created($"/users/{userRequest.Name}", userRequest);
});

app.Run();

// Допоміжний клас, який потрібен для POST /users
public class User
{
    public string Name { get; set; }
}