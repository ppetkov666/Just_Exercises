namespace _01___FirstExample
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    class MyCustomArray<T> : IEnumerable<T>
    {
        private T[] data;
        public MyCustomArray(int size)
        {
            this.data = new T[size];
        }
        public int Length => this.data.Length;
        public void Add(int position, T item)
        {
            data[position] = item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)data).GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.data.GetEnumerator();
        }

        public T this[int index]
        {
            get
            {
                return this.data[index];
            }
            set
            {
                this.data[index] = value;
            }
        }
    }
}
