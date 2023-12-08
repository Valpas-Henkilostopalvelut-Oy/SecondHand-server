using SecondHand.Infrastructure.Models;
using SecondHand.Infrastructure.Repositories;
using SecondHand.Application.Interfaces;
using SecondHand.Application.Authentification;
using SecondHand.Domain.Interfaces;
using SecondHand.Application.Services;

var builder = WebApplication.CreateBuilder(args);

// Add AutoMapper DI
builder.Services.AddAutoMapper(typeof(Program).Assembly);

// Add services to the container.
builder.Services.Configure<MongoDBSettings>(builder.Configuration.GetSection("MongoDB"));
builder.Services.Configure<JWTSettings>(builder.Configuration.GetSection("Jwt"));
builder.Services.Configure<AuthSettings>(builder.Configuration.GetSection("Auth"));

// Singletons
builder.Services.AddSingleton<CustomerRepo>();

// Scoped
builder.Services
    .AddScoped<JwtGenerator>()

    .AddScoped<ICustomers, CustomerRepo>()
    .AddScoped<ICustomersService, CustomersService>()

    .AddScoped<IAuthentificationService, AuthentificationService>()

    .AddScoped<IBusinesses, BusinessRepo>()
    .AddScoped<IBusinessesService, BusinessesService>()

    .AddScoped<IImages, ImageRepo>()
    .AddScoped<IImagesService, ImagesService>()

    .AddScoped<INotes, NoteRepo>()
    .AddScoped<INotesService, NotesService>()

    .AddScoped<IOpeningHours, OpeningHoursRepo>()
    .AddScoped<IOpeningHoursService, OpeningHoursService>()

    .AddScoped<IOrders, OrderRepo>()
    .AddScoped<IOrdersService, OrdersService>()

    .AddScoped<ISocials, SocialRepo>()
    .AddScoped<ISocialService, SocialService>()

    .AddScoped<ILocations, LocationRepo>()
    .AddScoped<ILocationsService, LocationService>()

    .AddScoped<ICategories, CategoryRepo>()
    .AddScoped<ICategoriesService, CategoriesService>();

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
