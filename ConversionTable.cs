using System;

namespace CurrencyConverter //Program picks conversions from this class.
{
 
    public class ConversionTable
    {
        
        public static void Dialogue(string[] args)
        {
    
            Console.WriteLine("\nThese are the current available conversion tables\n" +
                              "1 Euro is " + euroDollar + " Dollar\n" +
                              "1 Dollar is " + dollarEuro + " Euro");
            Console.ReadKey();
        }
        
        public static float euroDollar = 1.12f;
        public static float dollarEuro = 0.89f;

    }
}