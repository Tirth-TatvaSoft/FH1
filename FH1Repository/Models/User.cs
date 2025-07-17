using System;
using System.Collections.Generic;

namespace FH1Repository.Models;

public partial class User
{
    public Guid Id { get; set; }

    public string Email { get; set; } = null!;

    public string HashPassword { get; set; } = null!;

    public bool Isactive { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? RefreshToken { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
