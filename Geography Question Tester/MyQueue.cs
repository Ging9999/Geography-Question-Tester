using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geography_Question_Tester
{
    class MyQueue<T> : MyList<T>
    {  
        public T Pop()
        {
            T Value = _items[0];
            RemoveAt(0);
            return Value;
        }
        public T Peak()
        {
            return _items[0];
        }
        public void Push(T value)
        {
            Add(value);
        }

    }
}
