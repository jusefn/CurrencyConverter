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
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Welcome to the Currency Converter!\n" +
                          "This Program only supports conversions between Euro and Dollar as of right now.\n" +
                          "You can select between 'convert' and 'table'." +
                          "\nPlease make your selection: ");

            var selection = Console.ReadLine();

            if (selection == "convert" || selection == "Convert")
            {
                Convert.Dialogue(args); //If convert is selected, program should start the code in Convert.cs

            } 
            else if (selection == "table" || selection == "Table" )
            {
                ConversionTable.Dialogue(args); //If table is selected, program should start the code in
                                                //ConversionTable.cs
            }


        }
    }
    
}