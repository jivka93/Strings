using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParseTagsNew
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Console.WriteLine(Regex.Replace(text, "<upcase>(.*?)</upcase>", expression => expression.Groups[1].Value.ToUpper()));
        }
    }
}
