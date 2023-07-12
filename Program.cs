using BackProyTesis.Data;
using BackProyTesis.Logic;
using BackProyTesis.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var cadenaConexion = builder.Configuration.GetConnectionString("defaultConnection");

builder.Services.AddDbContext<context>(x =>
    x.UseOracle(
        cadenaConexion,
        options => options.UseOracleSQLCompatibility("11")
    )
);

// Agregar la configuraci�n para Cliente
builder.Services.AddScoped<Data_Cliente>();
builder.Services.AddScoped<Logic_Cliente>();

// Agregar la configuraci�n para CabFactura
builder.Services.AddScoped<Data_Encfac>();
builder.Services.AddScoped<Logic_Encfac>();

// Agregar la configuraci�n para Vehiculos
builder.Services.AddScoped<Data_Vehiculo>();
builder.Services.AddScoped<Logic_Vehiculo>();

// Agregar la configuraci�n para DetFactura
builder.Services.AddScoped<Data_Detfac>();
builder.Services.AddScoped<Logic_Detfac>();

// Agregar la configuraci�n para Empleado
builder.Services.AddScoped<Data_Empleado>();
builder.Services.AddScoped<Logic_Empleado>();

// Agregar la configuraci�n para Grupo
builder.Services.AddScoped<Data_GrupoRep>();
builder.Services.AddScoped<Logic_GrupoRep>();

// Agregar la configuraci�n para Articulo
builder.Services.AddScoped<Data_Articulo>();
builder.Services.AddScoped<Logic_Articulo>();

// Agregar la configuraci�n para Inventario
builder.Services.AddScoped<Data_Inventario>();
builder.Services.AddScoped<Logic_Inventario>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
  //  app.UseSwagger();
    //app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
