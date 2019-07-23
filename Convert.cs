using System;
using System.Security.Authentication;

namespace CurrencyConverter
{
    public class Convert
    {
        public static  char[] currencyCharacters = {'€','$'}; //Support for curency characters
        public static char currencyOutChar;
        public static char currencyInChar;
        
        
        float _output;

        public static void Dialogue(string[] args)
        {
            Console.Write("\nWhat is the currency you want to convert from? (Available: 'Euro', 'Dollar') "); //Asks and reads the currency to convert from
            var currencyInputFrom = Console.ReadLine();
                
            Console.Write("\nWhat is the currency you want to convert to? (Available: 'Euro', 'Dollar') "); //Asks and reads the currency to convert to
            var currencyInputTo = Console.ReadLine();
                
            Console.Write("\nAmount? ");
            var amount = System.Convert.ToSingle(Console.ReadLine()); //Asks and reads the amount of money to convert to.
                
            Convert exchanger = new Convert();
            var output = exchanger.ConvertCurrency(amount, currencyInputFrom, currencyInputTo); //converts the amount from the given input to the given output
            var exchangeIn = CurrencyFormat.FormattingCurrency(amount.ToString(), currencyInChar); //changes currency to appropriate format
            var exchangeOut = CurrencyFormat.FormattingCurrency(output.ToString(), currencyOutChar); //changes currency to appropriate format


            Console.WriteLine("\n" + exchangeIn + " is " + exchangeOut); 

                Console.ReadKey();
                //TODO: Implement asking the user if they want to restart the application.
        }

        
        public float ConvertCurrency(float x, string y, string z) //float x for the value to convert, string y for the entered input currency, string z for the entered output currency
        {
            //TODO: Rework this part to be less awful and more simple.
            
            if (y == "euro" || y == "Euro")
                y = "€";
            if (y == "dollar" || y == "Dollar")
                y = "$";

            if (z == "euro" || z == "Euro")
                z = "€";
            if (z == "dollar" || z == "Dollar")
                z = "$";
            
            if (y == "€")
            {
                currencyInChar = currencyCharacters[0]; //Sets input currency to Euro
                
                if (z == "$")
                {
                     _output = x * ConversionTable.euroDollar;
                     currencyOutChar = currencyCharacters[1]; //Sets output currency character to Dollar
                }

                if (z == "€")
                {
                    _output = x;
                    currencyOutChar = currencyCharacters[0]; //Sets output currency to Euro
                }
            }

            if (y == "$")
            {
                currencyInChar = currencyCharacters[1]; //Sets input currency character to Dollar

                if (z == "€")
                {
                    _output = x * ConversionTable.dollarEuro;
                    currencyOutChar = currencyCharacters[0]; //Sets output currency character to Dollar


                }

                if (z == "$")
                {
                    _output = x;
                    currencyOutChar = currencyCharacters[1];  //Sets output currency character to Dollar

                }
            }
            //float output = x * 1.12f;
            return _output; //Returns the value of the conversion.
        }
        
        
    }
}