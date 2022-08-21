using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //Constructor - Class new olduğu anda direkt çalışır
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; //Geçici olarak elemanların tutulduğu yer
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }

        public int lenght
        {
            get { return items.Length; }
        }
        public T[] ArrayList
        {
            get { return items; }
        }
    }
}
