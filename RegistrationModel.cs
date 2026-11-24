using System.ComponentModel.DataAnnotations;

namespace EventEase.Models;

public class RegistrationModel
{
    [Required, StringLength(60, MinimumLength = 2)]
    public string FullName { get; set; } = string.Empty;

    [Required, EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    public int? EventId { get; set; }

    [Range(typeof(bool), "true", "true", ErrorMessage = "You must accept the attendance policy.")]
    public bool AcceptPolicy { get; set; }
}
