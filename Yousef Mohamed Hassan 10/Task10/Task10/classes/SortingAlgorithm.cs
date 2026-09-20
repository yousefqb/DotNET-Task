using System;
using System.Collections.Generic;
using System.Text;

namespace Task10.classes
{
        static class SortingAlgorithm<T> where T : IComparable<T>,ICloneable
        {
        
            public static T[] Sort(T[] items, Func<T, T, bool> compareFunc)
            {
               T[] newarr = new T[items.Length];
               for (int i = 0; i < items.Length; i++)
               { 
                newarr[i] = (T)items[i].Clone();
               }
                for (int i = 0; i < newarr.Length - 1; i++)
                {
                    for (int j = 0; j < newarr.Length - 1 - i; j++)
                    {
                        if (compareFunc(newarr[j], newarr[j + 1]))
                        {
                            Swap(ref newarr[j], ref newarr[j + 1]);
                        }
                    }
                }
                return newarr;
            }
            public static void Swap(ref T a, ref T b)
            {
                T temp = a;
                a = b;
                b = temp;
            }
        }
}

