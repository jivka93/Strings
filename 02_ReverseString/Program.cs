using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int length = input.Length;

            StringBuilder outputBuilder = new StringBuilder();

            for (int i = length - 1; i >= 0; i--)
            {
                outputBuilder.Append(input[i]);
            }

            Console.WriteLine(outputBuilder);
        }
    }
}
