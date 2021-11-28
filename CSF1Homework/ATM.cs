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
            double totalBalance = 50000;
            int depositAmount = 0;
            int withdrawAmount = 0;

            int loginAttempt = 0;
            for (int i = 0; i < 3; i++) ;

            int option = 0;
            int pin;

            bool repeat = true;
            do
            {
                Console.Write("ENTER YOUR PIN: ");
                pin = int.Parse(Console.ReadLine());

                while (pin == 1382 && option != 4)
                {
                    Console.WriteLine(@"
------SELECT ATM SERVICE------
1. Balance
2. Withdrawl
3. Deposit
4. Exit");
                    Console.Write("Please Select an Option: ");
                    option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Console.Write("\nYour total account balanace: $" + totalBalance);
                            break;
                        case 2:
                            Console.Write("\nEnter withdrawl amount: ");
                            withdrawAmount = int.Parse(Console.ReadLine());
                            if (withdrawAmount % 100 != 0)
                            {
                                Console.WriteLine("\nPlease enter withdrawl amount in multiples of 100");
                            }
                            else if (withdrawAmount > totalBalance)
                            {
                                Console.WriteLine("\nInsufficient Balance");
                            }
                            else
                            {
                                totalBalance = totalBalance - withdrawAmount;
                                Console.WriteLine("\nPlease Collect your money");
                                Console.WriteLine("\n your remaining balance is: $" + totalBalance);
                            }
                            break;
                        case 3:
                            Console.Write("\nEnter depoist amount: ");
                            depositAmount = int.Parse(Console.ReadLine());
                            totalBalance = totalBalance + depositAmount;
                            Console.WriteLine("Your Current Balance: $" + totalBalance);
                            break;
                        case 4:
                            Console.WriteLine("Thank you for your business, Goodbye!");
                            repeat = false;
                            break;
                    }//end switch
                    if (loginAttempt > 2)
                        Console.WriteLine("Login failure");
                    else
                        Console.WriteLine("Login successful");
                }//end while
            } while (repeat);//end do while
        }//end smv
    }//end class
}//end namespace