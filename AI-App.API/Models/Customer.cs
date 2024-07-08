using System.ComponentModel.DataAnnotations;

namespace AI_App.API.Models;

public class Customer
{
    [Key]
    public int CustomerId { get; set; }
    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; }
    [Required]
    [MaxLength(50)]
    public string LastName { get; set; }
    [Required]
    [MaxLength(50)]
    public string Email { get; set; }
}