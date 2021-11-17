using System;
using System.Collections.Generic;
using System.Text;

namespace GenericList
{
    class GenericList<T>
    {
        private int capacity;
        private int nbElements;
        private T[] table;

        public GenericList()
        {
            capacity = 10;
            nbElements = 0;
            table = new T[capacity];
        }

        public void Add(T element)
        {
            if (nbElements >= capacity)
            {
                capacity *= 2;
                T[] copyTableau = new T[capacity];
                for (int i = 0; i < table.Length; i++)
                {
                    copyTableau[i] = table[i];
                }
                table = copyTableau;
            }
            table[nbElements] = element;
            nbElements++;
        }

        public T GetElement(int key)
        {
            return table[key];
        }

    }
}
