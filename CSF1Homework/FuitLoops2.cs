using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FuitLoops2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fruit Loops 2");
            Console.Title = "FRUIT LOOPS 2";

            string[] fruitLoops1 = { "apple", "bananna", "orange", "apricot", "blueberry", "plum" };
            string period = "";

            for (int i = 0; i < fruitLoops1.Length; i++)
            {
                if (i != 0)
                {
                    period += ".";
                }
                Console.WriteLine(fruitLoops1[i]);
                Console.WriteLine(period);
                //index 0 will display no period - 5 periods will be the 6th fruit (plum)
            }
        }// end SWM
    }// end class
}// end namespace
