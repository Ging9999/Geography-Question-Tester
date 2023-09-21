using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geography_Question_Tester
{
    class MyQueue<T>
    {
        public int Size;
        private int _fp;
        private int _bp;
        private const int _defaultCapacity = 8;
        private MyList<T> Queue = new MyList<T>(_defaultCapacity);

        private int Capacity
        {
            get { return Queue.Size; } 
            set 
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    
                  
                }
            }
        }

        public MyQueue()
        {
            Capacity = _defaultCapacity;      
        }
        public MyQueue(int Capacity)
        {
            
        }

    }
}
