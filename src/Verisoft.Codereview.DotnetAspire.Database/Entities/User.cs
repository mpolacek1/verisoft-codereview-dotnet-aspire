using System.ComponentModel.DataAnnotations;

namespace Verisoft.Codereview.DotnetAspire.Database.Entities;

public class User
{
    public Guid Id { get; set; }

    [MaxLength(128)]
    public required string Name { get; set; }

    [MaxLength(64)]
    public required string FirstName { get; set; }

    [MaxLength(64)]
    public required string LastName { get; set; }

    [MaxLength(300)]
    public string? Email { get; set; }

    [MaxLength(512)]
    public string? Description { get; set; }
}