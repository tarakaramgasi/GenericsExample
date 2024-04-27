using Stacks;
using System.Collections.Generic;
namespace GenericsExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack1<int> stack = new Stack1<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Pop();
            stack.Pop();
            stack.Display();
        }
    }
}
