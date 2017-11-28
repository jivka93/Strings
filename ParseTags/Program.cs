using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            //string newText = string.Empty;

            string start = "<upcase>";
            string end = "</upcase>";

            while (true)
            {
                int check = text.IndexOf(start);
                if (check < 0)
                {
                    break;
                }
                int startIndex = text.IndexOf(start) + start.Length;
                int endIndex = text.IndexOf(end);
                // Part 1
                string firstPart = text.Substring(0, startIndex);
                //Part 2
                string upper = text.Substring(startIndex, endIndex - startIndex).ToUpper();  // length is less than zero
                //Part 3
                int lastPartIndex = endIndex + end.Length;
                string lastPart = text.Substring(lastPartIndex, text.Length - lastPartIndex);

                //text = firstPart + upper + lastPart;
                //newText += firstPart + upper + lastPart;
            }
            Console.WriteLine(text);
        }
    }
}
