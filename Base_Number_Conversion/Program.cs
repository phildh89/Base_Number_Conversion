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

        public static int bin2oct(int input)    //binary to octal
        {
            int temp = bin2dec(input);
            int result = dec2oct(temp);

            return result;
        }
        public static int bin2dec(int input)    //binary to decimal
        {
            int result = 0;
            int inputLength = 1;
            int temp = input;

            //for loop finds length which will also be the exponent
            for (int i = 0; temp > 9; i++)
            {
                temp = temp / 10;
                inputLength++;
            }

            double exponent = inputLength - 1;
            //converting to decimal
            for (int i = inputLength; i > 0; i--)
            {
                temp = input / Convert.ToInt32(Math.Pow(10, exponent));
                if (temp == 1)
                {
                    input = input - Convert.ToInt32(Math.Pow(10, exponent));
                    result += Convert.ToInt32(Math.Pow(2, exponent));
                }
                exponent--;
            }

            return result;
        }
        public static int oct2bin(int input)    //octal to binary
        {
            int temp = oct2dec(input);
            int result = dec2bin(temp);

            return result;
        }
        public static int oct2dec(int input)    //octal to decimal
        {
            int result = 0;
            int inputLength = 1;
            int temp = input;

            //for loop finds length which will also be the exponent
            for (int i = 0; temp > 9; i++)
            {
                temp = temp / 10;
                inputLength++;
            }

            double exponent = inputLength - 1;
            //converting to decimal
            for (int i = inputLength; i > 0; i--)
            {
                temp = input / Convert.ToInt32(Math.Pow(10, exponent));     
                if (temp > 0 && temp < 8)
                {
                    input -= temp * Convert.ToInt32(Math.Pow(10, exponent));
                    result += (temp * Convert.ToInt32(Math.Pow(8, exponent)));
                }
                exponent--;
            }

            return result;
        }
        public static int dec2bin(int input)    //decimal to binary
        {
            int result = 0;
            int binCount = 0;
            //finding digits in binary
            for (int i = 0; Math.Pow (2, i) <= input ; i++)
            {
                binCount++;
            }

            int exponent = binCount - 1;
            //convert to binary
            for (int i = binCount; i > 0; i--)
            {
                if (Math.Pow(2, exponent) <= input)
                {
                    input -= Convert.ToInt32(Math.Pow(2, exponent));
                    result += Convert.ToInt32(Math.Pow(10, exponent));
                }
                exponent--;
            }

            return result;
        }
        public static int dec2oct(int input)    //decimal to octal
        {
            int result = 0;
            int binCount = 0;
            //finding digits in binary
            for (int i = 0; Math.Pow(8, i) <= input; i++)
            {
                binCount++;
            }

            int exponent = binCount - 1;
            //convert to binary
            for (int i = binCount; i > 0; i--)
            {
                if (Math.Pow(8, exponent) <= input)
                {
                    int octDigit = input / Convert.ToInt32(Math.Pow(8, exponent));
                    input -= octDigit * Convert.ToInt32(Math.Pow(8, exponent));
                    result += octDigit * Convert.ToInt32(Math.Pow(10, exponent));
                }
                exponent--;
            }

            return result;
        }
    }
}
