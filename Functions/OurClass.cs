using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class OurClass
    {
        public void display(int workingHours=8,int workingdays=8,int projecthandle=0,int extra=0)
        {
            int result = workingHours * workingdays * 100 + projecthandle * 3000 + extra * 2000;
            Console.WriteLine("Month Salary of Employee:\t"+result);
        }
    }
}
