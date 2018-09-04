using System;
using System.Collections.Generic;
using System.Text;

namespace myTemplateClass
{
    public class MyTemplateClass<T>
    {
        public List<T> data;
        public MyTemplateClass()
        {
            this.data = new List<T>();
        }
        public int Count => this.data.Count;

       // this is the other option :
       //public int Count
       //{
       //    get { return this.data.Count; }
       //}
        public void Add(T item )
        {
            this.data.Add(item);
        }
        public T this[int index]
        {
            get
            {
                return this.data[index];
            }
        }
    }
}
