using System;
using System.Collections.Generic;

namespace dbSystem.Infra.Models;

public partial class UserSession
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string SessionToken { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime ExpiresAt { get; set; }

    public virtual User? User { get; set; }
}
