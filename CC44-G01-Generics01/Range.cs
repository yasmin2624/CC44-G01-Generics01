using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC44_G01_Generics01
{
    internal class Range<T> where T : IComparable<T>
    {
        public T Min { get; private set; }
        public T Max { get; private set; }

        public Range(T min, T max)
        {
            if (min.CompareTo(max) > 0)
                throw new ArgumentException("Min must be less than or equal to Max");

            Min = min;
            Max = max;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        public double Length()
        {
            return Convert.ToDouble(Max) - Convert.ToDouble(Min);
        }

    }
}