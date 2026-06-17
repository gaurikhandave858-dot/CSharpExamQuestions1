using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question21
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x =5, y =10;
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine(x+" "+y);
        }//Output: 10 5
    }
}
