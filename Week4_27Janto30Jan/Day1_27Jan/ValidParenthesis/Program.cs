using System;
using System.Collections.Generic;

namespace ValidParenthesis
{
    internal class Program
    {
        public static bool Parenthesis(string str)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in str)
            {
               
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char top = stack.Pop();

                    if ((c == ')' && top != '(') ||
                        (c == '}' && top != '{') ||
                        (c == ']' && top != '['))
                    {
                        return false; 
                    }
                }
            }

            return stack.Count == 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string input = Console.ReadLine();

            bool result = Parenthesis(input);

            if (result)
                Console.WriteLine("Valid Parentheses ");
            else
                Console.WriteLine("Invalid Parentheses ");
        }
    }
}
