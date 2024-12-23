using DotnetTranning.src.DB;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Enable Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); // Default UI at /swagger
}

app.MapGet("/", () => "Hello, Swagger!");

app.Run();


//http://localhost:5068/swagger/index.html