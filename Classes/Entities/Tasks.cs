using System;
using static TodoErr.Classes.Enumerations.TaskEnumerations;

namespace TodoErr.Classes.Entities;

public class Tasks : Auditable
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public Priority Priority { get; set; }
    public State State { get; set; }
}
