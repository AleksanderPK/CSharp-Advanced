using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr03_MaximumElment
{
    class Pr03_MaximumElment
    {
        static void Main(string[] args)
        {
            var queriesNum = int.Parse(Console.ReadLine());
            int[][] inputArr = new int[queriesNum][];
            var stack = new Stack<int>();

            for (int i = 0; i < queriesNum; i++)
            {
                inputArr[i] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            for (int i = 0; i < queriesNum; i++)
            {
                if (inputArr[i][0] == 1)
                {
                    stack.Push(inputArr[i][1]);
                }
                else if (inputArr[i][0] == 2)
                {
                    stack.Pop();
                }
                else if (inputArr[i][0] == 3)
                {
                    Console.WriteLine(stack.Max());
                }
            }
        }
    }
}
