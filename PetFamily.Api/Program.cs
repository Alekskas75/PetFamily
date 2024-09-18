using Microsoft.EntityFrameworkCore;
using PetFamily.Infrastructure.Data;
using Serilog.Events;
using Serilog;
using PetFamily.Api;
using PetFamily.Application;
using PetFamily.Infrastructure;
using PetFamily.Api.Extensions;
using PetFamily.Api.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.ConfigureLogging();

builder.Services
    .AddApi()
    .AddApplication()
    .AddInfrastructure(builder.Configuration);

var app = builder.Build();

app.UseExceptionMiddleware();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    await app.ApplyMigration();
}

app.UseSerilogRequestLogging();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();