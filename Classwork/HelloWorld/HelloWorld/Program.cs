/*
 * Multi line comment
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    // Single line comment
    class Program
    {
        static void Main( string[] args )
        {
            NewGame();
            DisplayGame();
        }

        private static void NewGame()
        {
            Console.WriteLine("Enter the name: ");
            name = Console.ReadLine();

            owned = ReadBoolean("Owned? (Y/N)");

            price = ReadDecimal("Price?");

            Console.WriteLine("Publisher?");
            publisher = Console.ReadLine();

            completed = ReadBoolean("Completed? (Y/N)");
        }

        private static void DisplayGame()
        {

            //string literal1 = "Hello Bob";
            //string path = "C:\\Windows\\System32";
            //string path2 = @"C:\Windows\System32";

            Console.WriteLine("Name:\t" + name);
            Console.WriteLine("Price:\t" + price);
            Console.WriteLine("Publisher:\t" + publisher);
            Console.WriteLine("Owned?\t" + owned);
            Console.WriteLine("Completed?\t" + completed);

        }

        private static bool ReadBoolean ( string message)
        {
            Console.WriteLine(message);
            string result = Console.ReadLine();

            //Validate it is a boolean
            //TODO: Fix this expression
            if (result == "Y")
                return true;
            if (result == "y")
                return true;
            if (result == "N")
                return false;
            if (result == "n")
                return false;

            //TODO: Add validation
            return false;
        }

        private static decimal ReadDecimal ( string message )
        {
            Console.WriteLine(message);
            string value = Console.ReadLine();

            if (Decimal.TryParse(value, out decimal result))
                return result;

            return 0;

        }

        private static string name;
        private static string publisher;
        private static decimal price;
        private static bool owned;
        private static bool completed;

    }
}


/*
 * Video game class
Name - string
owned - bool
price - decimal
Publisher - string
Completed? - bool
*/
