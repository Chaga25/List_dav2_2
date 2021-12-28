using System;

namespace List_dav2_2
{
    class Program
    {
        static void Main()
        {
            MyList<int> i = new MyList<int>();

            i.show();
            i.Add(1, 0);
            i.Add(2, 1);
            i.Add(3, 2);
            i.Add(10, 2);
            i.show();

            i.Delete(2);
            i.show();

            Console.WriteLine();

            Console.WriteLine($"number of elements: {i.Count()}");

            Console.WriteLine($"Element by index:  index = 1 & element= {i.ElementByIndex(1)}");
        }
    }
}
