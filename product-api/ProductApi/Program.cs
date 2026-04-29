using Microsoft.EntityFrameworkCore;
using ProductApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DbContext (SQLite simples)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=products.db"));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/", () => "API rodando");

app.Run();