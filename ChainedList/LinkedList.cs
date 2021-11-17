using System;
using System.Collections.Generic;
using System.Text;

namespace GenericList
{
    public class LinkedList<T>
    {
        public Link<T> First { get; private set; }
        public Link<T> Last
        {
            get
            {
                Link<T> last = null;

                if (First != null)
                {
                    // Set Last
                    last = First;
                    while (last.Next != null)
                    {
                        last = last.Next;
                    }
                }

                return last;
            }
        }

        public int Count
        {
            get
            {
                Link<T> last = null;
                int count = 1;

                if (First != null)
                {
                    // Set Last
                    last = First;
                    while (last.Next != null)
                    {
                        last = last.Next;
                        count++;
                    }
                }
                return count;
            }
        }

        /// <summary>
        /// Get element by key.
        /// </summary>
        /// <param name="key">Key</param>
        /// <returns>T value</returns>
        public Link<T> GetElementByKey(int key)
        {
            Link<T> e = null;

            if (First != null)
            {
                e = First;
                int i = 0;

                while (i != key)
                {
                    e = e.Next;
                    i++;
                }
            }

            return e;
        }

        /// <summary>
        /// Add element.
        /// </summary>
        /// <param name="element"></param>
        public void Add(T element)
        {
            if (First == null)
            {
                // Add the first value
                First = new Link<T>() { Value = element };
            }
            else
            {
                // Add new element after last then link Previous
                Last.Next = new Link<T>() { Value = element, Previous = Last };
            }
        }
        
        /// <summary>
        /// Add element to a specified place.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="key"></param>
        public void AddAt(T element, int key)
        {
            if (key == 0)
            {
                if (First != null)
                {
                    First = new Link<T>() { Value = element, Next = First };
                    First.Next.Previous = First;
                }
                else
                {
                    First = new Link<T>() { Value = element };
                }
            }
            else
            {
                Link<T> elementToMove = GetElementByKey(key);
                
                if (elementToMove == null)
                {
                    Add(element);
                }
                else
                {
                    elementToMove.Previous.Next = new Link<T> { Value = element, Previous = elementToMove.Previous, Next = elementToMove };
                    elementToMove.Previous = elementToMove.Previous.Next;
                }
            }
        }
    }
}
