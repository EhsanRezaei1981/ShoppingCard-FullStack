using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Shopping_Card_Api.Options;
using Entities;

var builder = WebApplication.CreateBuilder(args);
builder.Services.ConfigureOptions<DatabaseOptionsSetup>();

builder.Services.AddDbContext<DatabaseContext>((serviceProvider, dbCOB) =>
{
    var databaseOptions = serviceProvider.GetService<IOptions<DatabaseOptions>>()?.Value;
    dbCOB.UseSqlServer(databaseOptions?.ConnectionString, sqlServerAction =>
    {
        sqlServerAction.EnableRetryOnFailure(databaseOptions?.MaxRetryCount ?? 3);
        sqlServerAction.CommandTimeout(databaseOptions?.CommandTimeout ?? 30);
        sqlServerAction.MigrationsAssembly("Launcher");
    });
    dbCOB.EnableDetailedErrors(databaseOptions?.EnableDetailedErrors ?? false);
    dbCOB.EnableSensitiveDataLogging(databaseOptions?.EnableSensitiveDataLogging ?? false);
});

// Add services to the container.

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
