using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] array = new char[20];

            for (int i = 0; i < 20; i++)
            {
                if (input.Length == 20)
                {
                    array[i] = input[i];
                    Console.Write(array[i]);
                }
                else
                {
                    if (i < input.Length)
                    {
                        array[i] = input[i];
                        Console.Write(array[i]);
                    }
                    else
                    {
                        array[i] = '*';
                        Console.Write(array[i]);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
