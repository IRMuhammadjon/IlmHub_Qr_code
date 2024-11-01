namespace IlmHub_Qr_code.Data.Models;

public class Student
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FathersName { get; set; }
    public string CourseName { get; set; }
    public DateTimeOffset StartDate { get; set; }
    public DateTimeOffset EndDate { get; set; } = DateTimeOffset.Now;
    public DateTimeOffset CheckingDate { get; set; } = DateTimeOffset.Now;
}
