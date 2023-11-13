using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OurClass hr= new OurClass();
            hr.display(workingHours: 8, workingdays: 30);
            OurClass Admin=new OurClass();
            Admin.display(workingHours:8,workingdays:30,projecthandle:3);
            OurClass softwaredeveloper=new OurClass();
            softwaredeveloper.display(workingHours: 8, workingdays: 30, projecthandle: 4, extra: 5);
            Console.ReadKey();
        }
    }
}
