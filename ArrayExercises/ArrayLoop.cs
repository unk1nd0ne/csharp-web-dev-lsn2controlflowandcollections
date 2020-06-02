using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExercises
{
    class ArrayLoop
    {
        public static void Loop()
        {
            int[] numArray = { 1, 1, 2, 3, 5, 8 };

            foreach (int num in numArray)
            {
                if (!Equals(num % 2, 0))
                {
                    Console.WriteLine(num);
                }
                
            }
        }
            
    }
}
