using System.ComponentModel.DataAnnotations;

namespace UserAPI.Models;

public class User
{
    [Key]
    public int Id { get; set; }
    public string Username { get; set; }
    public string Name { get; set; }
    public string PasswordHash { get; set; }
}