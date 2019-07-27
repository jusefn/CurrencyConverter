using System;
namespace CurrencyConverter
{
    public class CurrencyFormat
    {
        public static string FormattingCurrency(string currencyInput, char currency)
        {

            string currencyOutput = null;

            if (currency == Convert.currencyCharacters[0]) //Formats to Euro
            {
                currencyOutput = currencyInput + currency;
                currencyOutput = currencyOutput.Replace(".", ",");

            }
            
            if (currency == Convert.currencyCharacters[1]) //Formats to Dollar
            {
                currencyOutput = currency + currencyInput;

            }
            
            return currencyOutput; //Returns formatted currency.
        }
        
    }
}