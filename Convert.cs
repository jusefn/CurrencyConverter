using System;
using System.Security.Authentication;

namespace CurrencyConverter
{
    public class Convert
    {
        public static readonly char[] currencyCharacters = {'€','$'}; //Support for curency characters
        
        private static char _currencyOutChar;
        private static char _currencyInChar;
        private static byte _valueOut;
        private static byte _valueIn;
        private static decimal _amount;

        
        
        decimal _output;

        public static void Dialogue(string[] args)
        {
            Console.Write("\nWhat is the currency you want to convert from? (Available: 'Euro', 'Dollar') "); //Asks and reads the currency to convert from
            var currencyInputFrom = Console.ReadLine();
            if (currencyInputFrom == "Euro" || currencyInputFrom == "euro" || currencyInputFrom == "€")
            {

                _valueIn = 0;
            }
            if (currencyInputFrom == "Dollar" || currencyInputFrom == "dollar" || currencyInputFrom == "$")
            {
                _valueIn = 1;
            }
            
                
            Console.Write("What is the currency you want to convert to? (Available: 'Euro', 'Dollar') "); //Asks and reads the currency to convert to
            var currencyInputTo = Console.ReadLine();
            if (currencyInputTo == "Euro" || currencyInputTo == "euro" || currencyInputTo == "€")
            {
                _valueOut = 0;
            }
            if (currencyInputTo == "Dollar" || currencyInputTo == "dollar" || currencyInputTo == "$")
            {
                _valueOut = 1;
            }
                
            Console.Write("\nAmount? ");
            var amountString = Console.ReadLine(); //Asks and reads the amount of money to convert to.
            _amount = System.Convert.ToDecimal(amountString);
            if (_valueIn == 0) //If the currency to exchange from is Euro, the comma is being replaced with a period to allow calculations.
            {
                _amount = System.Convert.ToDecimal(amountString.Replace(",", "."));

            }
                
            Convert exchanger = new Convert();
            var output = exchanger.ConvertCurrency(_amount, _valueIn, _valueOut); //converts the amount from the given input to the given output
            var exchangeIn = CurrencyFormat.FormattingCurrency(_amount.ToString(), _currencyInChar); //changes currency to appropriate format
            var exchangeOut = CurrencyFormat.FormattingCurrency(output.ToString(), _currencyOutChar); //changes currency to appropriate format


            Console.WriteLine("\n" + exchangeIn + " is " + exchangeOut); 

                Console.ReadKey();
                //TODO: Implement asking the user if they want to restart the application.
        }

        
        public decimal ConvertCurrency(decimal x, byte y, byte z) //float x for the value to convert, string y for the entered input currency, string z for the entered output currency
        {
            //TODO: Rework this part to be less awful and more simple.
            
           
            
            if (y == 0)
            {
                
                _currencyInChar = currencyCharacters[0]; //Sets input currency to Euro
                
                if (z == 1)
                {
                     _output = Math.Round(x * (Decimal)ConversionTable.euroDollar, 2);
                     _currencyOutChar = currencyCharacters[1]; //Sets output currency character to Dollar
                }

                if (z == 0)
                {
                    _output = Math.Round(x, 2);
                    _currencyOutChar = currencyCharacters[0]; //Sets output currency to Euro
                }
            }

            if (y == 1)
            {
                _currencyInChar = currencyCharacters[1]; //Sets input currency character to Dollar

                if (z == 0)
                {
                    _output = Math.Round(x * (Decimal)ConversionTable.dollarEuro, 2);
                    _currencyOutChar = currencyCharacters[0]; //Sets output currency character to Dollar


                }

                if (z == 1)
                {
                    
                    _output = Math.Round(x, 2);
                    _currencyOutChar = currencyCharacters[1];  //Sets output currency character to Dollar

                }
            }
            //float output = x * 1.12f;
            return _output; //Returns the value of the conversion.
        }
        
        
    }
}