using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    class Pineapple<T>
    {
        public T Vitamins;
        public Pineapple(T vitamins)
        {
            Vitamins = vitamins;
        }
        public override string ToString()
        {
            return $"Vitamin: {Vitamins}";
        }
    }
    
}
