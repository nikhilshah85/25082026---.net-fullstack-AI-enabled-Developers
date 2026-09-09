using System;
using System.Collections.Generic;

namespace empAPP.DB;

public partial class Dept
{
    public int DeptNo { get; set; }

    public string? DeptName { get; set; }

    public string? DeptLocation { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
