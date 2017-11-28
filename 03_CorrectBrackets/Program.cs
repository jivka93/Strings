using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            List<int> opening = new List<int>();
            List<int> closing = new List<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    opening.Add(i);
                }
                if (expression[i] == ')')
                {
                    closing.Add(i);
                }
            }

            string answer = "Correct";

            if (opening.Count == closing.Count)
            {
                for (int i = 0; i < opening.Count; i++)
                {
                    if (opening[i] > closing[i])
                    {
                        answer = "Incorrect";
                    }
                }
            }
            else
            {
                answer = "Incorrect";
            }

            Console.WriteLine(answer);
        }
    }
}
