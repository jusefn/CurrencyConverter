/*TODO: Program should ask if user wants to convert or list convertion tables.
 TODO: Program should distinguish between Euro to Dollar and Dollar to Euro.
 TODO: User should be able to change the conversion from one currency to another as it obviously chances constantly.
 TODO: Make the code less awful if anyone stumbles across this code sorry in advance and have a nice day.
 TODO: Also ask the user if they want to run the program again.
For now only Euro to Dollar and Dollar to Euro is planned.*/


using System;


namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to the Currency Converter!" +
                          "\nPlease make your selection: ");

            var selection = Console.ReadLine();

            if (selection == "convert")
            {
                Console.Write("\nWhat is the currency you want to convert from? "); //Asks and reads the currency to convert from
                var currencyInputFrom = Console.ReadLine();
                
                Console.Write("\nWhat is the currency you want to convert to? "); //Asks and reads the currency to convert to
                var currencyInputTo = Console.ReadLine();
                
                Console.Write("\nAmount? ");
                var amount = System.Convert.ToSingle(Console.ReadLine());
                
                Convert euroDollar = new Convert();
                var output = euroDollar.ConvertCurrency(amount);

                Console.WriteLine(System.Convert.ToString(output));
                Console.ReadKey();

            } 
            else if (selection == "table")
            {
                
            }


        }
    }

    
    
    class Convert
    {
        public float ConvertCurrency(float x)
        {
            float euroDollar = 1.12f;
            float output = x * 1.12f;
            return output;
        }
        
        
    }

    class ConversationTable
    {
        
        
    }
}