using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace StringExercises
{
    class StringArray
    {
        public static void SplitJoin()
        {
            string practiceString = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
            string[] practiceArray = practiceString.Split(" ");
            Console.WriteLine(string.Join(",", practiceArray));
            practiceArray = practiceString.Split(".");
            Console.WriteLine(string.Join(".", practiceArray));

        }
    }
}
