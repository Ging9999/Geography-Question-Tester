using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geography_Question_Tester
{
    class MyQueue<T>
    {  
        private MyList<T> Queue = new MyList<T>();
        public T Pop()
        {
            T Value = Queue[0];
            Queue.RemoveAt(0);
            return Value;
        }
        public T Peak()
        {
            return Queue[0];
        }
        public void Push(T value)
        {
            Queue.Add(value);
        }

    }
}
