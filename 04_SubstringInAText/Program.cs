using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstringInAText
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();

            int firstOccurance = text.IndexOf(pattern);
            int lastOccurance = text.LastIndexOf(pattern);

            int occurances = 0;

            if (lastOccurance > firstOccurance)
            {
                while (true)
                {
                    int currentOccurance = text.IndexOf(pattern);
                    occurances++;
                    if (currentOccurance == text.LastIndexOf(pattern))
                    {
                        break;
                    }
                    int currentIndex = text.IndexOf(pattern) + pattern.Length;
                    text = text.Substring(currentIndex);
                }
            }
            else
            {
                if (firstOccurance >= 0)
                {
                    occurances++;
                }
            }

            Console.WriteLine(occurances);

        }
    }
}
