using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 6 };
            int sum = 0;
            foreach (int i in a)
                sum += i;
            Console.WriteLine(sum/3);

        }//output: 4
    }
}
