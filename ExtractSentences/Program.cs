using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSentences
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string[] words = { " " + word + " ",
                               " " + word + ".",
                               " " + word + ",",
                               //("" + word[0]).ToUpper() + word.Substring(1,word.Length - 1) + " ",
                               //("" + word[0]).ToUpper() + word.Substring(1,word.Length - 1) + ".",
                               //("" + word[0]).ToUpper() + word.Substring(1,word.Length - 1) + ",",
                               //("" + word[0]).ToUpper() + word.Substring(1,word.Length - 1) + "!",
                               //("" + word[0]).ToUpper() + word.Substring(1,word.Length - 1) + "?",
                               //("" + word[0]).ToUpper() + word.Substring(1,word.Length - 1) + ":",
                               " " + word + "!",
                               " " + word + "?",
                               " " + word + ":",   };

            char[] splitSymbols = { '.', '!', '?' };
            string[] sentences = ((Console.ReadLine()).Split(splitSymbols));

            for (int sentence = 0; sentence < sentences.Length; sentence++)
            {
                for (int wordType = 0; wordType < words.Length; wordType++)
                {
                    int check = sentences[sentence].IndexOf(words[wordType], StringComparison.CurrentCultureIgnoreCase);
                    if (check >= 0) // relevant sentence
                    {
                        Console.Write(sentences[sentence] + "."); // ???????

                    }

                }
            }


            Console.WriteLine();
            
        }
    }
}
