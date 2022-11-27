using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndSearches
{
    internal class BalanceParenthisis
    {

        public void Balanced(string filepath)
        {
            string list = File.ReadAllText(filepath);
            string[] words = list.Split(" ");
            LinkListStack<string> stack = new LinkListStack<string>();
            foreach (var data in words)
            {
                if (data.Equals("("))
                {
                    stack.Push(data);
                }
                if (data.Equals(")"))
                {
                    stack.Pop();
                }
            }

            if (stack.Peek())
            {
                Console.WriteLine("Balanced Parentheses");
            }
            else
            {
                Console.WriteLine("Not Balanced Parentheses");
            }
        }
    }
}


