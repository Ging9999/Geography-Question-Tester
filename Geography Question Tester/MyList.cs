using System;
using System.Collections;

namespace Geography_Question_Tester
{
    public class MyList<T>
    {
        private int _size;
        private T[] _items;
        private T[] _emptyArray = new T[0];
        private const int _regularCapcity = 4;
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
                        if (_size > 0)
                        {
                            Array.Copy(_items, newItems, _size);  //initialises new array with the new size.
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
                if (index >= _size)
                {
                    //Throw out of range exception
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
                _items[_size++] = item;
            }
            else
            {
                _items[_size++] = item;
            }
        }
        private void CheckCapacity(int min)
        {
            if (_items.Length < min)
            {
                int newCapacity = _items.Length == 0 ? _regularCapcity : _items.Length * 2; // increase's the capacity twice
                Capacity = newCapacity;
            }

        }
        public void Clear()
        {
            if (_size > 0)
            {
                Array.Clear(_items, 0, _size);
                _size = 0;
            }
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
        public void CopyTo(T[] array)
        {
            CopyTo(array);
        }
        public int IndexOf(T item)
        {
            return Array.IndexOf(_items, item, 0, _size);
        }
        public T Find(Predicate<T> match)
        {
            if (match == null)
            {
                //throw Argument expception
            }
            for (int i = 0; i < _size; i++)
            {
                if (match(_items[i]))
                {
                    return _items[i];
                }
            }
            return default(T);
        }
        public MyList<T> FindAll(Predicate<T> match)//Programming note - Predicate<T> is the object you are looking for that being a data type or etc
        {
            MyList<T> List = new MyList<T>();
            if (match == null)
            {
                //throw Argument expception
            }
            for (int i = 0; i < _size; i++)
            {
                if (match(_items[i]))
                {
                    List.Add(_items[i]);
                }
            }
            return List;
        }


        public bool Exists(Predicate<T> match)
        {
            return FindIndex(match) != -1;
        }
        //tests
        public int FindIndex(Predicate<T> match)
        {
            return FindIndex(0, _size, match);
        }
        public int FindIndex(int startIndex, Predicate<T> match)
        {
            return FindIndex(startIndex, _size - startIndex, match);
        }
        public int FindIndex(int startIndex, int count, Predicate<T> match)
        {
            int endIndex = startIndex + count;
            for (int i = startIndex; i < endIndex; i++)
            {
                if (match(_items[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        public T FindLast(Predicate<T> match)
        {
            for (int i = _size - 1; i >= 0; i--)
            {
                if (match(_items[i]))
                {
                    return _items[i];
                }
            }
            return default(T);
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
