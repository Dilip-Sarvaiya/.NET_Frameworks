using System;

namespace Interface_Delegate
{
    interface IMyInterface
    {
        int MySum(int a, int b);
    }

    public class MyClassTest : IMyInterface
    {
        public int MySum(int a, int b)
        {
            return a + b;
        }
    }    

    //Defining Delegate.    
    public delegate int MyDelegate(int a, int b);
    

    class Program
    {
        event MyDelegate MyEvent;
        static void Main(string[] args)
        {
            int a, b;
            IMyInterface myClassTest = new MyClassTest();
            try
            {
                Console.Write("Enter the first number: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the second number: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Addition of numbers: " + myClassTest.MySum(a, b));
             
                Console.WriteLine("-----By using Delegates------");
                MyDelegate myDelegate = myClassTest.MySum;
                Console.WriteLine("Multiplication of numbers: " + myDelegate(a, b));
                try
                {
                    Program mv = new Program();
                    int result = mv.MyEvent(a, b);
                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}