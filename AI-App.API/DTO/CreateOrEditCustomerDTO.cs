using System.ComponentModel.DataAnnotations;
namespace AI_App.API.DTO;

public class CreateOrEditCustomerDTO
{
    [Required] [MaxLength(50)] public string FirstName { get; set; } = null!;
    [Required] [MaxLength(50)] public string LastName { get; set; } = null!;
    [Required] [MaxLength(100)] public string Email { get; set; } = null!;
}