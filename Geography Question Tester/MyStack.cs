using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geography_Question_Tester
{
    public class MyStack<T>
    {
        private MyList<T> stack = new MyList<T>(20);
        int bp = 0;
        public T Pop()
        {
            bp--;
            T temp = stack[bp];
            stack.RemoveAt(bp);
            return temp;
        }
        public void Push(T item)
        {
            stack.Add(item);
            bp++;
        }
    }
}
