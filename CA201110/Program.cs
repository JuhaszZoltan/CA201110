using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201110
{
    class Program
    {
        static void Main()
        {
            var sw = new StreamWriter(@"proba.txt");
            sw.WriteLine("Hello World!\nZoli vagyok!\nSzeretem a csincsillákat!");
            Console.WriteLine("kész");
            sw.Close();
            Console.ReadKey();
        }
    }
}
