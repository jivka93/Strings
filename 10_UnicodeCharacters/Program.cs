using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //  OPTION 1
            StringBuilder strBuilder = new StringBuilder();
            foreach (char character in input)
            {
                strBuilder.AppendFormat("\\u{0:X4}", (uint)character);
            }
            Console.WriteLine(strBuilder);

            //  OPTION 2
    //        var chars = input.Select(character => (int)character).Select(character => @"\u{0:x4}",character);
    //        Console.WriteLine(string.Concat(chars));

        }
    }
}
