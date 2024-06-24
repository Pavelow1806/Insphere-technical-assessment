using Insphere.Global.Configuration;
using Insphere.Reader.Services.CsvReader;
using Insphere.Reader.Services.Reader;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();
builder.Services.AddScoped<ICsvReader, CsvReader>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<ReaderService>();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Initialise
AddressConfiguration.Initialise(
    _reader: app.Configuration["Addresses:Reader"],
    _api: app.Configuration["Addresses:API"]
);

app.Run();
