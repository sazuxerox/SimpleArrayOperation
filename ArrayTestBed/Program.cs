using System;

namespace ArrayTestBed
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var carray = new CArray(10);
            //Display the array elements;

            var rnd = new Random(100);
            for (int i = 0; i < 10; i++)
            {
                carray.Insert((int)(rnd.NextDouble()*100));
            }
            Console.WriteLine("Before sorting the array is: ");
            carray.DisplayElements();

            Console.WriteLine();
            Console.WriteLine("During Sorting.......");
            carray.BubbleSort();

            Console.WriteLine();
            Console.WriteLine("After Sorting.......");
            carray.DisplayElements();
        }
    }
}
