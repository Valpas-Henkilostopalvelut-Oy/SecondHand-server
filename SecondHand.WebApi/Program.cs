using SecondHand.Infrastructure.Models;
using SecondHand.Infrastructure.Repositories;
using SecondHand.Application.Interfaces;
using SecondHand.Application.Authentification;
using SecondHand.Domain.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<MongoDBSettings>(builder.Configuration.GetSection("MongoDB"));
builder.Services.Configure<JWTSettings>(builder.Configuration.GetSection("Jwt"));
builder.Services.Configure<AuthSettings>(builder.Configuration.GetSection("Auth"));

// Singletons
builder.Services.AddSingleton<CustomerRepo>();

// Scoped
builder.Services.AddScoped<IAuthentificationService, AuthentificationService>().AddScoped<JwtGenerator>().AddScoped<ICustomers, CustomerRepo>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
