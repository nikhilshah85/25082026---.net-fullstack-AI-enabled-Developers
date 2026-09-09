using System;
using System.Collections.Generic;

namespace empAPP.DB;

public partial class Employee
{
    public int EmpNo { get; set; }

    public string? EmpName { get; set; }

    public string? EmpDesignation { get; set; }

    public int? EmpSalary { get; set; }

    public bool? EmpIsPermenant { get; set; }

    public int? EmpDept { get; set; }

    public virtual Dept? EmpDeptNavigation { get; set; }
}
