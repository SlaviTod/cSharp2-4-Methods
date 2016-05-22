using System;
using System.Text;

class CorrectBrackets
    {
        static void Main()
        {
            string input = Console.ReadLine();
            bool isCorrect = true;
            int n = input.Length;
            int nextOpBracet = input.IndexOf('(');
            int nextClBracet = input.IndexOf(')');
            while (nextClBracet != -1 && nextOpBracet!=-1)
            {
                if (nextOpBracet< nextClBracet)
                {
                    nextClBracet = input.IndexOf(')', nextClBracet + 1);
                    nextOpBracet = input.IndexOf('(', nextOpBracet + 1);
                }
                else
                {
                    isCorrect = false; break;
                }
            }
            if (nextClBracet!=-1 || nextOpBracet!=-1)
            {
                isCorrect = false;
            }
            Console.WriteLine(isCorrect? "Correct" : "Incorrect");
     }
}