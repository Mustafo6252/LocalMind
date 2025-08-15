using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace LocalMindApi.Models.Users;

public class User
{
    [Key]
    [Required]
    public Guid Id { get; set; }
    [Required]
    public string Username { get; set; } 
    public string Password { get; set; }
    [MaxLength(50)]
    [Required]
    public string FirstName { get; set; }
    [MaxLength(50)]
    [Required]
    public string LastName { get; set; }
    [Required]
    public string PhoneNumber { get; set; }
    public Role Role { get; set; }
    public DateTimeOffset CreatedDate { get; set; }
    public DateTimeOffset UpdatedDate   { get; set; }
    
    public UserAdditionalDetails UserAdditionalDetails { get; set; }
}

public enum Role
{
    Admin,
    Student
}   