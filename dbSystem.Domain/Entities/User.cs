namespace dbSystem.Domain.Entities;

public class User
{
    public int id { get; set; }

    public string username { get; set; } = null!;

    public string email { get; set; } = null!;

    public string password_hash { get; set; } = null!;

    public bool is_active { get; set; } = true;

    public DateTime created_at { get; set; } = DateTime.UtcNow;

    public DateTime? updated_at { get; set; }
}