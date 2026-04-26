using System;

namespace DsaLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleStack myStack = new SimpleStack(2);

            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            myStack.Push(50);
            myStack.Push(60);
            myStack.Push(70);
            myStack.Push(80);
            myStack.Push(90);
            myStack.Push(100);
            myStack.Push(110);

            myStack.Display();

            Console.WriteLine("Popped: " + myStack.Pop());
            Console.WriteLine("Popped: " + myStack.Pop());

            Console.WriteLine("Peek: " + myStack.Peek());
            myStack.Display();
        }
    }
    // My Custom class
    public class SimpleStack
    {
        private int[] _items = new int[10];
        private int _top = -1;

        // Constructor
        public SimpleStack(int initialCapacity)
        {
            if (initialCapacity < 1)
            {
                initialCapacity = 4;
            }
            _items =  new int[initialCapacity];
        }

        private void Grow()
        {
            int[] newArray = new int[_items.Length * 2];

            for (int i = 0; i <= _top; i++)
            {
                newArray[i] = _items[i];
            }

            _items = newArray;
            Console.WriteLine($"Stack grew to {_items.Length} capacity.");
        }

        public void Push(int data)
        {
            if (_top == _items.Length - 1)
            {
                Grow();
            }
            _items[++_top] = data;
            Console.WriteLine($"Pushed {data} onto the stack.");
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow!");
                return -1;
            }
            return _items[_top--];
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return -1;
            }
            return _items[_top];
        }

        public bool IsEmpty()
        {
            return _top < 0;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return;
            }

            Console.WriteLine("--- Stack Status ---");
            for (int i = _top; i >= 0; i--)
            {
                Console.WriteLine($"| {_items[i]} |");
            }
            Console.WriteLine("------");
        }
    }
}