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

            //var literal1 = "Hello Bob";
            //var path = "C:\\Windows\\System32";
            //var path2 = @"C:\Windows\System32";

            //var i = 10;

            //1. String concat
            Console.WriteLine("Name:\t" + name);

            //2. String Format
            string str = String.Format("Price:\t {0:C}", price);
            Console.WriteLine(str);
            //Console.WriteLine("Price:\t" + price);

            //3. Function overload - just calls string format
            Console.WriteLine("Publisher:\t {0}", publisher);

            //4. concatenation
            //str = String.Concat("Owned?\t", " ", owned);
            //Console.WriteLine(str);
            Console.WriteLine("Owned?\t" + owned);

            //5. Interpolation
            Console.WriteLine($"Completed?\t {completed}");


            /*
            //Convert to a string
            string strPrice = price.ToString("C");

            //Is string empty
            string input = "";
            int length = input.Length;
            bool isEmpty;

            //if (input != null)
            //    isEmpty = input.Length == 0;
            //else
            //    isEmpty = true;

            isEmpty = (input != null) ? input.Length == 0 : true;

            isEmpty = input.Length == 0;
            isEmpty = input == "";
            isEmpty = input == String.Empty;

            isEmpty = String.IsNullOrEmpty(input);

            //Comparison
            bool areEqual = "Hello" == "hello";
            areEqual = String.Compare("Hello", "hello", true) == 0;

            //Conversion
            input = input.ToUpper();
            input = input.ToLower();

            //Manipulation functions
            bool startWith = input.StartsWith("http:");
            bool endsWith = input.EndsWith("/");

            input = input.TrimStart();
            input = input.TrimEnd();
            input = input.Trim();

            input = input.PadLeft(10);
            input = input.PadRight(10, '-');


            */

        }

        private static bool ReadBoolean ( string message)
        {
            do
            {
                Console.WriteLine(message);
                string result = Console.ReadLine().ToUpper();

                //Validate it is a boolean
                if (result == "Y")
                    return true;
                if (result == "N")
                    return false;
                /*
                switch (result)
                {
                    case "Y":
                    case "y": return true;

                    case "N":
                    case "n": return false;

                    default: Console.WriteLine("Enter Y or N"); break;
                }
                */
                Console.WriteLine("Enter Y or N");  
            } while (true);
        }

        private static decimal ReadDecimal ( string message )
        {
            while (true)
            {
                Console.WriteLine(message);
                string value = Console.ReadLine();

                if (Decimal.TryParse(value, out decimal result))
                    return result;

                Console.WriteLine("Not a valid entry.");
            };
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
