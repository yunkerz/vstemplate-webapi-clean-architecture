using MediatR;
using Rammstein15.Application.Common.Configuration;
using Rammstein15.Application.Common.Interfaces;
using Rammstein15.Infrastructure.Persistence.AzureBlobStorage;
using Rammstein15.Infrastructure.Persistence.AzureTableStorage;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Options - Configuration Settings
builder.Services.AddOptions();

var configBuilder = new ConfigurationBuilder();
if (builder.Environment.IsDevelopment())
{
    configBuilder.SetBasePath(Environment.CurrentDirectory);
    configBuilder.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
    configBuilder.AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true);
    configBuilder.AddEnvironmentVariables();
    configBuilder.AddUserSecrets<Program>();
}
else
{
    configBuilder.SetBasePath(Environment.CurrentDirectory);
    configBuilder.AddEnvironmentVariables();
}

var config = configBuilder.Build();

// AzureTableStorage Configuration Settings
builder.Services.AddOptions<AzureTableStorageSettings>().Configure<IConfiguration>((atss, config) =>
{
    atss.AzureStorageConnectionString = config["AzureStorageConnectionString"];
    atss.CustomerTableName = config["CustomerTableName"];
});

// AzureBlobStorage Configuration Settings
builder.Services.AddOptions<AzureBlobStorageSettings>().Configure<IConfiguration>((abss, config) =>
{
    abss.AzureStorageConnectionString = config["AzureStorageConnectionString"];
    abss.CustomerBlobContainerName = config["CustomerBlobContainerName"];
});

// Inject concrete instances of the interfaces
builder.Services.AddSingleton<IApplicationBlobStorage, AzureBlobStorageService>();
builder.Services.AddSingleton<IApplicationTableStorage, AzureTableStorageService>();

// MediatR
builder.Services.AddMediatR(typeof(Rammstein15.Application.Features.Customer.Queries.GetCustomerByCustomerIdQuery).Assembly);


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
