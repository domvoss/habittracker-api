namespace HabitTracker.Application.DTOs
{
    public class HabitTaskDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public string Frequency { get; set; } = "Daily"; // e.g., Daily, Weekly todo: enum this
        public bool IsComplete { get; set; }
    }
}
