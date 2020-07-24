using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace chapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack nums = new Stack();
            Stack ops = new Stack();
            string expression = "1 + 2 + 5 + 100";
            Caclulate(nums, ops, expression);
            Console.WriteLine(nums.Pop());

        }
        static bool IsNumeric(string input)
        {
            string pattern = @"^\d+$";
            Regex validate = new Regex(pattern);
            return validate.IsMatch(input);
        }
        static void Caclulate(Stack N, Stack O, string exp)
        {
            string ch, token = "";
            for (int p = 0; p < exp.Length; p++)
            {
                ch = exp.Substring(p, 1);
                if (IsNumeric(ch))
                    token += ch;
                if (ch == " " || p == exp.Length - 1)
                {
                    if (IsNumeric(token))
                    {
                        N.Push(token);
                        token = "";
                    }
                }
                else if (ch == "+" || ch == "-" || ch == "*" || ch == "/")
                    O.Push(ch);
                if (N.Count == 2)
                    Compute(N, O);
            }
        }
        static void Compute(Stack N, Stack o)
        {
            int oper1, oper2;
            string oper;
            oper1 = Convert.ToInt32(N.Pop());
            oper2 = Convert.ToInt32(N.Pop());
            oper = Convert.ToString(o.Pop());
            switch (oper)
            {
                case "+":
                    N.Push(oper1 + oper2);
                    break;
                case "-":
                    N.Push(oper1 - oper2);
                    break;
                case "*":
                    N.Push(oper1 * oper2);
                    break;
                case "/":
                    N.Push(oper1 * oper2);
                    break;
            }
        }
    }
}
