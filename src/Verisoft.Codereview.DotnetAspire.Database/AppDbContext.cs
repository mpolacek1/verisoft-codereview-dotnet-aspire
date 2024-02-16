using Bogus;
using Microsoft.EntityFrameworkCore;
using Verisoft.Codereview.DotnetAspire.Database.Entities;

namespace Verisoft.Codereview.DotnetAspire.Database;

public sealed class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        Randomizer.Seed = new(111);
        var faker = new Faker<User>("cz").RuleFor(r => r.Id, f => f.Random.Guid())
            .RuleFor(r => r.Name, f => f.Person.UserName)
            .RuleFor(r => r.FirstName, f => f.Person.FirstName)
            .RuleFor(r => r.LastName, f => f.Person.LastName)
            .RuleFor(r => r.Email, f => f.Person.Email.OrNull(f))
            .RuleFor(r => r.Description, f => f.Rant.Review().OrNull(f));

        modelBuilder.Entity<User>().HasData(faker.Generate(50));
    }
}