using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSentences1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string[] sentences = Console.ReadLine().Split('.');

            for (int i = 0; i < sentences.Length; i++)
            {
                sentences[i] += ".";
            }


            List<int> releventSentencesIndexes = new List<int>();

            for (int s = 0; s < sentences.Length; s++) // Минава през всички изречения
            {
                int previousSplitIndex = -1;
                string currentSentence = sentences[s];
                for (int indexOfSymbol = 0; indexOfSymbol < sentences[s].Length; indexOfSymbol++) // Минава през всички символи от изречението
                {                   
                    char currentSymbol = sentences[s][indexOfSymbol];
                    bool isLetter = char.IsLetter(currentSymbol);
                    if (isLetter == false)
                    {
                        int count = indexOfSymbol - previousSplitIndex - 1;
                        string currentWord = currentSentence.Substring(previousSplitIndex + 1,count);
                        if ((currentWord.Equals(word, StringComparison.CurrentCultureIgnoreCase)))  // ignoring the case
                        {
                            releventSentencesIndexes.Add(s); // 
                        }
                        previousSplitIndex = indexOfSymbol;
                    }
                }
            }

            for (int i = 0; i < releventSentencesIndexes.Count; i++)
            {
                Console.Write(sentences[i] + ". ");
            }
            Console.WriteLine();

        }
    }
}
