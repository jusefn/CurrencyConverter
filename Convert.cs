using System;

namespace CurrencyConverter
{
    public class Convert
    {
        float _output;

        public static void Dialogue(string[] args)
        {
            Console.Write("\nWhat is the currency you want to convert from? (Available: 'Euro', 'Dollar') "); //Asks and reads the currency to convert from
            var currencyInputFrom = Console.ReadLine();
                
            Console.Write("\nWhat is the currency you want to convert to? (Available: 'Euro', 'Dollar') "); //Asks and reads the currency to convert to
            var currencyInputTo = Console.ReadLine();
                
            Console.Write("\nAmount? ");
            var amount = System.Convert.ToSingle(Console.ReadLine());
                
            Convert euroDollar = new Convert();
            var output = euroDollar.ConvertCurrency(amount, currencyInputFrom, currencyInputTo);

            Console.WriteLine(amount + " " + currencyInputFrom + " is " + System.Convert.ToString(output) + " " + currencyInputTo);
            Console.ReadKey();
        }

        
        public float ConvertCurrency(float x, string y, string z)
        {
            
            if (y == "Euro")
            {
                if (z == "Dollar")
                {
                     _output = x * ConversionTable.euroDollar;
                }

                if (z == "Euro")
                {
                    _output = x;
                }
            }

            if (y == "Dollar")
            {
                if (z == "Euro")
                {
                    _output = x * ConversionTable.dollarEuro;

                }

                if (z == "Dollar")
                {
                    _output = x;
                }
            }
            //float output = x * 1.12f;
            return _output;
        }
        
        
    }
}