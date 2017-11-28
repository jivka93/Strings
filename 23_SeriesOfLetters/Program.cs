using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append(input[0]);
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i - 1] != input[i])
                {
                    strBuilder.Append(input[i]);
                }
            }

            Console.WriteLine(strBuilder);
        }
    }
}
