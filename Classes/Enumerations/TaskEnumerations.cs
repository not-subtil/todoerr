namespace TodoErr.Classes.Enumerations;

public static class TaskEnumerations
{
				public enum Priority : ushort
				{
        Irrelevant = 0,
								Low = 1,
								Medium = 2,
								High = 3
				}

    public enum State : ushort
    {
        OnQueue = 0,
        Completed = 1,
        Overdue = 2,
    }
}
