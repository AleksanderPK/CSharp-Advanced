using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_SimpleCalculator
{
    class Ex_SimpleCalculator
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var values = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var stack = new Stack<string>(values.Reverse());

            while (stack.Count > 1)
            {
                var first = int.Parse(stack.Pop());
                var op = stack.Pop();
                var second = int.Parse(stack.Pop());

                switch (op)
                {
                    case "+": stack.Push((first + second).ToString()); break;
                    case "-": stack.Push((first - second).ToString()); break;
                    default: break;
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
