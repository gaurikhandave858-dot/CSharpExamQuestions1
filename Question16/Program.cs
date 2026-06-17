using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            for (int i = 1; i <=5; i++) 
                x = x + i;
            Console.WriteLine(x);
        }//Output: 16
    }
}
