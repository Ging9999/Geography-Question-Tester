using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geography_Question_Tester
{
    class MyQueue<T>
    {
        private int _head;
        private int _tail;
        private int _capacity;
        private const int _defaultCapacity = 8;
        private MyList<T> Queue;

        public MyQueue()
        {
            _capacity = _defaultCapacity;      
        }
        public MyQueue(int Capacity)
        {
            _capacity = Capacity;
        }

    }
}
