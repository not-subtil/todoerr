using System;

namespace TodoErr.Classes.Entities;

public class Auditable
{
    public Guid Id { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }

    public Auditable()
    {
        Id = new Guid();
        Created = DateTime.Now;
        Modified = DateTime.Now;
    }
}
