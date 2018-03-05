using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double? lat = 13.6763482;
            double? lon = 100.7362492;

            
            Console.WriteLine($"{lat.Value.ToString("0.0000")}, {lon.Value.ToString("0.0000")}");
            Console.ReadLine();
        }

    }
}
