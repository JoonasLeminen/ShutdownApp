﻿using System;

namespace ShutdownApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shutdown app v0.1\n");
            bool isNumber;
            Console.WriteLine("Järjestelmän sammutus consolilla.");

            //Console.WriteLine("Järjestelmän sammutus/restart/hibernate consolista.");
            //Console.WriteLine("Valitse tehtävä numerolla \n1 Shutdown s \n2 Restart r \n3 Hibernate h");
            //string userInput1 = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Kirjoita aika alle minuutteina:\n");
            do
            {
                
                string userInput2 = Console.ReadLine();
                int evaluatedNumber;
                isNumber = int.TryParse(userInput2, out evaluatedNumber);
                int timeInSeconds = evaluatedNumber * 60;

                if (isNumber == true)
                {
                    if (timeInSeconds > 0)
                    {
                        System.Diagnostics.Process.Start("Shutdown", $"-s -t {timeInSeconds}");
                    }
                }
                else
                {
                    Console.WriteLine("Syötä vain numero");
                }
            } while (isNumber == false);

            Console.WriteLine($"Järjestelmä sammuu valitsemasi ajan kuluttua.");
            Console.WriteLine("Voit perua sammutuskomennon painamalla mitä tahansa näppäintä.");
            Console.ReadKey();
            System.Diagnostics.Process.Start("Shutdown", "-a");
        }
    }
}
