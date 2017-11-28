using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append(input.Substring(0, input.IndexOf("<a href=")));
            do
            {
                int startIndex = input.IndexOf("<a href=");
                int finalIdex = input.IndexOf("</a>") + 3;
                int length = finalIdex - startIndex + 1;
                string pieceOfInput = input.Substring(startIndex, length); 
                string url = "(" + pieceOfInput.Substring(pieceOfInput.IndexOf('"') + 1, pieceOfInput.LastIndexOf('"') - pieceOfInput.IndexOf('"') - 1) + ")";
                string text = "[" + pieceOfInput.Substring(pieceOfInput.IndexOf('>') + 1, pieceOfInput.LastIndexOf('<') - pieceOfInput.IndexOf('>') - 1) + "]";
                strBuilder.Append(text);
                strBuilder.Append(url);
                input = input.Substring(finalIdex + 4);
            } while (input.IndexOf("</a>") != input.LastIndexOf("</a>"));

            strBuilder.Append(input.Substring(input.LastIndexOf("</a>") + 4));
            Console.WriteLine(strBuilder);
        }
    }
}
