using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Need to specify name and Salary of employee
            FulltimeEmployee ft = new FulltimeEmployee("Smith",12000);
            Contractor c = new Contractor("John", 38);
            Console.WriteLine(ft.PrintData());  
            Console.WriteLine(c.PrintData());
            Console.Read();

        }
    }
}
