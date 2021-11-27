using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class MadLib
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a plural noun: ");
            string pNoun = Console.ReadLine();

            Console.Write("Enter a adjective: ");
            string adjective = Console.ReadLine();

            Console.Write("Enter a noun: ");
            string noun = Console.ReadLine();

            Console.Write("Enter a verb: ");
            string verb = Console.ReadLine();

            Console.Write("Enter a adjective: ");
            string adjectiveTwo = Console.ReadLine();

            Console.Write("Enter a number: ");
            string number = Console.ReadLine();

            Console.Write("Enter a food: ");
            string food = Console.ReadLine();

            Console.Write("Enter a past tense verb: ");
            string ptVerb = Console.ReadLine();

            Console.Write("Enter a noun: ");
            string nounTwo = Console.ReadLine();

            Console.Write("Enter a location: ");
            string location = Console.ReadLine();

            Console.Write("Enter a location: ");
            string locationTwo = Console.ReadLine();

            Console.Write("Enter a plural adverb: ");
            string adverb = Console.ReadLine();

            Console.WriteLine( );

            Console.WriteLine($"'But{pNoun} was so kid to him that at last, he grew tame and {adjective}. He became a mighty {noun}, but he would never {verb} bears. Neither would he ever allow the {adjectiveTwo} mother bear or her {number} cubs to be hurt. Often, in the winters, he carried {food} to their den. He was {ptVerb} the Bear, and we, who belonged to his family, who are of his {nounTwo}, are called Bears to this day. All the Bears in the {location} and in the {locationTwo} are our friend, and {adverb} do we hurt them.'");




        }//end svm
    }//end class
}//end namespace
