using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lists!");
            List<int> numList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<string> strList = new List<string> {"I", "walked", "alone", "streets", "world", "constable", "up", "down", "fire", "campsite"};
            string practiceString = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
            foreach (int num in Numbers.FindEven(numList))
            {
                Console.WriteLine(num);
            }
            foreach (string word in Numbers.FindByLength(practiceString))
            {
                Console.WriteLine(word);
            }
        }
    }
}
