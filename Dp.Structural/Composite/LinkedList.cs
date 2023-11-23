using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dp.Structural.Composite
{
    internal class LinkedList<T>
    {
        public LinkedList() { }

        public LinkedList(T v) => value = v;

        T value;
        LinkedList<T> next;

        public T Get(int i)
        {
            if (next is null)
            {
                throw new IndexOutOfRangeException();
            }

            if (i == 0)
            {
                return value;
            }

            return next.Get(--i);
        }

        public void Add(T v)
        {
            if (next is null)
            {
                value = v;
                next = new LinkedList<T>();
            }
            else
            {
                next.Add(v);
            }
        }
    }
}
