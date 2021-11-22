using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Login
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Login Exercise");
            Console.Title = "LOGIN EXERCISE";

            string[] userNames =  { "monicag2",
                                   "rossgell2",
                                   "phoebeb1",
                                    };

            int maxAllowed = 3;
            int userAttempts = 1;
            bool checkUser = true;
            bool checkPassword = true;
            string monicag2PW = "ch@ndBing!";
            string rossgell2PW = "r@chemm@!";
            string phoebeb1PW = "Mlk4h@!";

            do
            {
                Console.Write("Please enter your username:  ");
                    string userName = Console.ReadLine().ToLower();

                for (int userCount = 0; userCount < userNames.Length; userCount++)
                {
                    if (userName == userNames[userCount])
                    {
                        checkUser = false;
                        do
                        {
                            Console.Write("Please enter your password: ");
                            string userPW = Console.ReadLine();

                            switch (userName)
                            {
                                case "monicag2":
                                    if (userPW == monicag2PW)
                                    {
                                        checkPassword = false;
                                        Console.WriteLine("Congratulations!  You have access!");
                                        break;
                                    }//end
                                    break;
                                case "rossgell2":
                                    if (userPW == rossgell2PW)
                                    {
                                        checkPassword = false;
                                        Console.WriteLine("Congratulations!  You have access!");
                                        break;
                                    }

                                    break;
                                case "phoebeb1":
                                    if (userPW == phoebeb1PW)
                                    {
                                        checkPassword = false;
                                        Console.WriteLine("Congratulations!  You have access!");
                                        break;
                                    }
                                    break;
                            //this will never be reached as it wil only do the switch if one of the 3 usernames above are entered correctly                         
                                default:
                                    break;
                            }//end switch

                            if (userAttempts < maxAllowed & checkPassword)
                            {
                                Console.WriteLine("Sorry...You have entered an incorrect password!");
                                Console.WriteLine("You have {0} attempt{1} left ", maxAllowed - userAttempts, maxAllowed - userAttempts == 1 ? "" : "s");

                                userAttempts++;
                            }//end else 

                            else if (checkPassword)
                            {
                                checkPassword = false;
                                Console.WriteLine("Sorry...you have reached max attempts allowed for entering password...Goodbye!");
                                break;
                            }//end else 
                        } while (checkPassword);
                    }//end if
                }//end for
                     //invalid user name has been entered
                     //should not hit below code if checkUser is false (good user name)
                     //needs to be outside of the for loop
                    if (userAttempts < maxAllowed & checkUser)
                    {
                        Console.WriteLine("Sorry...Invalid user name - please try again!");
                        Console.WriteLine("You have {0} attempt{1} left ", maxAllowed - userAttempts, maxAllowed - userAttempts == 1 ? "" : "s");
                    userAttempts++;
                } //end if
                else if (checkUser)
                    {
                        checkUser = false;
                        Console.WriteLine("Sorry...you have reached max attempts allowed for entering username...Goodbye!");
                        break;
                    }//end else

                } while (checkUser);

        }//end svm
    }//end class
}//end namespace
