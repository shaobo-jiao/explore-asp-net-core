using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models;

public class GuestResponse
{
    [Required(ErrorMessage = "Please enter your name")]
    public string? Name { get; set; }
    
    [Required(ErrorMessage = "Please enter your email address")]
    [EmailAddress]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Please enter your phone number")]
    public string? Phone { get; set; }

    [Required(ErrorMessage = "Please specify whether you will attend")]
    public bool? WillAttend { get; set; }

    public override string ToString()
    {
        return $"Name = {Name}, Email = {Email}, Phone = {Phone}, Will Attend? = {WillAttend}";
    }
}
