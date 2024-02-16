using Microsoft.EntityFrameworkCore;
using Verisoft.Codereview.DotnetAspire.Database;
using Verisoft.Codereview.DotnetAspire.ServiceDefaults;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire components.
builder.AddNpgsqlDbContext<AppDbContext>(Constants.DatabaseName);

builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddProblemDetails();

var app = builder.Build();

var scopeFactory = app.Services.GetService<IServiceScopeFactory>();
if (scopeFactory is not null)
{
    using var scope = scopeFactory.CreateScope();
    var context = scope.ServiceProvider.GetService<AppDbContext>();
    var canContinue = false;
    while (context is not null && !canContinue)
    {
        try
        {
            await context.Database.MigrateAsync();
            canContinue = true;
        }
        catch (Exception)
        {
            canContinue = false;
        }
    }
}

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

app.MapGet("/users", (AppDbContext dbContext) => dbContext.Users.ToArrayAsync());

app.MapDefaultEndpoints();

app.Run();