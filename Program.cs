using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poistionofparanthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "(((())))";
            int position = 2;
            var p = new Program();
           var output= p.ReturnClosedParanthesisPosition(input, position);
            Console.WriteLine(output);
        }
        int ReturnClosedParanthesisPosition(string input,int openparenthesisposition)
        {
            var parenthesisarray = input.ToCharArray();
            int counter = 1;
            for (int i =openparenthesisposition; i < parenthesisarray.Length; i++)
            {
                if (parenthesisarray[i]=='(')
                {
                    counter++;
                }
                if (parenthesisarray[i] == ')')
                {
                    counter--;
                }
                if (counter == 0)
                {
                    return i;                    
                }
            }
            return -1;
        }
    }
}
