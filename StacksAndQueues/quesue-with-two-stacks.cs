using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.StacksAndQueues
{
    class quesue_with_two_stacks
    {
        public class MyQueue<T>
        {
            Stack<T> stackNewestOnTop = new Stack<T>();
            Stack<T> stackOldestOnTop = new Stack<T>();

            public void enqueue(T value)
            { // Push onto newest stack
                stackNewestOnTop.Push(value);
            }

            public T peek()
            {
                prepOld();
                return stackOldestOnTop.Peek();
            }

            public T dequeue()
            {

                prepOld();
                return stackOldestOnTop.Pop();

            }

            public void prepOld()
            {
                if (stackOldestOnTop.Count == 0)
                    while (stackNewestOnTop.Count != 0)
                        stackOldestOnTop.Push(stackNewestOnTop.Pop());
            }
        }
    }
}
