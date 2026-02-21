using EventRegistrationAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<EventService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("_myAllowSpecificOrigins", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseRouting();

// Enable CORS right here
app.UseCors("_myAllowSpecificOrigins");

// ❌ REMOVE HTTPS REDIRECTION
// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();