using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppRegex
{
    public class Program
    {
        static void Main(string[] args)
        {
            Method c= new Method();
            c.Count();
            c.Email();
            c.Mobile();
            c.Display();

            Console.ReadKey();
        }
    }
}
