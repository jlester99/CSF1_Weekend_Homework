using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class TempConverter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Converter");
            Console.Title = "TEMPERATURE CONVERTER";

            // 1) Convert user requested Celsius temp to Fahrenheit
            Console.WriteLine();
            Console.Write("Please enter a temperature in Celsius to convert to Fahrenheit: ");
            double userCelsius = double.Parse(Console.ReadLine());
            //double compFahrenheit = (userCelsius * 9 / 5) + 32;
            //Console.WriteLine("Calculated F = " + compFahrenheit);
            Console.WriteLine();
            Console.WriteLine("The requested temperature (" + userCelsius + "\u00B0 C) converts to " + ((userCelsius * 9 / 5) + 32) + "\u00B0 F.\n");


            // 2) Convert user requested Fahrenheit temp to Celsius
            Console.WriteLine();
            Console.Write("Please enter a temperature in Fahrenheit to convert to Celsius: ");
            double userFahrenheit = double.Parse(Console.ReadLine());
            //double compCelsius = (userFahrenheit - 32) * 5 / 9;  //should be 100 - works (found formula on Google)
            //double compCelsius = (userFahrenheit - 32) / 9 / 5;  //should be 100 but doesn't work
            Console.WriteLine("The requested temperature (" + userFahrenheit + "\u00B0 F) converts to " + (userFahrenheit - 32) * 5 / 9 + "\u00B0 C.\n");
            //Console.WriteLine(userFahrenheit + "\u00B0 F converts to " + ((userFahrenheit - 32) / 9 / 5) + "\u00B0 C.");

        // 3) Add menu that allows user to choose which to convert and show result
        // 4) Ask user if they want to convert another temp after showing the result of the current one

            bool keepGoing = true;
            do
            {
                Console.WriteLine("Which temperature would you like to convert? ");
                Console.WriteLine(@"
C) Celsius
F) Fahrenheit"
);
                string userChoice = Console.ReadLine().ToUpper();
                Console.Clear();

                switch (userChoice)
                {
                    case "C":
                    case "CELSIUS":
                        Console.WriteLine();
                        Console.Write("Please enter a Celsius temperature to convert to Fahrenheit:  ");
                        double userInputC = double.Parse(Console.ReadLine());
                        Console.WriteLine("The requested temperature (" + userInputC + "\u00B0 C) converts to " + ((userInputC * 9 / 5) + 32) + "\u00B0 F.\n");
                        Console.WriteLine();
                        Console.Write("Would you like to convert another temperature value Y/N? ");
                        string userResponse2 = Console.ReadLine().ToUpper();

                        if (userResponse2 == "Y" || userResponse2 == "YES")
                        {
                            keepGoing = true;
                        }//end if
                        else
                        {
                            Console.WriteLine("Thank you for using our temperature converter!  Have a great day!\n");
                            keepGoing = false;
                        }// end else
                        break;

                    case "F":
                    case "FAHRENHEIT":
                        Console.WriteLine();
                        Console.Write("Please enter a Fahrenheit temperature to convert to Celsius:  ");
                        double userInputF = double.Parse(Console.ReadLine());
                        Console.WriteLine("The requested temperature (" + userInputF + "\u00B0 F) converts to " + (userInputF - 32) * 5 / 9 + "\u00B0 C.\n");
                        Console.WriteLine();
                        Console.Write("Would you like to convert another temperature value Y/N? ");
                        string userResponse = Console.ReadLine().ToUpper();

                        if (userResponse == "Y" || userResponse == "YES")
                        {
                            keepGoing = true;
                        }//end if
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Thank you for using our temperature converter!  Have a great day!\n");
                            keepGoing = false;
                        }// end else
                        break;

                    

                    default:
                        Console.WriteLine();
                        Console.WriteLine("You did not choose a valid option. Goodbye.\n");
                        keepGoing = false;
                        break;
                }//end switch

            } while (keepGoing);

        }// end SVM
    }//end class
}//end namespace
