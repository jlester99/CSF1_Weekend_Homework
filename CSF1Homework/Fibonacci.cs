using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci");
            Console.Title = "FIBONACCI";

            Console.Write("Please enter a number to retrieve the Fibonacci sequence list: ");
            long userNumber = long.Parse(Console.ReadLine());
            long fibNumber = 0;
            long prevFib = 1; // this will store the value of the previous number
            long prev2Fib = 0; //this will store the value of the 2 numbers before

            while (fibNumber <= userNumber)
            {
                Console.WriteLine(fibNumber);
                fibNumber = prevFib + prev2Fib;
                //prevFib is initially set at 1
                prev2Fib = prevFib;
                prevFib = fibNumber;

            }//end while

        }//end svm
    }//end class
}//end namespace
