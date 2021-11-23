using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fizz Buzz");
            Console.Title = "Fizz Buzz";

            Console.Write("Please enter a number (between 1 and 32,000): ");
            short userNumber = short.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int number = 1; number <= userNumber; number++)
            {
                if (number % 5 == 0 && number % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }//end if
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }//end else if
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");

                }//end else if
                else
                {
                    Console.WriteLine("{0}", number);
                }//end else



            }//end for

        }//end svm
    }//end class
}//end namespace
