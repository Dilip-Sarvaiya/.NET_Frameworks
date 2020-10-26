 using System;

namespace Parameters
{

    class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers are....");
            int a = 4, b = 5;
            int[] array = { 1, 2, 3, 4, 5 };
            add_product(a, b);
            add_product(a, b, array);
        }
        public static void add_product(int value1, int value2, params int[] extra)
        {
            if (extra != null)
            {
                foreach (int i in extra)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
