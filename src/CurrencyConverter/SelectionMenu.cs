//TODO: Make the selection menu being easily selectable with the arrow buttons if possible. Eventually making a WinForms GUI with Visual Studio.

using System;

namespace CurrencyConverter
{
    public class SelectionMenu
    {
        public static void Menu(string[] args)
        {
            Console.Clear();
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
        
        public static void RestartDialogue(string[] args)
        {
            Console.Write("\nDo you want to restart the application or close the program? (Yes/ENTER to close) ");
            var againConvert = Console.ReadLine();
            if (againConvert == "Yes")
            {
                Menu(args);
            }

        }
    }
}