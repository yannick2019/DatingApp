using System.ComponentModel.DataAnnotations;

namespace API.DTOs;

public class RegisterDto
{
    [Required]
    public string Username { get; set; } = null!;

    [Required]
    [StringLength(18, MinimumLength = 8)]
    public string Password { get; set; } = null!;
}
