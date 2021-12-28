using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_dav2_2
{
    class MyList<T>
    {
        Dictionary<int, T> myDictionary = new Dictionary<int, T>();

        private int MySize;

        public MyList()
        {
            MySize = 0;
        }

        public bool isEmpty() { return MySize == 0; }
        public void Delete(int position)
        {
            if (isEmpty())
            {
                Console.WriteLine("!!!List is empty !!!");
            }
            else if (position < 0 || position >= MySize)
            {
                Console.WriteLine("!!! Wrong position !!!");
            }
            else
            {
                
                myDictionary.Add(MySize, myDictionary[0]);

                for (int i = position; i < MySize; i++)
                {
                    myDictionary[i] = myDictionary[i + 1];
                }

                myDictionary.Remove(MySize);

                MySize--;
            }
        }
        public void Add(T element, int position)
        {
            if (position < 0 || position > MySize)
            {
                Console.WriteLine("!!! wrong position !!!");
            }
            else
            {
                for (int i = MySize; i > position; i--)
                {
                    myDictionary[i] = myDictionary[i - 1];
                }
                myDictionary[position] = element;
                
                MySize++;
            }
        }
        public int Count() { return MySize; }
        public T ElementByIndex(int index)
        {
            if (index < 0 || index > MySize - 1)
            {
                Console.WriteLine("!!! wrong index !!!");
                return myDictionary[-1];
            }
            else
            {
                return myDictionary[index];
            }
        }
        public void show()
        {
            for (int i = 0; i < MySize; i++)
            {
                if (i % 5 == 0) Console.WriteLine();
                Console.Write($"index- {i} element- {myDictionary[i]};    ");
            }
        }

    }

}
