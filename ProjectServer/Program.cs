using Microsoft.EntityFrameworkCore;
using ProjectServer.Model;
using ProjectServer.Model.Models;
using ProjectServer.Services;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddRazorPages();

builder.Services.AddCors();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//add my services
builder.Services.AddDIServices();


builder.Services.AddDbContext<ProjectLocalDBContext>();
//builder.Services.AddDbContext<DataContext>(options =>
//       options.UseSqlServer(builder.Configuration.GetConnectionString("WebApiDatabase")));
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



