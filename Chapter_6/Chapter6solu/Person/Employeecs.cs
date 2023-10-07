using System;
using static System.Console;

namespace Packt.Shared
{
    public class Employee : Person
    {
        public string EmployeeCode { get; set; }
        public DateTime HireDate { get; set; }

        public new void WriteToConsole()
        {
            WriteLine("{0} was born on {1} and hire at {2}.",
                arg0: Name,
                arg1: DateOfBirth,
                arg2: HireDate);
        }

        public override string ToString()
        {
            return $"This is Employee: {Name}";
        }
    }
}