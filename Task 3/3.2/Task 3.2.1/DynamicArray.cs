using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._2._1
{
    class DynamicArray<T> : IEnumerable<T>
    {
        private T[] _internalArray;

        public int Capacity { get; private set; }

        public int Length { get; private set; }

        public DynamicArray()
        {
            Capacity = 8;
            _internalArray = new T[Capacity];
        }
        public DynamicArray(int capacity)
        {
            if (capacity > 0)
            {
                Capacity = capacity;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Capacity should be positive");
            }

            _internalArray = new T[capacity];
            
        }
        public DynamicArray(IEnumerable<T> someCollection) : this(CollectionCount(someCollection))
        {
            if (someCollection == null)
            {
                throw new ArgumentNullException("someCollection is null");
            }

            _internalArray = someCollection.ToArray();
            Capacity = Length = CollectionCount(someCollection);      
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    throw new ArgumentOutOfRangeException("Index should be positive and less then length");
                }
                return _internalArray[index];
            }
            set
            {
                if (index < 0 || index >= Length)
                {
                    throw new ArgumentOutOfRangeException("Index should be positive and less then length");
                }
                _internalArray[index] = value;
            }
        }

        public void Add(T addedElement)
        {     
            while (Capacity <= Length)
            {
                Capacity *= 2;
                Array.Resize(ref _internalArray, Capacity);
            }

            _internalArray[Length] = addedElement;
            Length++;
        }

        public void AddRange(IEnumerable<T> someCollection)
        {
            if (someCollection == null)
            {
                throw new ArgumentNullException("someCollection is null");
            }

            if (Capacity < Length + CollectionCount(someCollection))
            {
                Capacity *= 2;
                Array.Resize(ref _internalArray, Capacity);
            }
                        
            Array.Copy(someCollection.ToArray(), 0, _internalArray, Length, CollectionCount(someCollection));
            Length += CollectionCount(someCollection);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _internalArray.Length; i++)
            {
                yield return _internalArray[i];
            }            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _internalArray.GetEnumerator();
        }

        public static int CollectionCount(IEnumerable<T> someCollection)
        {
            int _count = 0;

            foreach (var item in someCollection)
            {
                _count++;
            }

            return _count;
        }

        public bool Remove(T element)
        {            
            {
                for (int i = 0; i < Length; i++)
                {
                    if (_internalArray[i].Equals(element))
                    {
                        _internalArray[i] = default;
                        return true;
                    }                    
                }
                return false;
            }           
        }

        public bool Insert(T element, int index)
        {
            if (index < 0 || index > Length)
            {
                throw new ArgumentOutOfRangeException("Index should be positive and less then length");
            }

            T[] _temp = new T[Capacity];

            if (Length == Capacity)
            {
                Array.Resize(ref _temp, Capacity + 1);
                Capacity++;
                Array.Resize(ref _internalArray, Capacity + 1);
            }
                        
            Array.Copy(_internalArray, _temp, Length);
            Length++;

            _internalArray[index] = element;

            Array.Copy(_temp, index, _internalArray, index + 1, Length - 1 - index);
                        
            return true;
        }
    }
}
