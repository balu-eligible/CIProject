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
            Program prog = new Program();
            Console.WriteLine(prog.TestMethod());
        }

        public string TestMethod()
        {
            return "Hey Watsup!";
        }
    }
}
