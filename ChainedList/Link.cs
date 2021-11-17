using System;
using System.Collections.Generic;
using System.Text;

namespace GenericList
{
    public class Link<T>
    {
        public Link<T> Previous { get; set; }
        public Link<T> Next { get; set; }
        public T Value { get; set; }
    }
}
