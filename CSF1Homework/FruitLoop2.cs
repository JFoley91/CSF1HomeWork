using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop2
    {
        static void Main(string[] args)
        {

            string[] fruit = { "apple", "banana", "grape", "plum", "kiwi", "tomato" };
            string[] dot = { "one dot", "two dots", "three dots", "four dots", "five dots", "six dots" };

            string dots = "";

            for (int f = 0; f < fruit.Length; f++)
            {
              
                    dots += ".";
                    Console.WriteLine(fruit[f] +
                        "\n" + dot[f] + dots);
                

            }






        }//end svm
    }//end class
}//end namespace
