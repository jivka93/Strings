using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSentencesNew
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            List<string> sentences = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
            char[] sep = text.Where(l => !char.IsLetter(l)).Distinct().ToArray();

            List<string> words = new List<string>();
            foreach (var sentence in sentences)
            {
                words = sentence.Split(sep, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (words.Contains(word))
                {
                    sb.Append(sentence.Trim());
                    sb.Append(". ");
                }
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
