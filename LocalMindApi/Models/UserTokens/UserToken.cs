using System;

namespace LocalMindApi.Models.UserTokens;

public class UserToken
{
    public string Token { get; set; }
    public string Username { get; set; }
    public  DateTimeOffset ExpirationDate { get; set; } 
}