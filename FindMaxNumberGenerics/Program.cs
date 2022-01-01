using System;

namespace FindMaxNumberGenerics
{
    class Program
    {
        public static int MaximumIntegerNumber(int Firstvalue, int secondvalue, int thirdvalue)
        {
            if (Firstvalue.CompareTo(secondvalue) > 0 && Firstvalue.CompareTo(thirdvalue) > 0 ||
                Firstvalue.CompareTo(secondvalue) >= 0 && Firstvalue.CompareTo(thirdvalue) > 0 ||
                Firstvalue.CompareTo(secondvalue) > 0 && Firstvalue.CompareTo(thirdvalue) >= 0)
            {
                return Firstvalue;
            }
            if (secondvalue.CompareTo(Firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0 ||
                secondvalue.CompareTo(Firstvalue) >= 0 && secondvalue.CompareTo(thirdvalue) > 0 ||
                secondvalue.CompareTo(Firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) >= 0)
            {
                return secondvalue;
            }
            if (thirdvalue.CompareTo(Firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0 ||
               thirdvalue.CompareTo(Firstvalue) >= 0 && thirdvalue.CompareTo(secondvalue) > 0 ||
               thirdvalue.CompareTo(Firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) >= 0)
            {
                return thirdvalue;
            }
            return Firstvalue;
        }
        public static double MaximumFloatNumber(double Firstvalue, double secondvalue, double thirdvalue)
        {
            if (Firstvalue.CompareTo(secondvalue) > 0 && Firstvalue.CompareTo(thirdvalue) > 0 ||
                Firstvalue.CompareTo(secondvalue) >= 0 && Firstvalue.CompareTo(thirdvalue) > 0 ||
                Firstvalue.CompareTo(secondvalue) > 0 && Firstvalue.CompareTo(thirdvalue) >= 0)
            {
                return Firstvalue;
            }
            if (secondvalue.CompareTo(Firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0 ||
                secondvalue.CompareTo(Firstvalue) >= 0 && secondvalue.CompareTo(thirdvalue) > 0 ||
                secondvalue.CompareTo(Firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) >= 0)
            {
                return secondvalue;
            }
            if (thirdvalue.CompareTo(Firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0 ||
               thirdvalue.CompareTo(Firstvalue) >= 0 && thirdvalue.CompareTo(secondvalue) > 0 ||
               thirdvalue.CompareTo(Firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) >= 0)
            {
                return thirdvalue;
            }
            return Firstvalue;
        }

        public static String MaximumstringValue(String FirstString, String Secondstring, String ThirdString)
        {
            if (FirstString.CompareTo(Secondstring) > 0 && FirstString.CompareTo(ThirdString) > 0 ||
                FirstString.CompareTo(Secondstring) >= 0 && FirstString.CompareTo(ThirdString) > 0 ||
                FirstString.CompareTo(Secondstring) > 0 && FirstString.CompareTo(ThirdString) >= 0)
            {
                return FirstString;
            }
            if (Secondstring.CompareTo(FirstString) > 0 && Secondstring.CompareTo(ThirdString) > 0 ||
                Secondstring.CompareTo(FirstString) >= 0 && Secondstring.CompareTo(ThirdString) > 0 ||
                Secondstring.CompareTo(FirstString) > 0 && Secondstring.CompareTo(ThirdString) >= 0)
            {
                return Secondstring;
            }
            if (ThirdString.CompareTo(FirstString) > 0 && ThirdString.CompareTo(Secondstring) > 0 ||
               ThirdString.CompareTo(FirstString) >= 0 && ThirdString.CompareTo(Secondstring) > 0 ||
               ThirdString.CompareTo(FirstString) > 0 && ThirdString.CompareTo(Secondstring) >= 0)
            {
                return ThirdString;
            }
            return FirstString;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MaximumIntegerNumber(30, 10, 5));
            Console.WriteLine(MaximumFloatNumber(344.5, 340.2, 52.3));
            Console.WriteLine(MaximumstringValue("Apple", "Banana", "Peach"));

        }
    }
}