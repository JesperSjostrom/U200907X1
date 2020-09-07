using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseA
{
    class Program
    {
        static void Main(string[] args)
        {
            //uppgift 1
            Console.WriteLine("Skriv en mening:");
            String mening = Console.ReadLine();
            int wordCount = 0;

            for (int i = 0; i < mening.Length - 1; i++)
            {

                if (mening[i] == ' ' && Char.IsLetter(mening[i + 1]) && (i > 0))
                {
                    wordCount++;
                }
            } 
            wordCount++;
 
            Console.WriteLine("Totalt nummer av ord: " + wordCount);
            Console.ReadLine();
        }
    }
}
