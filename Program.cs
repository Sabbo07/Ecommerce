using Ecommerce.Data;
using Ecommerce.Repository.Customer;
using Ecommerce.Repository.CustomerDTO;
using Ecommerce.Repository.InformazioniDTO;
using Ecommerce.Repository.InformazioniDTO.GetAll;
using Ecommerce.Repository.InformazioniDTO.Update;
using Ecommerce.Repository.Listadeidesideri;
using Ecommerce.Repository.Shoes;
using Ecommerce.Repository.ShoesDTO;
using Ecommerce.Repository.Warehouseman;
using Ecommerce.Service;
using Ecommerce.Service.Carrello;
using Ecommerce.Service.Customer;
using Ecommerce.Service.CustomerDTO;
using Ecommerce.Service.DTOService;
using Ecommerce.Service.InformazioniDTO;
using Ecommerce.Service.InformazioniDTO.GetAll;
using Ecommerce.Service.InformazioniDTO.Update;
using Ecommerce.Service.Listadeidesideri;
using Ecommerce.Service.SerivizioScarpa;
using Ecommerce.Service.ServizoScarpa;
using Ecommerce.Service.Warehouseman;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configurazione del DbContext con MySQL
builder.Services.AddDbContext<EcommerceContext>(options =>
    options.UseMySql(
        "Server=127.0.0.1;Port=3306;Database=EcommerceDB;User=adminuser;Password=securepassword123;",
        new MySqlServerVersion(new Version(8, 0, 23))
    ));

// Aggiungi i controller e configura JSON per gestire i cicli di riferimento
builder.Services.AddControllersWithViews()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve; // Gestisce i cicli di riferimento
        options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull; // Ignora i valori null
    });

// Registrazione dei servizi e repository
builder.Services.AddScoped<IScarpaRepository, ScarpaRepository>();
builder.Services.AddScoped<IScarpaService, ScarpaService>();
builder.Services.AddScoped<IMagazziniereRepository, MagazziniereRepository>();
builder.Services.AddScoped<IMagazziniereService, MagazziniereService>();
builder.Services.AddScoped<IScarpaDTOService, ScarpaDTOService>();
builder.Services.AddScoped<IScarpaDTORepository, ScarpaDTORepository>();
builder.Services.AddScoped<ICarrelloService, CarrelloService>();
builder.Services.AddScoped<ICarrelloRepository, CarrelloRepository>(); 
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddScoped<IClienteDTORepository, ClienteDTORepository>();
builder.Services.AddScoped<IClienteDTOService, ClienteDTOService>();
builder.Services.AddScoped<IDTORepository, DTORepository>();
builder.Services.AddScoped<IDTOService, DTOService>();
builder.Services.AddScoped<IDTOUpdateService, DTOUpdateService>();
builder.Services.AddScoped<IDTOUpdateRepository, DTOUpdateRepository>();
builder.Services.AddScoped<IDTOGetAllRepository, DTOGetAllRepository>();
builder.Services.AddScoped<IDTOGetAllService, DTOGetAllService>();
builder.Services.AddScoped<ILLDService, LLDService>();
builder.Services.AddScoped<ILDDRepository, LDDRepository>();





// CORS Configuration
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder => builder.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader());
});


var app = builder.Build();

// Use CORS
app.UseCors("AllowAllOrigins");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    // Usa l'handler degli errori per l'ambiente di produzione
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // Usa HSTS per la sicurezza in produzione
}

app.UseHttpsRedirection();

// Serve i file statici (css, js, immagini, ecc.)
app.UseStaticFiles();

// Configura il routing
app.UseRouting();

// Configura l'autorizzazione (se è necessaria)
app.UseAuthorization();

// Mappa i controller
app.MapControllers();

// Endpoint di esempio per la previsione del tempo
var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();

// Definizione della classe WeatherForecast
record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
