using System;
using System.Collections.Generic;

namespace dbSystem.Infra.Models;

public partial class PasswordReset
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string ResetToken { get; set; } = null!;

    public DateTime ExpiresAt { get; set; }

    public bool? Used { get; set; }

    public virtual User? User { get; set; }
}
