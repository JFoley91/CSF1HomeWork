using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Tempconversion
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine(@"
Please Pick from the following:
1) Celsisu to Fahrenheit
2) Fahrenheit to Celisu
");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.Write("Please Enter your Celsisu Temperature: ");
                        double C = Convert.ToDouble(Console.ReadLine());

                        double F = (C * 1.8) + 32;

                        Console.WriteLine("Celsius: {0} --> Fahrenheit: {1}", C, F);
                        break;

                    case "2":
                        Console.Write("Please Enter your Fahrenheit Temperature: ");
                        double F2 = Convert.ToDouble(Console.ReadLine());

                        double C2 = (F2 - 32) * 5 / 9;
                        Console.WriteLine("Fahrenheit: {0} --> Celsius: {1}", F2, C2);
                        break;

                    default:
                        Console.WriteLine("Do you have another Temperature? ");
                        string runProgram = Console.ReadLine().ToUpper();                       
                        break;
               }
            } while (false);



        }//end svm
    }//end class
}// end namespace
