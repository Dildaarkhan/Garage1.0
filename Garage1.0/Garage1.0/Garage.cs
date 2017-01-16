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

        private T[] vehicles;

        public int Capacity { get; }
        public int Count { get; private set; }

        public Garage(int capacity)
        {
            Capacity = capacity;
            vehicles = new T[capacity];
        }

        public bool Add(T vehicle)
        {
            if (Count >= Capacity) return false;

            for (int i = 0; i < Capacity; i++)
            {
                if (vehicles[i] == null)
                {
                    vehicles[i] = vehicle;
                    Count += 1;
                    return true;
                }
            }
            return false;
        }

        public T Remove(T vehicle)
        {
            for (int i = 0; i < Capacity; i++)
            {
                if (vehicles[i].Equals(vehicle))
                {
                    vehicles[i] = null;
                    Count -= 1;
                    return vehicle;
                }
            }
            return default(T);
        }

        

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Capacity; i++)
            {
                if (vehicles[i] != null)
                {
                    yield return vehicles[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        
    }

}
