using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace ListExercises
{
    class Numbers
    {
        public static List<int> FindEven(List<int> numList) 
        {
            List<int> evenList = new List<int>();

            foreach (int num in numList)
            {
                if (Equals(num % 2, 0))
                {
                    evenList.Add(num);
                }
            }
            return evenList;
        }

        public static List<string> FindByLength(string sentences)
        {
            List<string> wordList = new List<string>();
            List<string> foundWords = new List<string>();
            string input;

            foreach (string word in sentences.Split(' '))
            {
                if (word.IndexOf('.') > -1)
                {
                    wordList.Add(word.Substring(0, word.Length - 1));
                }
                else if (word.IndexOf(',') > -1)
                {
                    wordList.Add(word.Substring(0, word.Length - 1));
                }
                else 
                {
                    wordList.Add(word);
                }
            }
            
            Console.Write("Enter the word length limit: ");
            input = Console.ReadLine();

            foreach (string word in wordList)
            {
                if (Equals(word.Length, int.Parse(input)))
                {
                    foundWords.Add(word);
                }
            }

            return foundWords;
        }
    }
}
