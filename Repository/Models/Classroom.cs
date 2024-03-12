using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Classroom
{
    public string ClassroomId { get; set; } = null!;

    public int Month { get; set; }

    public int Week { get; set; }

    public int? ActivityPoints { get; set; }

    public int? MinusPoints { get; set; }
}
