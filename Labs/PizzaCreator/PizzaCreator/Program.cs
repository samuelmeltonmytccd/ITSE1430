using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCreator
{
    class Program
    {
        static void Main( string[] args )
        {
            
            //MainMenu();
            NewOrder();
        }

        private static void MainMenu()
        {

        }

        private static void NewOrder()
        {
            //TODO: Need to add the isOrder check properly. Stor 4, first bit: if an order is already created, then the user is first prompted to overwrite the existing order
            //if (isOrder == 1)
            //    Console.WriteLine("If you continue, you will overwrite your existing order. Continue? Y/N");
            
            //choose size
            Console.WriteLine("What size? (1/2/3) \n1) Small ($5) \n2) Medium ($6.25) \n3) Large ($8.75)");
            string sizeInput = Console.ReadLine();
            if (sizeInput == "1")
                pizzaSize = "Small";
            if (sizeInput == "2")
                pizzaSize = "Medium";
            if (sizeInput == "3")
                pizzaSize = "Large";

            DisplayOrder();

            //choose meat
            //We create a bool value for each options(see bottom of "program"). When the user selects an option as displayed, we test that string to see which option they want. Then toggle the corresponding bool.
            //If the user inputs "C", break our while loop and move on. We also display the current order after every user input - so they know if they are selecting or de-selecting. 
            string meatInput = "";
            while (meatInput != "C")
            {
                Console.WriteLine("What meats do you want? You can add as many as you want ($0.75 each). If you select the same meat twice, it will remove it(1/2/3/4/C)\n1) Bacon \n2) Ham \n3) Pepperoni \n4) Sausage ");
                meatInput = Console.ReadLine();

                if (meatInput == "1")
                    isBacon = !isBacon;
                if (meatInput == "2")
                    isHam = !isHam;
                if (meatInput == "3")
                    isPepperoni = !isPepperoni;
                if (meatInput == "4")
                    isSausage = !isSausage;

                DisplayOrder();
            }

        }

        private static void DisplayOrder()
        {

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Pizza size:\n" + pizzaSize);

            //TODO Need logic to figure out what meat was selected
            Console.WriteLine("\nPizza meats:");
            if (isBacon == true)
                Console.WriteLine("Bacon ");
            if (isHam == true)
                Console.WriteLine("Ham ");
            if (isPepperoni == true)
                Console.WriteLine("Pepperoni ");
            if (isSausage == true)
                Console.WriteLine("Sausage");

            Console.WriteLine("\n\n");
            
                


        }

        //private static int isOrder = 1;
        private static string pizzaSize;
        private static bool isBacon = false;
        private static bool isHam = false;
        private static bool isPepperoni = false;
        private static bool isSausage = false;
    }
}
