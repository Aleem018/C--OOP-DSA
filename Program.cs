using System;

namespace DsaLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleStack myStack = new SimpleStack();

            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);

            myStack.Display();

            Console.WriteLine("Popped: " + myStack.Pop());
            Console.WriteLine("Popped: " + myStack.Pop());

            Console.WriteLine("Peek: " + myStack.Peek());
        }
    }
    // My Custom class
    public class SimpleStack
    {
        private int[] _items = new int[10];
        private int _top = -1;

        public void Push(int data)
        {
            if (_top >=9)
            {
                Console.WriteLine("Stack Overflow!");
                return;
            }
            _items[++_top] = data;
            Console.WriteLine($"Pushed {data} onto the stack.");
        }

        public int Pop()
        {
            if (_top < 0)
            {
                Console.WriteLine("Stack Underflow!");
                return -1;
            }
            return _items[_top--];
        }

        public int Peek()
        {
            if (_top < 0)
            {
                Console.WriteLine("Stack is empty!");
                return -1;
            }
            return _items[_top];
        }

        public void Display()
        {
            if (_top < 0)
            {
                Console.WriteLine("Stack is empty!");
                return;
            }

            for (int i = _top; i >= 0; i--)
            {
                Console.WriteLine($"| {_items[i]} |");
            }
            Console.WriteLine("------");
        }
    }
}