using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceTagsNew
{
    class Program
    {
        static void Main(string[] args)
        {
            // Replace all the tags <a href="URL">TEXT</a> with [TEXT](URL).

            string input = Console.ReadLine();
            string output = Regex.Replace(input, "(<a href=\")(.*?)(\">)(.*?)(</a>)", "[$4]($2)");
            Console.WriteLine(output);

        }
    }
}
