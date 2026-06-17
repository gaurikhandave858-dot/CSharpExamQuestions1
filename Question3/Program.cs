using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            for (int i = 0; i < 3; i++)
            
                x += x;
            
            Console.WriteLine(x);
        }
    }
}
