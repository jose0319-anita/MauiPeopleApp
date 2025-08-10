namespace MauiPeopleApp.Models;

public class Person
{
    public int Id { get; set; }
    public string Email { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Avatar { get; set; } = string.Empty;

    public string FullName => $"{FirstName} {LastName}";
}
