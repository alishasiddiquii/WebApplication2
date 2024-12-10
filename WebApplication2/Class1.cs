using System;
using System.Collections.Generic;

namespace WebApplication2
{
    public class Solution
    {
        public int Calculate(string s)
        {
            s = s.Replace(" ", "");

            Stack<int> stack = new Stack<int>();

            int currentNumber = 0;
            int result = 0;
            int sign = 1; 

            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];

                if (char.IsDigit(ch))
                {
                    currentNumber = currentNumber * 10 + (ch - '0');
                }
                else if (ch == '+')
                {
                    result += sign * currentNumber;
                    currentNumber = 0;
                    sign = 1; 
                }
                else if (ch == '-')
                {
                    result += sign * currentNumber;
                    currentNumber = 0;
                    sign = -1; 
                }
                else if (ch == '(')
                {
                    stack.Push(result);
                    stack.Push(sign);

                    result = 0;
                    sign = 1;
                }
                else if (ch == ')')
                {
                    result += sign * currentNumber;
                    currentNumber = 0;

                    result *= stack.Pop();
                    result += stack.Pop();
                }
            }
            result += sign * currentNumber;

            return result;
        }
    }
}

