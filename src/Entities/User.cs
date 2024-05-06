using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Enums;

namespace sda_onsite_2_csharp_backend_teamwork.src.Entities;

[Index(nameof(Email), IsUnique = true)]

public class User
{
    public Guid Id { get; set; }
    [Required]
    public string FullName { get; set; }
    [Required, EmailAddress]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
    public string CountryCode { get; set; }
    public string Phone { get; set; }
    [Required]
     public Role Role { get; set; } = Role.Customer;
}