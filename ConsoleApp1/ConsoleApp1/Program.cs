using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shutdown app v0.1");
            bool isNumber;
            Console.WriteLine("Järjestelmän sammutus consolilla.");

            //Console.WriteLine("Järjestelmän sammutus/restart/hibernate consolista.");
            //Console.WriteLine("Valitse tehtävä numerolla \n1 Shutdown s \n2 Restart r \n3 Hibernate h");
            //string userInput1 = Console.ReadLine();

            Console.WriteLine("Kirjoita aika alle sekunteina: ");
            do
            {
                
                string userInput2 = Console.ReadLine();
                int evaluatedNumber;
                isNumber = int.TryParse(userInput2, out evaluatedNumber);

                if (isNumber == true)
                {
                    if (evaluatedNumber > 0)
                    {
                        System.Diagnostics.Process.Start("Shutdown", $"-s -t {evaluatedNumber}");
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
