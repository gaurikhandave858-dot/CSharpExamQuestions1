using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 3; i++)
                for (int j = 1; j <= 3; j++)
                    sum += i * j;
            Console.WriteLine(sum);
        }//Output: 36
    }
}
