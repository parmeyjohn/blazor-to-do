namespace habitTracker;

public class TodoItem
{
    public TodoItem(string title, int habitLength)
    {
        Title = title;
        IsPrivate = false;
        HabitLength = habitLength;
        CreationTime = DateTime.Now;
    }

    public string Title { get; set; }
    private bool IsPrivate { get; set; }
    private DateTime CreationTime { get; set; }
    public int HabitLength {  get; set; }

}