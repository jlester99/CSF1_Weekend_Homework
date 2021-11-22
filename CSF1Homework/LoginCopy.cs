//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSF1Homework
//{
//    class LoginCopy
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Login Exercise");
//            Console.Title = "LOGIN EXERCISE";

//            string[] userNames =  { "monicag2",
//                                   "rossgell2",
//                                   "phoebeb1",
//                                    };

//            int nameAttempts = 1;
//            int maxNameAttempts = 3;
//            bool checkUser = true;
//            bool checkPassword = true;
//            int pwAttempts = 1;
//            int maxPWAttempts = 3;
//            string monicag2PW = "ch@ndBing!";
//            string rossgell2PW = "r@chemm@!";
//            string phoebeb1PW = "Mlk4h@!";

//            do
//            {
//                Console.Write("Please enter your username:  ");

//                for (int userCount = 0; userCount < userNames.Length - 1; userCount++)
//                {
//                    string userName = Console.ReadLine().ToLower();
//                    Console.WriteLine("On index of " + userCount);
//                    if (userName == userNames[userCount])
//                    {
//                        checkUser = false;
//                        do
//                        {
//                            Console.Write("Please enter your password: ");
//                            string userPW = Console.ReadLine();

//                            switch (userName)
//                            {
//                                case "monicag2":
//                                    if (userPW == monicag2PW)
//                                    {
//                                        checkPassword = false;
//                                        Console.WriteLine("Congratulations!  You have access!");

//                                    }//end
//                                    break;
//                                case "rossgell2":
//                                    if (userPW == rossgell2PW)
//                                    {
//                                        checkPassword = false;
//                                        Console.WriteLine("Congratulations!  You have access!");
//                                    }
//                                    break;
//                                case "phoebeb1":
//                                    if (userPW == phoebeb1PW)
//                                    {
//                                        checkPassword = false;
//                                        Console.WriteLine("Congratulations!  You have access!");
//                                    }
//                                    break;
//                                default:
//                                    Console.WriteLine("Sorry...You do not have access!");
//                                    break;
//                            }//end switch
//                            //Console.WriteLine("pw Attempts = " + pwAttempts);
//                            if (pwAttempts < maxPWAttempts & checkPassword)
//                            {
//                                Console.WriteLine("Sorry...You have entered an incorrect password!");
//                                Console.WriteLine("You have " + (maxPWAttempts - pwAttempts) +
//                                " attempts left");
//                                pwAttempts++;
//                            }//end else 
//                            else if (checkPassword)
//                            {
//                                checkPassword = false;
//                                // Console.WriteLine("Sorry...You do not have access!");
//                                Console.WriteLine("Max attempts reached for entering password!");
//                                break;
//                            }//end else 
//                        } while (checkPassword);
//                        break;
//                    }//end if
//                     //invalid user name has been entered
//                     //should not hit below code if checkUser is false (good user name)
//                     //- but if password max attempts reached, it still executes it - why?
//                    else if (nameAttempts < maxNameAttempts)
//                    {
//                        Console.WriteLine("Sorry...Invalid user name - please try again!");
//                        Console.WriteLine("You have " + (maxNameAttempts - nameAttempts) + " attempts left");
//                        nameAttempts++;
//                        break;
//                    } //end else if
//                    else
//                    {
//                        checkUser = false;
//                        Console.WriteLine("Sorry...You do not have access!");
//                        Console.WriteLine("Max attempts reached!");
//                        break;
//                    }//end else

//                }//end for
//            } while (checkUser);

//        }//end svm
//    }//end class
//}//end namespace
