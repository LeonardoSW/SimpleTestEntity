using Microsoft.EntityFrameworkCore;
using TesteEntity.Domain.DTOs.InterfacesRepositories;
using TesteEntity.Domain.DTOs.InterfacesRepositories.InterfacesServices;
using TesteEntity.Repository.Context;
using TesteEntity.Repository.Repositories;
using TesteEntity.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DbContextConfiguring
builder.Services.AddDbContextPool<AppDbContext>(options => options.UseNpgsql("Server=127.0.0.1;Port=5432;Database=openManagement;User Id=postgres;Password=Jesusmylife1*;"));
builder.Services.AddTransient<IProductsRepository, ProductsRepository>();
builder.Services.AddTransient<IProductsService, ProductsServices>();


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
