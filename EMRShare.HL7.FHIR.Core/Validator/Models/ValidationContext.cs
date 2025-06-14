public class ValidationContext
{
    public string? UserId { get; set; }
    public string? Source { get; set; } // API, BatchJob, etc.
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    public string? DocumentId { get; set; }
    public string? ResourceType { get; set; }
}