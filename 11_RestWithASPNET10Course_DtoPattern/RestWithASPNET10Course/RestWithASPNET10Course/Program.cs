using RestWithASPNET10Course.Configurations;
using RestWithASPNET10Course.Repositories;
using RestWithASPNET10Course.Repositories.Impl;
using RestWithASPNET10Course.Services;
using RestWithASPNET10Course.Services.Impl;
using RestWithASPNET10Erudio.Services;

var builder = WebApplication.CreateBuilder(args);

builder.AddSerilogLogging();

builder.Services.AddControllers();

builder.Services.AddDatabaseConfiguration(builder.Configuration);
builder.Services.AddEvolveConfiguration(builder.Configuration, builder.Environment);

builder.Services.AddScoped<IPersonServices, PersonServicesImpl>();
builder.Services.AddScoped<IBookServices, BookServicesImpl>();

builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run(); ();
