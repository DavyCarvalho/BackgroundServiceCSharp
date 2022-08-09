using BackgroundServiceExample.Data;
using BackgroundServiceExample.Data.Interfaces;
using BackgroundServiceExample.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using PlatformService.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(opt =>
                opt.UseInMemoryDatabase("InMem"));
builder.Services.AddScoped<IBackgroundProccessRepository, BackgroundProccessRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddControllers();
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

PrepDb.PrepPopulation(app);

app.MapControllers();

app.Run();
