using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace RandomZahl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen beim Number guesser");
            Stopwatch timer = new Stopwatch();
            Console.WriteLine("Die Zeit startet sobald sie Enter drücken");
            Console.ReadKey();
            timer.Start();


            Random Zahl = new Random();
            int guess = 0;
            Console.WriteLine("Gib Random Zahl zwischen 1 und 100 ein"); 
            int rand_num = Zahl.Next(1, 101);

            int AktiverLoop = 1;

            while (AktiverLoop == 1)
            {


                guess = Convert.ToInt32(Console.ReadLine());
                if (guess > rand_num)
                {

                    Console.WriteLine("Die Zahl ist zu gross.Geben sie eine kleinere Zahl ein.");
                }
                if (guess < rand_num)
                {

                    Console.WriteLine("Die Zahl ist zu klein. Geben sie eine grössere Zahl ein.");
                }

                if (guess == rand_num)
                {

                    Console.WriteLine("Sie haben die richtige Zahl erraten:");
                    AktiverLoop = 0;

                }
            }

            timer.Stop();
            long TotalMiliseconds = timer.ElapsedMilliseconds;
            float seconds = ((float)TotalMiliseconds/1000);
            Console.WriteLine("Deine Zeit: "+ seconds);
        }

                
                       
                        
    }
}