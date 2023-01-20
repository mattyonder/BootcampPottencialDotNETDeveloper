using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class MyArray<T>
    {

        private static int capacity = 10;
        private int count = 0;
        private T[] array = new T[capacity];

        public void AddElementArray(T element)
        {
            if (count + 1 < 11)
            {
                array[count] = element;
            }
            count++;
        }

        public T this[int index]
        {
            get { return array[index];}
            set { array[index] = value; }

        }
    }
}