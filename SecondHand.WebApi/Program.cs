using SecondHand.Infrastructure.Models;
using SecondHand.Infrastructure.Repositories;
using SecondHand.Application.Interfaces;
using SecondHand.Application.Authentification;
using SecondHand.Domain.Interfaces;
using SecondHand.Application.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using SecondHand.WebApi.Middleware;

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
    .AddScoped<JwtVerifier>()

    .AddScoped<ICustomers, CustomerRepo>()
    .AddScoped<ICustomersService, CustomersService>()

    .AddScoped<IAuthentificationService, AuthentificationService>()

    .AddScoped<IBusinesses, BusinessRepo>()
    .AddScoped<IBusinessesService, BusinessesService>()

    .AddScoped<IImages, ImageRepo>()
    .AddScoped<IImagesService, ImagesService>()

    .AddScoped<IOrders, OrderRepo>()
    .AddScoped<IOrdersService, OrdersService>()

    .AddScoped<ICategories, CategoryRepo>()
    .AddScoped<ICategoriesService, CategoriesService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        Description = "Bearer token authentication",
        Name = "Authentication",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey
    });
    options.OperationFilter<SecurityRequirementsOperationFilter>();
});

// add policy based requirement handler to service
builder.Services.AddSingleton<ErrorHandlerMiddleware>();

// Config the authentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("wadssswaaswwfdxveS11wwdcjdieiw2-dwisjsjjw2")),
            ValidateIssuer = true,
            ValidIssuer = "r4nd0m1ssu3rk3y",
            ValidateAudience = true,
            ValidAudience = "r4nd0m4ud13nc3",
        };
    });

builder.Logging.AddConsole();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication(); // Use authentication before authorization
app.UseAuthorization();

//app.UseMiddleware<ErrorHandlerMiddleware>(); // Add your error handling middleware

app.MapControllers();

app.Run();
