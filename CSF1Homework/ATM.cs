using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATM
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ATM Application");
            Console.Title = "ATM Application";

            string[] accountNumbers =  { "account1",
                                         "account2",
                                         "account3"
                                    };

            string userAccount = "";
            int maxAllowed = 3;
            int userAttempts = 1;
            bool checkAccount = true;
            bool checkPIN = true;
            string account1PIN = "123456";
            string account2PIN = "754895";
            string account3PIN = "854231";

            do
            {
                Console.Write("Please enter your Account Number:  ");
                userAccount = Console.ReadLine().ToLower();

                for (int userCount = 0; userCount < accountNumbers.Length; userCount++)
                {
                    if (userAccount == accountNumbers[userCount])
                    {
                        checkAccount = false;
                        userAttempts = 1;

                        do
                        {
                            Console.Write("Please enter your PIN: ");
                            string userPIN = Console.ReadLine();

                            switch (userAccount)
                            {
                                case "account1":
                                    if (userPIN == account1PIN)
                                    {
                                        checkPIN = false;
                                        //Console.WriteLine("Congratulations!  You have access!");
                                        break;
                                    }//end
                                    break;
                                case "account2":
                                    if (userPIN == account2PIN)
                                    {
                                        checkPIN = false;
                                        //Console.WriteLine("Congratulations!  You have access!");
                                        break;
                                    }

                                    break;
                                case "account3":
                                    if (userPIN == account3PIN)
                                    {
                                        checkPIN = false;
                                        //Console.WriteLine("Congratulations!  You have access!");
                                        break;
                                    }
                                    break;
                                //this will never be reached as it wil only do the switch if one of the 3 usernames above are entered correctly                         
                                default:
                                    break;
                            }//end switch

                            if (userAttempts < maxAllowed & checkPIN)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Sorry...You have entered an incorrect PIN!  Please try again.\n");
                                Console.WriteLine("You have {0} attempt{1} left.\n", maxAllowed - userAttempts, maxAllowed - userAttempts == 1 ? "" : "s");

                                userAttempts++;
                            }//end else 

                            else if (checkPIN)
                            {
                                checkPIN = false;
                                Console.WriteLine("Sorry...you have reached max attempts allowed for entering PIN...Goodbye!");
                                break;
                            }//end else 
                        } while (checkPIN);
                    }//end if
                }//end for
                 //invalid user account has been entered
                 //should not hit below code if checkAccount is false (good account number)
                 //needs to be outside of the for loop
                if (userAttempts < maxAllowed & checkAccount)
                {
                    Console.WriteLine();
                    Console.WriteLine("Sorry...Invalid Account Number - please try again!");
                    Console.WriteLine();
                    Console.WriteLine("You have {0} attempt{1} left ", maxAllowed - userAttempts, maxAllowed - userAttempts == 1 ? "" : "s");
                    userAttempts++;
                } //end if
                else if (checkAccount)
                {
                    checkAccount = false;
                    Console.WriteLine();
                    Console.WriteLine("Sorry...you have reached max attempts allowed for entering Account Number...Goodbye!");
                    break;
                }//end else

            } while (checkAccount);

            bool enterTrans = true;
            double accountBalance = 0;
            string moreTrans = "";

            if (!checkAccount & !checkPIN)
            //add menu to choose an action - deposit, withdrawal, view balance or exit
            {
                do
                {
                    Console.WriteLine(  );
                    Console.WriteLine("Which action would you like to take? ");
                    Console.WriteLine(@"
D) Deposit
W) Withdrawal
B) Balance
E) Exit"
    );
                    Console.WriteLine();
                    string userChoice = Console.ReadLine().ToUpper();
                    Console.Clear();

                    switch (userChoice)
                    {
                        case "D":
                        case "DEPOSIT":
                            Console.Write("Please enter an amount to deposit to your account:  ");
                            double userDeposit = double.Parse(Console.ReadLine());
                            accountBalance += userDeposit;
                            Console.WriteLine("The requested amount of {0:c} has been deposited into {1}.  Your balance is now {2:c}.\n", userDeposit, userAccount, accountBalance);
                            Console.WriteLine();
                            Console.Write("Would you like to do another transaction Y/N? ");
                            moreTrans = Console.ReadLine().ToUpper();

                            if (moreTrans == "Y" || moreTrans == "YES")
                            {
                                enterTrans = true;
                            }//end if
                            else
                            {
                                Console.WriteLine("Thank you for using our ATM!  Have a great day!\n");
                                enterTrans = false;
                            }// end else
                            break;

                        case "W":
                        case "WITHDRAWAL":
                            Console.WriteLine();
                            Console.Write("Your current balance is {0:c}.  Please enter an amount to withdraw from your account:  ",accountBalance);
                            double userWithdrawal = double.Parse(Console.ReadLine());
                                                        
                            if (userWithdrawal > accountBalance)
                            {
                                Console.WriteLine("Insufficient Funds - Withdrawal not allowed!\n", accountBalance);
                                enterTrans = false;
                            }//end if
                            else
                            {
                                accountBalance -= userWithdrawal;
                                Console.WriteLine("The requested amount of {0:c} has been withdrawn from {1}.  Your new balance is {2:c}.\n", userWithdrawal, userAccount, accountBalance);
                                Console.WriteLine();
                            }//end else

                            Console.Write("Would you like to do another transaction Y/N? ");
                            moreTrans = Console.ReadLine().ToUpper();

                            if (moreTrans == "Y" || moreTrans == "YES")
                            {
                                enterTrans = true;
                            }//end if
                            else
                            {
                                Console.WriteLine("Thank you for using our ATM!  Have a great day!\n");
                                enterTrans = false;
                            }// end else
                            break;

                        case "B":
                        case "BALANCE":
                            Console.WriteLine();
                            Console.Write("Please enter an amount to withdraw from your account:  ");

                            Console.WriteLine("Account {0} has a balance of {1:c}.\n", userAccount, accountBalance);
                            Console.WriteLine();
                            Console.Write("Would you like to do another transaction Y/N? ");
                            moreTrans = Console.ReadLine().ToUpper();

                            if (moreTrans == "Y" || moreTrans == "YES")
                            {
                                enterTrans = true;
                            }//end if
                            else
                            {
                                Console.WriteLine("Thank you for using our ATM!  Have a great day!\n");
                                enterTrans = false;
                            }// end else
                            break;

                        case "X":
                        case "EXIT":
                        case "E":
                            enterTrans = false;
                            Console.WriteLine("Thank you for using our ATM!  Have a great day!\n");
                            break;

                        default:
                            Console.WriteLine();
                            Console.WriteLine("You did not choose a valid option. Goodbye.\n");
                            enterTrans = false;
                            break;
                    }//end switch

                } while (enterTrans);
            }//end if
        }//end svm
    }//end class
}//end namespace
