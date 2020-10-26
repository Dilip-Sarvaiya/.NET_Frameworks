using System;

namespace Interface_Properties
{
    interface IValues
    { 
        void getValues();
    }
    interface ICalculate
    {
        void compute_area();
    }
    class AreaCalculate : IValues, ICalculate
    {
        double width;
        double height;
        double area;

        public void getValues()
        { 
            Console.Write("Enter the Width: ");
            width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Height: ");
            height = Convert.ToDouble(Console.ReadLine());
        }
        public void compute_area()
        {
            area = width * height;
            Console.WriteLine("Area of Rectangle: " + area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AreaCalculate fe = new AreaCalculate();
            fe.getValues();
            fe.compute_area();
        }
    }
}
