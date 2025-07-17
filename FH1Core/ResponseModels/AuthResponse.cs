namespace FH1Core.ResponseModels;

public class AuthResponse
{
    public string Token { get; set; } = string.Empty;
    public string UserId { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    // public string Roles { get; set; }
}
