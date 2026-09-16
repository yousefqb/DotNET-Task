using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09.Interface
{
    internal class Helper2<T>
    {
        public static int SearchArray(T[] array, T value)
        {
            foreach (T item in array)
            {
                if (item.Equals(value))
                    return 1;
            }
            return -1;
        }

        public static void ReplaceArray(T[] array, T oldvalue,T newValue)
        {

            for (int i = 0; i< array.Length;i++)
            {
                if (array[i].Equals(oldvalue))
                {
                    array[i] = newValue;
                }
            }
        }
    }
}
