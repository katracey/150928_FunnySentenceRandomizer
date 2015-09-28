using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _150928_SentenceRandomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call method WriteSentence() to generate the sentence, write it, and then check if the user wants
            //to continue and continue or not. Could also call ContinueOrNot() method here instead. 
            WriteSentence();          
                     
        }
               
        static void WriteSentence()
        {
            //Use this method to generate the sentence
            //Creating arrays of options for each part of sentence
            string[] nouns = { "She", "He", "It", "The cat", "The mongoose", "The orange", "The trampoline", "Musicians", "Programmers", "The shake" };
            string[] verbs = { "ate", "barbequed", "chirped", "collided", "sang", "spoke", "cartwheeled", "dined", "watched", "directed" };
            string[] prepositions = { "with the monkeys", "on the porch", "under the moon", "after the storm", "before the prince", "over the lake", "in the gazebo", "between the lines", "during the festival", "with them all" };

            //Generating random numbers for each argument
            Random ranNoun = new Random();
            int nounNum = ranNoun.Next(0, (nouns.Length - 1));
            Random ranVerb = new Random();
            int verbNum = ranVerb.Next(0, (verbs.Length - 1));
            Random ranPrep = new Random();
            int prepNum = ranPrep.Next(0, (prepositions.Length - 1));

            //Calling sentence builder (next method), then writing to console                      
            string newSentence = BuildSentence(nouns[nounNum], verbs[verbNum], prepositions[prepNum]);
            Console.WriteLine(newSentence);

            ContinueOrNot();           
                       
        }

        static string BuildSentence(string noun, string verb, string preposition)
        {
            //Use StringBuilder to combine the sentence parts.
            StringBuilder sentence = new StringBuilder();
            string sentenceResult = Convert.ToString(sentence.Append(noun + " " + verb + " " + preposition + "."));
            return sentenceResult;
        }

        static void ContinueOrNot()
        {
            //checks if user wants to continue, then continues or doesn't
            Console.WriteLine("Would you like to continue?");
            Console.Write("Y/N: ");
            string answer = Console.ReadLine();

            if (answer == "Y")
            {
                WriteSentence();
                ContinueOrNot();
            }
            else if (answer == "N")
            {
                Environment.Exit(0);
            }
        }
    }
}
