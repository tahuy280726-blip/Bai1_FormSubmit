namespace Bai1_FormSubmit.Models;

public class AccountViewModel
{
    public string Username { get; set; } = "";
    public string Password { get; set; } = "";
    public string? Message { get; set; }
    public bool IsSuccess { get; set; }
}
