using System;
using System.Collections.Generic;

namespace dbSystem.Infra.Models;

public partial class UserToken
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string AccessToken { get; set; } = null!;

    public string RefreshToken { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime ExpiresAt { get; set; }

    public DateTime RefreshExpiresAt { get; set; }

    public bool? Revoked { get; set; }

    public virtual User? User { get; set; }
}
