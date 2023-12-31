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

// Agregar la configuración para Cliente
builder.Services.AddScoped<Data_Cliente>();
builder.Services.AddScoped<Logic_Cliente>();

// Agregar la configuración para CabFactura
builder.Services.AddScoped<Data_Encfac>();
builder.Services.AddScoped<Logic_Encfac>();

// Agregar la configuración para Vehiculos
builder.Services.AddScoped<Data_Vehiculo>();
builder.Services.AddScoped<Logic_Vehiculo>();

// Agregar la configuración para DetFactura
builder.Services.AddScoped<Data_Detfac>();
builder.Services.AddScoped<Logic_Detfac>();

// Agregar la configuración para Empleado
builder.Services.AddScoped<Data_Empleado>();
builder.Services.AddScoped<Logic_Empleado>();

// Agregar la configuración para Grupo
builder.Services.AddScoped<Data_GrupoRep>();
builder.Services.AddScoped<Logic_GrupoRep>();

// Agregar la configuración para Articulo
builder.Services.AddScoped<Data_Articulo>();
builder.Services.AddScoped<Logic_Articulo>();

// Agregar la configuración para Inventario
builder.Services.AddScoped<Data_Inventario>();
builder.Services.AddScoped<Logic_Inventario>();

// Agregar la configuración para InvVehiculo
builder.Services.AddScoped<Data_InvVeh>();
builder.Services.AddScoped<Logic_InvVeh>();

// Agregar la configuración para Servicios
builder.Services.AddScoped<Data_Servicios>();
builder.Services.AddScoped<Logic_Servicios>();

// Agregar la configuración para Cab Ord Trab
builder.Services.AddScoped<Data_CabOrdTrab>();
builder.Services.AddScoped<Logic_CabOrdTrab>();

// Agregar la configuración para Det Ser
builder.Services.AddScoped<Data_DetOrdSer>();
builder.Services.AddScoped<Logic_DetOrdSer>();

// Agregar la configuración para Det Inv
builder.Services.AddScoped<Data_DetOrdInv>();
builder.Services.AddScoped<Logic_DetOrdInv>();

// Agregar la configuración para Usuario
builder.Services.AddScoped<Data_Usuario>();
builder.Services.AddScoped<Logic_Usuario>();

// Agregar la configuración para Color
builder.Services.AddScoped<Data_Colores>();
builder.Services.AddScoped<Logic_Color>();

// Agregar la configuración para Marca
builder.Services.AddScoped<Data_Marcas>();
builder.Services.AddScoped<Logic_Marca>();

builder.Services.AddControllers();

// Configuración de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin", builder =>
    {
        builder.AllowAnyOrigin()  // Permitir cualquier origen
               .AllowAnyMethod()  // Permitir cualquier método (GET, POST, etc.)
               .AllowAnyHeader(); // Permitir cualquier encabezado HTTP
    });
});

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

// Usar CORS (debe estar antes de UseAuthorization y MapControllers)
app.UseCors("AllowOrigin");

app.UseAuthorization();

app.MapControllers();

app.Run();
