
namespace _01_First_Example
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
    class MyCustomClass<T>
    {
        List<T> dataStorage;
        public MyCustomClass()
        {
            this.dataStorage = new List<T>();
        }
        public int Count => dataStorage.Count;
        public void Add(T item)
        {
            dataStorage.Add(item);
        }
        public T this[int index]
        {
            get
            {
                return this.dataStorage[index];
            }
            set
            {
                this.dataStorage[index] = value;
            }
        }
       
        
    }

}
