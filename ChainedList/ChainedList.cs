using System;
using System.Collections.Generic;
using System.Text;

namespace ChainedList
{
    public class ChainedList<T>
    {
        public int ElementCount;
        private T[] table;
        public int tableSize;
        
        public Chaining<T> FirstElement { get; set; }
        public Chaining<T> LastElement { get; set; }
        
        /// <summary>
        /// ChainedList Constructor
        /// </summary>
        /// <param name="size">Array size.</param>
        public ChainedList(int size)
        {
            ElementCount = 0;
            tableSize = size;
            table = new T[tableSize];
        }

        public T GetElementByKey(int key)
        {
            return table[key];
        }

        public void Add(params T[] values)
        {
            foreach (T value in values)
            {
                Add(value);
            }
        }

        public void Add(T element)
        {
            if (FirstElement == null)
            {
                FirstElement = new Chaining<T>();
                FirstElement.Value = element;
            }

            if (ElementCount >= tableSize)
            {
                // Extend table size
                T[]  newTable = new T[tableSize];
                
                // Copy table
                for (int i = 0; i < ElementCount; i++)
                {
                    newTable[i] = table[i];
                }
                table = newTable;
            }

            // Add new element
            table[ElementCount] = element;
            ElementCount++;
        }

        /// <summary>
        /// Add element to a specified place.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="key"></param>
        public void AddAt(T element, int key)
        {
            if (ElementCount >= tableSize)
            {
                tableSize++;
            }

            T[] newTable = new T[tableSize];
            
            if (key == 0)
            {
                newTable[0] = element;
            }
            
            // Copy table
            for (int i = 0; i < ElementCount; i++)
            {
                // Ajouter element à 0
                if (key == 0)
                {
                    newTable[0] = element;

                    if (i != 0)
                    {
                        newTable[i] = table[i-1];
                    }
                }
                else if(i < key)
                {
                    newTable[i] = table[i];
                }
                else if (i == key)
                {
                    newTable[i] = element;
                }
                else if (i > key)
                {
                    newTable[i] = table[i+1];
                }
            }

            table = newTable;
            ElementCount++;
        }
    }
}
