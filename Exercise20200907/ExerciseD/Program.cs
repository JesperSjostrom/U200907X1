using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseD
{
    class Program
    {
        static void Main(string[] args)
        {
            //uppgift 6
            Console.WriteLine("Gissa på ett tal mellan 1-21");
            String gissa = Console.ReadLine();
            int randomNumber;
            Random randm = new Random();
            randomNumber = randm.Next(1, 21);
            Console.WriteLine("Du fick nummret " + randomNumber);
            int num = 1;
            //Vet inte hur jag ska koppla "if" till det rätta random svaret så jag skrev bara en 1a.
            if (num == 1) 
            {
                Console.WriteLine("Du svarade rätt!");
            }

            Console.ReadLine();

        }
    }
}
