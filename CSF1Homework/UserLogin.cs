using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class UserLogin
    {
        static void Main(string[] args)
        {
            //Login Attempts counter
            int loginAttempts = 0;

            //Simple iteration upto three times
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter username");
                string username = Console.ReadLine();
                string upperUsername = username.ToUpper();
               
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();
                string upperPassword = password.ToUpper();
 

                if (upperUsername != "USERNAME" || upperPassword != "PASSWORD")
                    loginAttempts++;
                else
                    break;
            }

            //Display the result
            if (loginAttempts > 2)
                Console.WriteLine("Login failure");
            else
                Console.WriteLine("Login successful");

            Console.ReadKey();

        }//end svm
    }//end class
}//end namespace
