using System;
using System.Collections.Generic;
using System.Text;

namespace ChainedList
{
    public class Chaining<T>
    {
        public T Value { get; set; }
        public Chaining<T> Previous { get; set; }
        public Chaining<T> Next { get; set; }
    }
}
