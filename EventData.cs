namespace EventEase.Models;

public static class EventData
{
    public static IReadOnlyList<EventModel> All { get; } =
    [
        new() { Id = 1, Name = "Blazor Workshop", Date = DateTime.Today.AddDays(14), Location = "Innovation Hall", Description = "Build interactive web interfaces with Blazor." },
        new() { Id = 2, Name = "Community Meetup", Date = DateTime.Today.AddDays(21), Location = "Downtown Conference Center", Description = "Connect with developers and share project ideas." },
        new() { Id = 3, Name = "Front-End Showcase", Date = DateTime.Today.AddDays(30), Location = "Online", Description = "See student projects and modern UI techniques." }
    ];
}
