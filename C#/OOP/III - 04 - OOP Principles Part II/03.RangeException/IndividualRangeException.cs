using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RangeException
{
    class InvalidRangeException<T> : Exception
    {
        private const string message = "Not in range!";

        public T start { get;  set; }
        public T end { get;  set; }

        public InvalidRangeException(T start, T end, Exception innerException = null)
            : base(message, innerException)
        {
            this.start = start;
            this.end = end;
        }
    }
}
