using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    class Lemon<T>
    {
        public T Vitamins;
        public Lemon(T vitamins)
        {
            Vitamins = vitamins;
        }
        public override string ToString()
        {
            return $"Vitamins: {Vitamins}";
        }
    }
}
