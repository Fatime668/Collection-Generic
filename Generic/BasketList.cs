using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    class BasketList<T>
    {
        private T[] Fruits;
        public int Count { 
            get 
            {
                return Fruits.Length;
            }
        }
        public BasketList()
        {
            Fruits = new T[0];
        }
        public T[] GetVitamins()
        {
            return Fruits;
        }
        public void Add(T value)
        {
            Array.Resize(ref Fruits, Fruits.Length + 1);
            Fruits[Fruits.Length - 1] = value;
        }
        
    }
}
