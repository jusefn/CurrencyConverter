using System;
using System.Runtime.CompilerServices;

namespace CurrencyConverter //Program picks conversions from this class.
{
 
    public class ConversionTable
    {
        
        public static void Dialogue(string[] args)
        {
            var currentEuro = CurrencyFormat.FormattingCurrency(dollarEuro.ToString(), Convert.currencyCharacters[0]); //changes currency to appropriate format
            var currentDollar = CurrencyFormat.FormattingCurrency(euroDollar.ToString(), Convert.currencyCharacters[1]); //changes currency to appropriate format


    
            Console.WriteLine("\nThese are the current available conversion tables\n" +
                              "1€ is " + currentDollar + " Dollar\n" +
                              "$1 is " + currentEuro + " Euro");
            Console.ReadKey();
            //TODO: Implement asking the user if they want to restart the application.

        }

     
        
        public static decimal euroDollar = (Decimal)1.12f; //currentish exchange rate 
        public static decimal dollarEuro = (Decimal)0.89f; //currentish exchange rate 

    }
}