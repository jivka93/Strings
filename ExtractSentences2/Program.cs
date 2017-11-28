using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSentences2
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            StringBuilder builder = new StringBuilder();
            string[] sentences = text.Split('.');
            char[] splitSymbols = text.Where(symbol => !char.IsLetter(symbol)).Distinct().ToArray();

            foreach (string sentence in sentences)
            {
                List<string> words = sentence.Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (words.Contains(word))
                {
                    builder.Append(sentence.Trim() + ". ");
                }
            }
            Console.WriteLine(builder.ToString().Trim());


        }
    }
}
