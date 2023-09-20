using System;

namespace Geography_Question_Tester
{
    public class MyList<T>
    {
        public int Size;
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
                        if (Size > 0)
                        {
                            Array.Copy(_items, newItems, Size);  //initialises new array with the new size.
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
            get { return Size; }
        }
        public MyList()
        {
            _items = _emptyArray;
            Size = 0;
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
                if (index > Size)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return _items[index];
            }
            set
            {
                if (index >= Size)
                {
                    //throw out of range exception
                }
                _items[index] = value;
            }
        }
        public void Add(T item)
        {
            if (Size == _items.Length)
            {
                CheckCapacity(Size + 1);
            }
            _items[Size] = item;
            Size++;
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
            if (Size > 0)
            {
                Array.Clear(_items, 0, Size);
                Size = 0;
            }
        }
        public bool Contains(T item)
        {
            if ((object)item == null)
            {
                for (int i = 0; i < Size; i++)
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
            return Array.IndexOf(_items, item, 0, Size);
        }
        public T Find(Predicate<T> match)
        {
            if (match == null)
            {
                //throw Argument expception
            }
            for (int i = 0; i < Size; i++)
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
            for (int i = 0; i < Size; i++)
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
            return FindIndex(0, Size, match);
        }
        public int FindIndex(int startIndex, Predicate<T> match)
        {
            return FindIndex(startIndex, Size - startIndex, match);
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
            for (int i = Size - 1; i >= 0; i--)
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
            if (Size == _items.Length)
            {
                CheckCapacity(Size + 1);
            }
            if (index < 0)
            {
                Array.Copy(_items, index, _items, index + 1, Size - index);
            }
            _items[index] = item;
            Size++;
        }
        public void RemoveAt(int index)
        {
            Size--;
            if (index < Size)
            {
                Array.Copy(_items, index + 1, _items, index, Size - index);
            }
            _items[Size] = default(T);
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
