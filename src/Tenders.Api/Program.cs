using Tenders.Api.Application.QueryHandlers;
using Tenders.Api.Application.Services;
using Tenders.Api.Services;
using Tenders.Api.Contracts.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMemoryCache();
builder.Services.AddHttpClient();
builder.Services.AddHostedService<TendersCacheRefreshBackgroundService>();

builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(FilterTendersQueryHandler).Assembly);
});

builder.Services.AddSingleton<ICacheService, CacheService>();

var configuration = builder.Configuration;
builder.Services.Configure<TendersApiExternal>(configuration.GetSection("TendersApiExternal"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


public partial class Program { } //for integration tests purposes
