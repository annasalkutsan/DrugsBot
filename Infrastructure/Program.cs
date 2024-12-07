using Infrastructure.Dal;
using Infrastructure.Dal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<DataBaseSettings>(builder.Configuration.GetSection("DataBaseSettings"));

builder.Services.AddDbContext<DrugsBotDbContext>((serviceProvider, options) =>
{
    var databaseSettings = serviceProvider.GetRequiredService<IOptions<DataBaseSettings>>().Value;
    options.UseNpgsql(databaseSettings.ConnectionString, npgsqlOptions =>
    {
        npgsqlOptions.CommandTimeout(databaseSettings.CommandTimeout);
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
