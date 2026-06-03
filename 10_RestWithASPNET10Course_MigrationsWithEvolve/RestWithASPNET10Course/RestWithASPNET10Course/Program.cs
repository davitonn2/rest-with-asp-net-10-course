using RestWithASPNET10Course.Configurations;
using RestWithASPNET10Course.Repositories;
using RestWithASPNET10Course.Repositories.Impl;
using RestWithASPNET10Course.Services;
using RestWithASPNET10Course.Services.Impl;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDatabaseConfiguration(builder.Configuration);

builder.Services.AddScoped<IPersonServices, PersonServicesImpl>();

builder.Services.AddEvolveConfiguration(builder.Configuration, builder.Environment);

builder.Services.AddScoped<IPersonRepository, PersonRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
