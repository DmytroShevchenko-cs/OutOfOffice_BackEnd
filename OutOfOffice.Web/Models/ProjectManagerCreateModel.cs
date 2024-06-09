namespace OutOfOffice.Web.Models;

public class ProjectManagerCreateModel
{
    public string Login { get; set; } = null!;
    public string Password { get; set; } = null!;
    
    public string FullName { get; set; } = null!;
    public byte[]? Photo { get; set; }
}