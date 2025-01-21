using Tariff_Comparison.Services;
using Tariff_Comparison.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register TariffProviderData as Singleton since it provides static data
builder.Services.AddSingleton<TariffProviderData>();
builder.Services.AddSingleton<TariffService>();

// Add this in the service configuration section
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

// Add this after app.UseAuthorization();
app.UseCors("AllowAll");

app.UseStaticFiles();

app.MapFallbackToFile("index.html");

app.MapControllers();

app.Run();
