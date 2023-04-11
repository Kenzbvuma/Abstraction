using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class FulltimeEmployee : Employee 
    {
        //Declaring properties 
        double salary;
        

        public override double CalcSalary()

        {
            return salary;
        }
        /* Create a constructor that takes the 
         * name and salary*/
        public FulltimeEmployee (string theName , double theSal)

        {
            this.name = theName;
            this.salary = theSal;
        }
       
    }
}
