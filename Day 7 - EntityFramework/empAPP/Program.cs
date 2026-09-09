

using empAPP.DB;

EmployeeManagementNewDbContext db = new EmployeeManagementNewDbContext();

// var myDepts = from e in db.Depts
//             select e;

// foreach (var item in myDepts)
// {
//     Console.WriteLine(item.DeptNo + " " + item.DeptName);
// }

// var totalDept = (from e in db.Depts
//                 select e.DeptNo).Count();

//                 Console.WriteLine("Total Departments : " + 4);

// var allEmps = from e in db.Employees
//              orderby e.EmpDesignation
//              select e;
// foreach (var item in allEmps)
// {
//     Console.WriteLine(item.EmpNo + " " + item.EmpName + " " + item.EmpDesignation);
// }



Console.WriteLine("Enter empno to view details :");
int eno =Convert.ToInt32( Console.ReadLine());

var edetails = (from e in db.Employees
                where e.EmpNo == eno
                select e).Single();

Console.WriteLine(edetails.EmpNo);

Console.WriteLine(edetails.EmpName);

Console.WriteLine(edetails.EmpDesignation);

Console.WriteLine(edetails.EmpSalary);

Console.WriteLine(edetails.EmpIsPermenant);
    


