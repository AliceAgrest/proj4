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




//answer 1
            /*
            int n = 5;
            for(int i = 0;i < n;i++)
            {
                for(int x = 0;x < n;x++)
                {
                    Console.Write("1");
                }
                Console.WriteLine();
            }
            
            //answer 2
            int n1 = 0;
            for(int i = 5; i > n1;i--)
            {
                for(int x = 5;x > n1;x--)
                {
                    Console.Write(i % 2);
                }
                Console.WriteLine();
            }

            //answer 3
            int n2 = 5;
            for(int i = 0;i < 5; i++)
            {
                for(int x = 0;x < 5;x++)
                {
                    Console.Write(x % 2);
                }
                Console.WriteLine();
            }

            //answer 4
            int n3 = 3;
            Console.WriteLine("11111");
            for(int i = 1;i <= n3;i++)
            {
                for(int x = 1;x <= 5;x++)
                {
                    if (x == 1 || x == 5)
                        Console.Write(x % 2);
                    else
                        Console.Write("0");
                }
                Console.WriteLine();
            }
            Console.WriteLine("11111");
            
            //answer 5
            int n4 = 5;
            for(int i = 1;i <= n4; i++)
            {
                if (i % 2 == 1) 
                {
                    for (int x = 1; x <= n4; x++)
                        Console.Write(x % 2);
                }
                else
                {
                    for (int x = 0; x < n4; x++)
                        Console.Write(x % 2);
                }
                Console.WriteLine();
            }

            //answer 6
            int n5 = 5;
            for (int i = 1;i <= n5;i++)
            {
                for(int x = 1;x <= 5;x++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            //answer 7
            int n6 = 5;
            for(int i = 0;i <= n6; i++)
            {
                for(int x = 1;x <= n6;x++)
                {
                    Console.Write(x);
                }
                Console.WriteLine();
            }*/

            //answer 8
            int

            Console.ReadLine();
        }
    }
}
