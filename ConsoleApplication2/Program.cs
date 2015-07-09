using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassLibrary2.Class1 c = new ClassLibrary1.Class1().GetFromClassLibrary2();
        }
    }
}
