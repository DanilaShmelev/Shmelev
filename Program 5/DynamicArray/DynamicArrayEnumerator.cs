using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    internal class DynamicArrayEnumerator<Type> : IEnumerator<Type>
    {
        private DynamicArray<Type> obj;
        private int _position = -1;

        public DynamicArrayEnumerator(DynamicArray<Type> obj)
        {
            this.obj = obj;
        }

        public Type Current => CurrentEnum();

        object IEnumerator.Current => CurrentEnum();

        public void Dispose()
        {
            return; 
        }

        public bool MoveNext()
        {
            if (_position < obj.Length - 1)
            {
                _position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _position = -1;
        }

        private Type CurrentEnum()
        {
            return obj[_position]; //если такой позиции нет, то вылетит ошибка в индексаторе
        }
    }
}
