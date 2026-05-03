using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    abstract class EmployeeBase
    {
        protected int Id;
        protected string? Name;
        protected int Age;
        internal protected void Test()
        {

        }
    }

    class FullTimeEmployee : EmployeeBase
    {

        public decimal Salary;
    }

    class PartTimeEmployee : EmployeeBase
    {

        public decimal HourRate;
    }
}
