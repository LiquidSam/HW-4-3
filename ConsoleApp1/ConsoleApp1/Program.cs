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
            string alpha = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < alpha.Length; i++)
            {
                Console.Write(alpha[alpha.Length - i - 1]);
            }
        }
    }
}
