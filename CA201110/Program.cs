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
            var sr = new StreamReader(@"..\..\Res\diakok.txt", Encoding.UTF8);

            int lc = 0;
            int hSum = 0;
            while (!sr.EndOfStream)
            {
                lc++;
                hSum += int.Parse(sr.ReadLine().Split(' ')[2]);
            }

            Console.WriteLine("diákkok száma: " + lc);
            Console.WriteLine($"átlagmagasság: {hSum / (float)lc} cm");

            sr.Close();
            Console.ReadKey();
        }
    }
}
