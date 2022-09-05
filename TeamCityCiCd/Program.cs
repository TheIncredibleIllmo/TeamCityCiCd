using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c=>c.SwaggerDoc("v1", new OpenApiInfo { Title="WeatherForecast.API", Version="v1", Description="Test"}));

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(c=>c.SwaggerEndpoint("v1/swagger.json", "WeatherForecast API V1"));

app.UseAuthorization();

app.MapControllers();

app.Run();
