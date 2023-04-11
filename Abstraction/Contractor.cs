using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Contractor : Employee
    {

        double hourlyRate = 150;
        int hoursWorked;


        public Contractor (string theName , int hours)
        {
            this.name = theName;
            this.hoursWorked = hours;

        }
         
        
        public override double CalcSalary()
        {
            return hourlyRate * hoursWorked;
        }
    }
}
