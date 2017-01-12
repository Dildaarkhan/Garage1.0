using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    class Garage<T> : IEnumerable<T> where T : Vehicle
    {

        private T[] elements;

        public int Capacity { get; }
        public int Count { get; private set; }

        public Garage(int capacity)
        {
            Capacity = capacity;
            elements = new T[capacity];
        }

        public bool Add(T element)
        {
            if (Count >= Capacity) return false;

            for (int i = 0; i < Capacity; i++)
            {
                if (elements[i] == null)
                {
                    elements[i] = element;
                    Count += 1;
                    return true;
                }
            }
            return false;
        }

        public T Remove(T element)
        {
            for (int i = 0; i < Capacity; i++)
            {
                if (elements[i].Equals(element))
                {
                    elements[i] = null;
                    Count -= 1;
                    return element;
                }
            }
            return default(T);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Capacity; i++)
            {
                if (elements[i] != null)
                {
                    yield return elements[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }

}
