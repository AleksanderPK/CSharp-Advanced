using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_DecimalToBinaryConverter
{
    class Ex_DecimalToBinaryConverter
    {
        static void Main(string[] args)
        {
            var input = 10;
            var stack = new Stack<string>();

            while (input != 0)
            {
                if (input % 2 == 0)
                {
                    stack.Push("0");
                }
                else
                {
                    stack.Push("1");
                }
                input /= 2;
            }
            stack.Reverse();

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }
            
        }
    }
}
