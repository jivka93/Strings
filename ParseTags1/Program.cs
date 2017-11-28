using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTags1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();          // TO BE FIXED.  60/100
            string newText = text;
            string start = "<upcase>";
            string end = "</upcase>";
            List<int> startIndexes = new List<int>();
            List<int> endIndexes = new List<int>();

            while (true)
            {
                int lastOpeningIndex = newText.LastIndexOf(start);
                startIndexes.Add(lastOpeningIndex);

                int lastClosingIndex = newText.LastIndexOf(end);
                endIndexes.Add(lastClosingIndex);

                if (lastOpeningIndex == newText.IndexOf(start))
                {
                    break;
                }
                newText = newText.Substring(0,lastOpeningIndex);
            }

            int count = startIndexes.Count;
            StringBuilder resultBuilder = new StringBuilder();
            int index = 0;
            for (int i = count - 1; i >= 0; i--)
            {
                resultBuilder.Append(text,index, startIndexes[i] - index);

                int currIndex = startIndexes[i] + start.Length;
                int currLength = endIndexes[i] - currIndex;
                string substring = text.Substring(currIndex,currLength).ToUpper(); 
                resultBuilder.Append(substring);

                index = endIndexes[i] + end.Length;
            }

            int startIndex = endIndexes[0] + end.Length;
            int length = text.Length - startIndex;
            if (startIndex < length)
            {
                resultBuilder.Append(text, startIndex, length);
            }
            Console.WriteLine(resultBuilder);
        }
    }
}
