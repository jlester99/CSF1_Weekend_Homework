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
            Console.WriteLine("Mad Lib");
            Console.Title = "MAD LIB";

            Console.WriteLine("Please enter values requested below to do this Mad Lib.  Unless otherwise instructed, verbs should be in standard present tense.  Adverbs are words that describe verbs and often end in 'ly'.  Adjectives are words that describe nouns.\n");

            //On Thanksgiving, my family gathers around the table for dinner.  My dad always sits at the head of the table, while my mom sits at the other end.  We always, luckily, make sure there is plenty of turkey and stuffing for all.  Before we eat, we take turns saying what each is thankful for.  I always say that I am thankful for my family, friends and dogs.  After we eat, some will go outside to play sports, while others will stay in and play board games or just nap.  Thanksgiving is always fun with my family!

            Console.Write("Holiday : ");
            string holiday = Console.ReadLine();

            Console.Write("Noun : ");
            string noun1 = Console.ReadLine();

            Console.Write("Plural Verb (ending in 's') : ");
            string pverb1 = Console.ReadLine();

            Console.Write("Noun : ");
            string noun2 = Console.ReadLine();

            Console.Write("Adverb : ");
            string adverb1 = Console.ReadLine();

            Console.Write("Noun : ");
            string noun3 = Console.ReadLine();

            Console.Write("Noun : ");
            string noun4 = Console.ReadLine();

            Console.Write("Verb (ending in 'ing') : ");
            string ingVerb = Console.ReadLine();

            Console.Write("Noun : ");
            string noun5 = Console.ReadLine();

            Console.Write("Noun : ");
            string noun6 = Console.ReadLine();

            Console.Write("Noun : ");
            string noun7 = Console.ReadLine();

            Console.Write("Verb : ");
            string verb1 = Console.ReadLine();

            Console.Write("Verb : ");
            string verb2 = Console.ReadLine();

            Console.Write("Adjective : ");
            string adjective = Console.ReadLine();

            Console.WriteLine($"On {holiday}, my family gathers around the {noun1} for dinner.  My dad always {pverb1} at one end of the {noun2}, while my mom {pverb1} at the other end.  We always, {adverb1}, make sure there is plenty of {noun3} and {noun4} for all.  Before we {verb1}, we take turns {ingVerb} what each is thankful for.  I always say that I am thankful for my {noun5}, {noun6} and {noun7}.  After we {verb1}, some of us will go outside to {verb2} sports, while others will stay in and {verb2} board games or just nap.  {holiday} is always {adjective} with my family!");

            //Result:
                //Mad Lib
                //Please enter values requested below to do this Mad Lib.Unless otherwise instructed, verbs should be in standard present tense.Adverbs are words that describe verbs and often end in 'ly'. Adjectives are words that describe nouns.

                //Holiday : Valentines Day
                //Noun: car
                //Plural Verb(ending in 's') : walks
                //Noun : house
                //Adverb : urgently
                //Noun : building
                //Noun : phone
                //Verb(ending in 'ing') : driving
                //Noun : laptop
                //Noun : chair
                //Noun : mirror
                //Verb : run
                //Verb : skip
                //Adjective : silly
                //On Valentines Day, my family gathers around the car for dinner.  My dad always walks at one end of the house, while my mom walks at the other end.  We always, urgently, make sure there is plenty of building and phone for all.  Before we run, we take turns driving what each is thankful for.  I always say that I am thankful for my laptop, chair and mirror.  After we run, some of us will go outside to skip sports, while others will stay in and skip board games or just nap.  Valentines Day is always silly with my family!
                //Press any key to continue . . .

        }// end svm
    }// end class
}// namespace

