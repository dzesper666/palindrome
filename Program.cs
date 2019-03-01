using System;

namespace Wojtek
{
    class Program
    {
        static void Main(string[] args)
        {

            bool palindrom()
            {
                Console.WriteLine("Wprowadź tekst:");
                string kacper = Console.ReadLine();

                char[] kacperDoTablicy = kacper.ToCharArray();

                Array.Reverse(kacperDoTablicy);

                string kacperWstringu = new String(kacperDoTablicy);

                Console.WriteLine();
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Twój teskt po odwróceniu wygląda tak: ");
                Console.WriteLine(kacperWstringu);
                System.Threading.Thread.Sleep(2000);

                if (kacper == kacperWstringu)
                {
                    Console.WriteLine();
                    Console.WriteLine("Więc:");
                    Console.WriteLine("TAK - wprowadzony przez Ciebie tekst jest palindromem");
                    return true;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Więc:");
                    Console.WriteLine("NIE - wprowadzony przez Ciebie tekst nie jest palindromem");
                    return false;
                }
            }

            palindrom();

        }
    }
}



