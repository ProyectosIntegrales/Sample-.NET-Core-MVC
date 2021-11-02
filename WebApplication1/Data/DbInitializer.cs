using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public static class DbInitializer
    {
        public static void Initialize(myDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Employees.Any())
            {
                return;
            }

            var employees = new Employee[]
            {
                new Employee
                {
                    ID = 1,
                    EmployeeName = "John",
                    EmployeeLastname = "Smith",
                    EmployeeNumber = 1234
                },
                new Employee
                {
                    ID=2,
                    EmployeeName = "Joe",
                    EmployeeLastname = "Doe",
                    EmployeeNumber = 4323
                },
                new Employee
                {
                    ID=3,
                    EmployeeName = "Maria",
                    EmployeeLastname = "Ramos",
                    EmployeeNumber = 56778
                },
                new Employee
                {
                    ID = 4,
                    EmployeeName = "Gabriel",
                    EmployeeLastname = "Estrada",
                    EmployeeNumber = 4012
                }
            };

            foreach (Employee e in employees)
            {
                context.Add(e);
            }
            context.SaveChanges();
        }
    }
}
