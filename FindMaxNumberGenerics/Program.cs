using System;

namespace FindMaxNumberGenerics
{
    class Program
    {
        public int FindMaximum(int first, int second, int third)
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
                Console.WriteLine("Numbers are same");
                return 1;
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            int maxValue = obj.FindMaximum(120, 35, 645);
            Console.WriteLine("Maximum of three values is : {0}", maxValue);
        }
    }
}