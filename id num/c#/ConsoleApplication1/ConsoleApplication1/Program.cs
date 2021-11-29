using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                //declear variables
                Int64 IdNumber;
                int sum_of_multps = 0;
                Int64[] digits = new Int64[10];
                int control_digit;


                //get ID number from user
                Console.WriteLine("Enter the ID Number");
                IdNumber = Convert.ToInt64(Console.ReadLine());

                // seprating the digits
                for (int i = 0; i < 10; i++)
                {
                    digits[i] = IdNumber % 10;
                    IdNumber /= 10;
                }

                //formula
                for (int i = 1; i < 10; i++)
                {
                    int multp = Convert.ToInt16(digits[i] * (i + 1));
                    sum_of_multps += multp;
                }
                control_digit = sum_of_multps % 11;


                //Print the output 

                if (control_digit < 2 && control_digit == digits[0])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Valid!");
                    Console.ResetColor();
                }

                else if ((11 - control_digit) == digits[0])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Valid!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid!");
                    Console.ResetColor();
                }
                Console.WriteLine("-------------------------------------");
            }
        }

    }
}
