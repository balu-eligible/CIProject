using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    public class Program
    {
        static void Main(string[] args)
        {
            TestClass prog = new TestClass();

            Console.WriteLine(prog.ReturnResponse());
        }
    }
}
