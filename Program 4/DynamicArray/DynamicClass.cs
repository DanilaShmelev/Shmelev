using System;
using System.Text.RegularExpressions;

namespace DynamicArray
{
    internal class DynamicArray<Type>
    {
        private Type[] _array;
        private int _length;
        private int _capacity;

        public DynamicArray()
        {
            _array = new Type[8];
            Length = 0;
            Capacity = 8;
        }

        public DynamicArray(int capacity)
        {
            _array = new Type[capacity];
            Length = 0;
            Capacity = capacity; //capacity привязку к массиву, как-то вычислять
        }

        public void Add(Type elem)
        {
            if (Length + 1 > Capacity)
            {
                Capacity *= 2;
                Array.Resize(ref _array, Capacity);
            }

            _array[Length] = elem;
            Length++;
        }

        public void Remove(Type elem)
        {
            foreach (Type t in _array)
            {
                if (t.Equals(elem))
                {
                    //сдвигается
                }
            }
        }

        public int Length
        {
            private set
            {
                _length = value;
            }
            get
            {
                return _length;
            }
        }

        public int Capacity
        {
            private set
            {
                _capacity = value;
            }
            get
            {
                return _capacity;
            }
        }
        //Insert +1  в определенную позицию, geхуй в конец рандомное число
    }
}
