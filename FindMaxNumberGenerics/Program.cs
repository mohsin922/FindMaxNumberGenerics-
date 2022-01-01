using System;

namespace FindMaxNumberGenerics
{
    class Program
    {
        public float FindMaximumFloat(float first, float second, float third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else if (third.CompareTo(second) > 0 && third.CompareTo(first) > 0)
            {
                return third;
            }
            else
            {
                Console.WriteLine("Same Numbers");
                return -1;
            }
        }

        static void Main(string[] args)
        {
            Program Max = new Program();
            Console.WriteLine("Maximum value is : " + Max.FindMaximumFloat(112.2f, 345.3f, 165.6f));
        }
    }
}