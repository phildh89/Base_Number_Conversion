using System;

namespace Base_Number_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: try catch positive input
            Console.WriteLine("Please enter the positive integer to convert: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the base to convert from [2 | 8 | 10]: ");
            int from = int.Parse(Console.ReadLine());

            Console.WriteLine($"Number: {number}, base: {from}");
            if (from == 10)
            {
                Console.WriteLine($"binary conversion is {dec2bin(number)}");
                Console.WriteLine($"octal conversion is {dec2oct(number)}");
            }
            else if (from == 2)
            {
                Console.WriteLine($"decimal conversion is {bin2dec(number)}");
                Console.WriteLine($"octal conversion is {bin2oct(number)}");
            }
            else if (from == 8)
            {
                Console.WriteLine($"binary conversion is {oct2bin(number)}");
                Console.WriteLine($"decimal conversion is {oct2dec(number)}");
            }
            else
                Console.WriteLine("Error in base to convert from");

        }

        public static string bin2oct(int input)    //binary to octal
        {
            string result = "";


            return result;
        }
        public static int bin2dec(int input)    //binary to decimal
        {
            int result = 0;
            double exponent = 0;
            for (int i = input.Length - 1; i >= 0 ; i--)
            {
                double baseValue = Math.Pow((double)input[i], exponent);

                result += Convert.ToInt32(baseValue);
                exponent++;
            }
           
            return result;
        }
        public static string oct2bin(int input)    //octal to binary
        {
            string result = "";


            return result;
        }
        public static string oct2dec(int input)    //octal to decimal
        {
            string result = "";


            return result;
        }
        public static string dec2bin(int input)    //decimal to binary
        {
            string result = "";


            return result;
        }
        public static string dec2oct(int input)    //decimal to octal
        {
            string result = "";


            return result;
        }
    }
}
