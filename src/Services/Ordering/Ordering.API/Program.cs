using Ordering.API;
using Ordering.Application;
using Ordering.Infrastructure;
using Ordering.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services
    .AddApplicationServices(builder.Configuration)
    .AddInfrastructureServices(builder.Configuration)
    .AddApiServices(builder.Configuration);


var app = builder.Build();

app.UseApiServices();


if (app.Environment.IsDevelopment())
{
    await app.InitialiseDatabaseAsync();
}

// Configure the HTTP request pipeline.

app.Run();
