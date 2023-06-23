﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department_2
{
    internal class Department
    {
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; }

        public void AddEmployee(Employee employee) => Employees.Add(employee);
    }
}