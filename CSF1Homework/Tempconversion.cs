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
            bool reRun = true;
            do
            {
                Console.WriteLine(@"
Please Pick from the following:
1) Celsius to Fahrenheit
2) Fahrenheit to Celsius
");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.Write("Please Enter your Celsius Temperature: ");
                        double C = Convert.ToDouble(Console.ReadLine());

                        double F = (C * 1.8) + 32;

                        Console.WriteLine("Celsius: {0} --> Fahrenheit: {1}", C, F);
                        Console.WriteLine("Do you want to go again? Y or N? ");
                        string input = (Console.ReadLine());
                        if (input == "N")
                            reRun = false;
                        Console.WriteLine("GoodBye");
                        break;

                    case "2":
                        Console.Write("Please Enter your Fahrenheit Temperature: ");
                        double F2 = Convert.ToDouble(Console.ReadLine());

                        double C2 = (F2 - 32) * 5 / 9;
                        Console.WriteLine("Fahrenheit: {0} --> Celsius: {1}", F2, C2);

                        Console.WriteLine("Do you want to go again? Y or N? ");
                        string input2 = (Console.ReadLine());
                        if (input2 == "N")                            
                            reRun = false;
                        Console.WriteLine("GoodBye");
                        break;
                }
            } while (reRun);
        }//end svm
    }//end class
}// end namespace
