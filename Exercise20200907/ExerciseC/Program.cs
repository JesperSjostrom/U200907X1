using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseC
{
    class Program
    {
        static void Main(string[] args)
        {
            //det här är till uppgift 5 jag hoppade över de innan för jag inte vet hur man skulle göra.
            Console.WriteLine("Skriv vad du vill men om du skriver quit så stängs programmet.");
            String text = Console.ReadLine();
            string strquit = Console.ReadLine();

            if (strquit.Equals("quit"))

            {

                System.Environment.Exit(0);

            }

            Console.ReadLine();
        }
    }
}
