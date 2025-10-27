// Це файл: WebApplication1/Program.cs

using WebApplication1; // Додаємо, щоб проєкт "бачив" наш MathService

var builder = WebApplication.CreateBuilder(args);

// --- 1. Додаємо сервіси ---

// Додаємо наш MathService, щоб API могло ним користуватись
builder.Services.AddSingleton<MathService>();

// Додаємо сервіси для Swagger (це виконає Завдання 3, Варіант 1)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// --- 2. Налаштовуємо пайплайн ---

// Кажемо додатку використовувати Swagger
app.UseSwagger();
app.UseSwaggerUI();


// --- 3. Створюємо наші API-ендпоінти (для Завдання 3) ---

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

// --- 4. Запускаємо додаток ---
app.Run();
//1
//2
//3

// Допоміжний клас, який потрібен для POST /users
public class User
{
    public string Name { get; set; }
}