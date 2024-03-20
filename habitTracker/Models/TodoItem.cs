namespace habitTracker;

public class TodoItem
{
    public TodoItem(string title)
    {
        Title = title;
        IsCompleted = false;
        IsPrivate = false;
    }

    public string Title { get; set; }
    public bool IsCompleted { get; set; }
    private bool IsPrivate { get; set; }

}