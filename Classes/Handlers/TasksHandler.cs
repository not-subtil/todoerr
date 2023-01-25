using System;
using System.Collections.Generic;
using TodoErr.Classes.Entities;

namespace TodoErr.Classes.Handlers;

public static class TasksHandler
{
    public static List<Tasks>? Data { get; private set; }

    public static void SetSample()
    { 
        Data = new();

        Data.Add(new Tasks() { Name = "Develop front end", Start = DateTime.Now, End = new DateTime(2030, 10, 10) });
        Data.Add(new Tasks() { });
        Data.Add(new Tasks() { });
        Data.Add(new Tasks() { });
        Data.Add(new Tasks() { });
        Data.Add(new Tasks() { });
    }
}
