using System.ComponentModel.DataAnnotations;

namespace LocalMindApi.Models;

public class UserCredential
{
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
}