using System;
using System.Collections.Generic;

namespace DBFirstApporch.Models;

public partial class TblBook
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? AuthorName { get; set; }
}
