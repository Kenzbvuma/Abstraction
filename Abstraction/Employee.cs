using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal abstract class Employee
    {
        protected string name;
        //Abstract method
        // You cannot have curly braces for an abstract method
        public abstract double CalcSalary();
        //Normal method
        public string PrintData()
        {
            return $"Name: {name}\nSalary: {CalcSalary().ToString("C2")}\n";

        }
    }
}
