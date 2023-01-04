using OpenTelemetry;
using OpenTelemetry.Logs;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//For tracing with OpenTelemetry
builder.Services.AddOpenTelemetry().WithTracing(b =>
{
    b.AddConsoleExporter()
    .AddOtlpExporter()
    .SetResourceBuilder(ResourceBuilder.CreateDefault())
    .AddAspNetCoreInstrumentation()
    .AddSqlClientInstrumentation();
}).StartWithHost();

// For logging with Ilogger and OpenTelemetry
builder.Logging.AddOpenTelemetry(b =>
{
    b.SetResourceBuilder(ResourceBuilder.CreateDefault())
    .AddConsoleExporter()
    .AddOtlpExporter();
});

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
