namespace EventEase.Models;

public class AttendanceRecord
{
    public int Id { get; set; }
    public string AttendeeName { get; set; } = string.Empty;
    public bool IsPresent { get; set; }
}
