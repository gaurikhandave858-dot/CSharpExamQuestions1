using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            for (int i = 1;i <=5;i++)
            {
                if (i % 2 == 0)
                    
                    continue;
                
                    x = x + i;
                
                
            }
            Console.WriteLine(x);

        }//Output: 9
    }
}
