using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    class Apple<T>
    {
        public T Vitamins;
        public Apple(T vitamins)
        {
            Vitamins = vitamins;
        }
        public override string ToString()
        {
            return $"Vitamin: {Vitamins}";
        }
    }
}
