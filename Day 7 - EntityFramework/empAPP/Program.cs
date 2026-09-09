

using empAPP.DB;

EmployeeManagementNewDbContext db = new EmployeeManagementNewDbContext();

#region select all employees
// var myDepts = from e in db.Depts
//             select e;

// foreach (var item in myDepts)
// {
//     Console.WriteLine(item.DeptNo + " " + item.DeptName);
// }
#endregion

#region - Aggregation
// var totalDept = (from e in db.Depts
//                 select e.DeptNo).Count();

//                 Console.WriteLine("Total Departments : " + 4);
#endregion

#region  - select with order by - sort operation
// var allEmps = from e in db.Employees
//              orderby e.EmpDesignation
//              select e;
// foreach (var item in allEmps)
// {
//     Console.WriteLine(item.EmpNo + " " + item.EmpName + " " + item.EmpDesignation);
// }
#endregion

#region - search an employee

// Console.WriteLine("Enter empno to view details :");
// int eno =Convert.ToInt32( Console.ReadLine());

// var edetails = (from e in db.Employees
//                 where e.EmpNo == eno
//                 select e).Single();

// Console.WriteLine(edetails.EmpNo);

// Console.WriteLine(edetails.EmpName);

// Console.WriteLine(edetails.EmpDesignation);

// Console.WriteLine(edetails.EmpSalary);

// Console.WriteLine(edetails.EmpIsPermenant);
    
#endregion

#region  - Add a new Employee

    //1st create a new employee
    // Employee newEmp = new Employee()
    // { EmpNo=13, 
    // EmpName="Allan", 
    // EmpDept=20,
    // EmpDesignation="Jr.Accountant", 
    // EmpIsPermenant=true, 
    // EmpSalary=3500};

    // db.Employees.Add(newEmp); //this is added in app memory, RAM
    // db.SaveChanges(); //push the changes we made in memory into database

    // Console.WriteLine("New Employee Added Successfully");




#endregion

#region - Delete an employee

// Console.WriteLine("please enter emp no to be deleted");
// int emp_To_delete = Convert.ToInt32(Console.ReadLine());

// //we do not have to read or select the emp, we just need to point to that emp
// var emp = db.Employees.FirstOrDefault(e => e.EmpNo == emp_To_delete); 

// if(emp != null)
// {
// db.Employees.Remove(emp);
// Console.WriteLine("Employee Deleted");
// }
// else
// {
//     Console.WriteLine("Employee with No : " + emp_To_delete + " Not found in system");
// }

// db.SaveChanges(); //push changes to database

#endregion

#region - update an employee

//update a single record
// var emp = db.Employees.FirstOrDefault(e => e.EmpNo == 10);

// emp.EmpName = "Prof." + emp.EmpName;
// emp.EmpSalary = emp.EmpSalary + 300;

// db.SaveChanges();
// Console.WriteLine("Employee Details updated");

//update salary for every employee
// var allemp = from e in db.Employees
//              select e;

//         foreach (var item in allemp)
//         {
//             item.EmpSalary = item.EmpSalary + 250;
//         }

// db.SaveChanges();
// Console.WriteLine("Salary of all the emplpyees are updated");

#endregion