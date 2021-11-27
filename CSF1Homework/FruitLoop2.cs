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
            string[] period = {"One Period", "Two Period", "Three Period", "Four Period," +
                    "Five Period", "Six Period" } ;

            for (int i = 0; i < fruit.Length; i++)
            {
                for (int n = 0; n < period.Length; n++)
                {
                    Console.WriteLine(fruit[i] + "\n" + period[i]);
                }
            }





        }//end svm
    }//end class
}//end namespace
