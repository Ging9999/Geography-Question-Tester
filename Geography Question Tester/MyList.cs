using System;

namespace Geography_Question_Tester
{
    public class MyList<T>
    {
        protected int _size;
        protected T[] _items;
        protected T[] _emptyArray = new T[0];
        protected const int _regularCapcity = 4;
        public int Capacity
        {
            get { return _items.Length; }
            set
            {

                /*implement some error handeling for values that would remove valuesb because not a great enough size*/
                if (value != _items.Length)
                {
                    if (value > 0)
                    {
                        T[] newItems = new T[value];
                        for(int i = 0; i < _size; i++)
                        {
                            newItems[i] = _items[i];
                        }
                        _items = newItems;
                    }
                    else
                    {
                        _items = _emptyArray;
                    }
                }
            }
        }
        public int Count
        {
            get { return _size; }
        }
        public MyList()
        {
            _items = _emptyArray;
            _size = 0;
        }
        public MyList(int size)
        {
            if (size < 0)
            {
                // need to implement exception so that negative values are not excepted
            }
            if (size == 0)
            {
                _items = _emptyArray; // creates empty array                
            }
            else
            {
                _items = new T[size]; //sets the size of array to whatever initialised too

            }
        }



        public T this[int index]
        {
            get
            {
                if (index > _size)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return _items[index];
            }
            set
            {
                if (index >= _size)
                {
                    //throw out of range exception
                }
                _items[index] = value;
            }
        }
        public void Add(T item)
        {
            if (_size == _items.Length)
            {
                CheckCapacity(_size + 1);
            }
            _items[_size] = item;
            _size++;
        }
        private void CheckCapacity(int min)
        {
            if (_items.Length < min)
            {
                int newCapacity = _items.Length == 0 ? _regularCapcity : _items.Length * 2; // increase's the capacity twice
                if (newCapacity < min)
                {
                    newCapacity = min;
                }
                Capacity = newCapacity;
            }
        }
        public void Clear()
        {
            _items = _emptyArray;
            _size = 0;
            Capacity = 0;
        }
        public bool Contains(T item)
        {
            if ((object)item == null)
            {
                for (int i = 0; i < _size; i++)
                {
                    if ((object)_items[i] == null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }        
        public int IndexOf(T item)
        {
            return Array.IndexOf(_items, item, 0, _size);
        }                     
        public void Insert(int index, T item)
        {
            if (_size == _items.Length)
            {
                CheckCapacity(_size + 1);
            }
            if (index < 0)
            {
                Array.Copy(_items, index, _items, index + 1, _size - index);
            }
            _items[index] = item;
            _size++;
        }
        public void RemoveAt(int index)
        {
            _size--;
            if (index < _size)
            {
                Array.Copy(_items, index + 1, _items, index, _size - index);
            }
            _items[_size] = default(T);
        }
        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if (index >= 0)
            {
                RemoveAt(index);
                return true;
            }
            return false; // not in index range if false
        }
        // implement some sort of sorting function

    }
}
