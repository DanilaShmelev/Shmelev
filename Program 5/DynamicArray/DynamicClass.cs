using System;
using System.Buffers;
using System.Collections;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace DynamicArray
{
    public class DynamicArray<Type> : IEnumerable<Type>, IDisposable, ICollection
    {
        public delegate void DynamicArrayHandler(object sender, DynamicArrayEventArgs e);
        public event DynamicArrayHandler? Notify;

        private Type[] _array;
        private int _length;
        public bool isDisposed = false;

        private const int DefaultCapacity = 8;

        public DynamicArray()
        {
            _array = new Type[DefaultCapacity];
            Length = 0;
        }
        
        public DynamicArray(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            _array = new Type[capacity];
            Length = 0;
        }

        public DynamicArray(IEnumerable<Type> obj) 
        {
            if (obj is null)
            {
                throw new ArgumentNullException(); 
            }

            //получаем количество элементов в коллекции
            Length = GetCollectionLength(obj);

            //создаем массив нужного размера
            _array = new Type[Length];

            //копируем элементы из коллекции в массив
            int i = 0;
            foreach (Type item in obj)
            {
                _array[i] = item;
                i++;
            }
        }

        private int GetCollectionLength(IEnumerable<Type> obj)
        {
            int length = 0;

            foreach (var item in obj)
            {
                length++;
            }

            return length;
        }

        public void Add(Type elem) 
        {
            CheckCapacity(Length + 1);

            _array[Length] = elem;
            Length++;
        }

        public void CheckCapacity(int futureLength)
        {
            if (futureLength > Capacity)
            {
                int capacity = Capacity;

                if (capacity == 0) 
                {
                    capacity++;
                }

                while (futureLength > capacity)
                {
                    capacity *= 2;
                }

                Notify?.Invoke(this, new DynamicArrayEventArgs(Capacity, capacity)); // число может быть больше чем в 2 раза
                Type[] newArr = new Type[capacity];
                Array.Copy(_array, newArr, Length); //откуда, куда, сколько индексов копируем
                _array = newArr;
            }
        }

        public void AddRange(IEnumerable<Type> obj) 
        {
            int newCount = Length + GetCollectionLength(obj);
            CheckCapacity(newCount);

            foreach (var item in obj)
            {
                this.Add(item);
            }
        }

        public void Remove(Type elem, Func<Type, Type, bool> predicate = null)
        {
            int removedCount = 0;

            if (predicate is null)
            {
                for (int i = 0; i < _array.Length; i++)
                {
                    if (_array[i].Equals(elem))
                    {
                        removedCount++;
                    }
                    else if (removedCount > 0)
                    {
                        //перемещаем оставшиеся элементы влево
                        _array[i - removedCount] = _array[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < _array.Length; i++)
                {
                    if (predicate(_array[i], elem))
                    {
                        removedCount++;
                    }
                    else if (removedCount > 0)
                    {
                        //перемещаем оставшиеся элементы влево
                        _array[i - removedCount] = _array[i];
                    }
                }
            }
            
            //к оставшимся элементам присваиваем default
            for (int i = _array.Length - removedCount; i < _array.Length; i++)
            {
                _array[i] = default(Type);
            }

            Length -= removedCount;
        }

        public void Insert(Type item, int index)
        {
            IndexCheck(index);

            CheckCapacity(Length + 1);

            for (int i = Length - 1; i >= index; i--)
            {
                _array[i + 1] = _array[i];
            }

            _array[index] = item;
            Length++;
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
            get
            {
                return _array.Length;
            }
        }

        public int Count => Length;

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public override bool Equals(object obj) 
        {
            DynamicArray<Type> other = obj as DynamicArray<Type>; 
            if (other is null)
            {
                return false;
            }
            if (Length != other.Length)
            {
                return false; 
            }
            for (int i = 0; i < Length; i++)
            {
                if (!this[i].Equals(other[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public IEnumerator<Type> GetEnumerator()
        {
            return new DynamicArrayEnumerator<Type>(this); 
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static bool operator ==(DynamicArray<Type> obj1, DynamicArray<Type> obj2) 
        {
            if (obj1 is null || obj2 is null) 
            {
                return false;
            }
            return obj1.Equals(obj2);
        }

        public static bool operator !=(DynamicArray<Type> obj1, DynamicArray<Type> obj2) 
        {
            if (obj1 is null || obj2 is null)  
            {
                return false;
            }
            return !obj1.Equals(obj2);
        }

        public Type this[int index] 
        {
            get
            {
                IndexCheck(index);
                return _array[index];
            }
            set
            {
                IndexCheck(index);
                _array[index] = value;
            }
        }

        private void IndexCheck(int index)
        {
            if (index >= Length || index < 0)
            {
                throw new ArgumentOutOfRangeException($"Индекс {index} выходит за пределы массива");
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (isDisposed)
            {
                return;
            }
            if (disposing && _array is not null)
            {
                foreach (var item in _array)
                {
                    if (item is IDisposable)
                    {
                        ((IDisposable)item).Dispose();
                    }
                }
                Notify?.Invoke(this, new DynamicArrayEventArgs(Capacity, 0));
                Array.Clear(_array);
                Array.Resize(ref _array, 0);
                Length = 0;
                isDisposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void CopyTo(Array array, int index)
        {
            foreach (Type i in _array)
            {
                array.SetValue(i, index);
                index++;
            }
        }

        ~DynamicArray()
        {
            Dispose(false);
        }

        public static explicit operator Type[](DynamicArray<Type> dynamicArray) //явное преобразование
        {
            Type[] tempArray = new Type[dynamicArray.Length]; 
            Array.Copy(dynamicArray._array, tempArray, dynamicArray.Length);
            return tempArray;
        }

        public static implicit operator DynamicArray<Type>(Type[] array) //неявное преобразование
        {
            return new DynamicArray<Type>(array);
        }
    }
}
