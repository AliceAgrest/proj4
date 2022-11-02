using System;

namespace proj4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meot, ahadot, asarot,rndnum, memuza = 0, schum = 0;
            Random rnd = new Random();
            
            for (int i = 100; i < 1000; i++)
            {
                rndnum = rnd.Next(100, 1000);
                meot = rndnum / 100;
                asarot = (rndnum / 10) % 10;
                ahadot = rndnum % 10;

                if ((ahadot + asarot == meot) && (meot - asarot == ahadot))
                {
                    Console.WriteLine($"Your lucky number is {rndnum}");
                    schum = schum + rndnum;
                    memuza = memuza + 1;
                }
            }
            Console.WriteLine($"The average of all lucky numbers is {schum / memuza}");

            Console.ReadLine();
        }
    }
}
