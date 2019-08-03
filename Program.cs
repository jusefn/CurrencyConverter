/*TODO: Program should ask if user wants to convert or list convertion tables. DONE
 TODO: Program should distinguish between Euro to Dollar and Dollar to Euro. DONE
 TODO: User should be able to change the conversion from one currency to another as it obviously chances constantly.
 TODO: Make the code less awful if anyone stumbles across this code sorry in advance and have a nice day.
 TODO: Also ask the user if they want to run the program again. DONE
For now only Euro to Dollar and Dollar to Euro is planned.*/


using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            SelectionMenu.Menu(args);

        }
    }
    
}