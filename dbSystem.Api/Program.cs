using dbSystem.Application.Interfaces;
using dbSystem.Application.UseCases.Users;
using dbSystem.Infrastructure.Persistence;
using dbSystem.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using dotenv.net;

var builder = WebApplication.CreateBuilder(args);

// Cargar variables desde el archivo .env
DotEnv.Load();

// Configurar variables de entorno en la configuración
builder.Configuration.AddEnvironmentVariables();

// Leer la cadena de conexión desde la configuración
var connectionString = builder.Configuration.GetConnectionString("Postgres");

Console.WriteLine($"Cadena de conexión utilizada: {connectionString}");

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString)
           .EnableSensitiveDataLogging()  // Habilitar logs detallados
           .LogTo(Console.WriteLine));   // Registrar logs en consola



// Inyección de dependencias
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<GetUserByEmailUseCase>();


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
