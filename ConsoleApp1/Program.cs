using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //計算數值的階乘10!
            int Ans = 1;
            for(int i = 10; i >= 1 ; i--)
            {
                Ans = Ans * i;
            }
            Console.WriteLine("10!=" + Ans);

        }
    }
}
