using System;
using System.Collections.Generic;

namespace EFDemo.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string FullName { get; set; } = null!;

    public string Department { get; set; } = null!;

    public string? Designation { get; set; }

    public decimal Salary { get; set; }

    public DateOnly? HireDate { get; set; }

    public string? City { get; set; }

    public bool? IsActive { get; set; }
}
