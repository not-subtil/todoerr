using System;
using System.Collections.Generic;
using TodoErr.Classes.Entities;
using TodoErr.Classes.Enumerations;

namespace TodoErr.Classes.Handlers;

public static class TasksHandler
{
    public static List<Tasks>? Data { get; private set; }



    #region Just for testing
    public static void SetSample()
    {
        Data = new()
        {
            new Tasks()
            {
                Name = "Develop front end",
                Start = DateTime.Now,
                End = new DateTime(2030, 10, 10),
                Priority = TaskEnumerations.Priority.Irrelevant
            },
            new Tasks() {
                Name = "Develop rest call",
                Start = DateTime.Now,
                Priority = TaskEnumerations.Priority.Medium,
                End = new DateTime(2030, 10, 10)
            },
            new Tasks() {
                Name = "Attend weekly meeting",
                Start = DateTime.Now,
                Priority = TaskEnumerations.Priority.High,
                End = new DateTime(2030, 10, 10)
            }
        };
    }
    #endregion
}
