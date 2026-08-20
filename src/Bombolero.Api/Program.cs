using Microsoft.EntityFrameworkCore;
using Bombolero.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// database configuration
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<BomboleroDbContext>(options => 
        options.UseNpgsql(connectionString));

// Add services to the container.
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

app.Run();