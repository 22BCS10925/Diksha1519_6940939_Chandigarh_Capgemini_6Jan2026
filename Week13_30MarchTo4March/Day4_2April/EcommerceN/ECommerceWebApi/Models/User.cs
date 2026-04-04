using Microsoft.EntityFrameworkCore;
namespace ECommerceWebApi.Models;
public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public UserProfile? Profile { get; set; }
}

public class UserProfile
{
    public int Id { get; set; }
    public string? Address { get; set; }

    public int UserId { get; set; }
    public User? User { get; set; }
}
