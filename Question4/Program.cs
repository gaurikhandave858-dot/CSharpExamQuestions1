using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = a++;
            Console.WriteLine(a + " " + b);
        }//Output: 6 5
    }
}
