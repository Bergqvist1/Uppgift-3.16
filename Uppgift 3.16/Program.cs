using System;
namespace Uppgift_3_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur lång är den låten du vill spela upp, svar först i minuter (alltså t.ex låten är 3min 50 sek skriv bara 3"); 
            int minuter = int.Parse(Console.ReadLine());

            

            Console.WriteLine("Svara nu i hur många sekunder (alltså om den är 3 min 50 sek skriv 50)");
            int sekunder = int.Parse(Console.ReadLine());

              int Summa = minuter * 60 + sekunder;

            if(Summa <=260 && Summa >=165)
            {
                Console.WriteLine("Vi kan spela din låt :)");
            }

            else
            {
                Console.WriteLine("Tyvärr vi kan inte spela din låt");
            }

        }
    }
}
