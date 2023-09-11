namespace mentAlly;

public class Chat
{
    public Guid UserId { get; set; }

    public DateTime TimeStamp { get; set; }

    public string? Message { get; set; }
}