using L.Violations;
using System;
using System.Collections.Generic;

namespace L
{
    public static class LiskovRunner
    {
        public static void Run()
        {
            var employees = new List<Employee> { new Employee(), new Manager() };

            foreach (var employee in employees)
            {
                if (employee is Manager)
                    Console.WriteLine("Manager");
            }
        }
    }
}
